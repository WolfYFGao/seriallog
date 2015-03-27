using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;

namespace SerialLog
{
    public partial class FrmSerialPort : Form
    {
        //public int flag;//判断本次窗体调用是那个功能条用
        private System.IO.Ports.SerialPort comport = new System.IO.Ports.SerialPort();//定义串口
        StringBuilder builder = new StringBuilder();


        //避免在事件处理方法中反复的创建，定义到外面。
        private long received_count = 0;
        //接收计数
        private long send_count = 0;
        //发送计数
        //是否没有执行完invoke相关操作
        private bool bClosing = false;

        /// <summary>
        /// /以十六进制方式显示数据，默认为非十六进制方式
        /// </summary>
        /// <param name="style"></param>
        public void SetShowDataStyle(SerialPortDataStyle style)
        {
            if (style == SerialPortDataStyle.Hex)
            {
                this.checkBoxHexView.Checked = true;
            }
            else
            {
                this.checkBoxHexView.Checked = false;
            }

        }
        public void SetSendDataStyle(SerialPortDataStyle style)
        {
            if (style == SerialPortDataStyle.Hex)
            {
                this.checkBoxHexSend.Checked = true;
            }
            else
            {
                this.checkBoxHexSend.Checked = false;
            }
        }


        public FrmSerialPort()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(FrmSerialPort_FormClosing);
            this.btn_opencom.EnabledChanged += new EventHandler(btn_opencom_EnabledChanged);
            comport.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

        }

        void FrmSerialPort_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (comport.IsOpen == true)
            {
                e.Cancel = true;
                MessageBox.Show("请先关闭串口！");
            }
        }

        void btn_opencom_EnabledChanged(object sender, EventArgs e)
        {
            this.btnSerialPortConfig.Enabled = this.btn_opencom.Enabled;
        }

        #region serialport
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {//zxy
            // This method will be called when there is data waiting in the port's buffer
            // Read all the data waiting in the buffer and pasrse it

            /* http://forums.microsoft.com/MSDN/ShowPost.aspx?PageIndex=2&SiteID=1&PostID=293187
             * You would need to use Control.Invoke() to update the GUI controls
             * because unlike Windows Forms events like Button.Click which are processed 
             * in the GUI thread, SerialPort events are processed in a non-GUI thread 
             * (more precisely a ThreadPool thread). 
             */

            if (bClosing)//如果要关闭串口，则此时不再处理串口数据
                return;

            //如果正在关闭，忽略操作，直接返回，完成串口监听线程的一次循环
            try
            {
                //设置标记，说明我已经开始处理数据，      一会儿要使用系统UI的。
                int n = comport.BytesToRead;
                //先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
                byte[] buf = new byte[n];
                //声明一个临时数组存储当前来的串口数据
                received_count += n;
                //增加接收计数
                comport.Read(buf, 0, n);
                //读取缓冲数据

                //判断是否是显示为16进制
                if (checkBoxHexView.Checked)
                {
                    //依次的拼接出16进制字符串
                    foreach (byte b in buf)
                    {
                        builder.Append(b.ToString("X2") + " ");
                    }

                }
                else
                {
                    //直接按ASCII规则转换成字符串
                    builder.Append(Encoding.ASCII.GetString(buf));
                }
                //追加的形式添加到文本框末端，并滚动到最后。
                //this.txt_showinfo.Text = builder.ToString() + this.txt_showinfo.Text;
                Trace.WriteLine(builder.ToString());
                ShowReceiveData(builder.ToString());
                builder.Remove(0, builder.Length);
                HandleReceivedCountText(received_count.ToString());
                //this.lblReceivedCount.Text = received_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Invoke(new EventHandler(HandleSerialData));
        }
        void HandleReceivedCountText(string text)
        {
            Action<string> act = (str) =>
            {
                this.lblReceivedCount.Text = str;
            };
            this.lblReceivedCount.Invoke(act, text);
            //this.lblReceivedCount.Invoke(new deleUpdateContorl(UpdateReceivedCountText), text);

        }
    
        void ShowReceiveData(string infotext)
        {
            Action<string> act = (info) =>
            {
                this.txt_dataReceive.Text = this.txt_dataReceive.Text + info;
            };
            this.txt_dataReceive.Invoke(act, infotext);
        }

        private void HandleSerialData(object s, EventArgs e)
        {
            //if (bClosing)//如果要关闭串口，则此时不再处理串口数据
            //    return;

            //if (Listening)
            //{
            //    return;//此时上一个处理正在进行，放弃此次的数据处理
            //}
            ////  inbuff = comport.ReadExisting();
            ////  if (inbuff != null)
            ////   {
            ////      txt_showinfo.Text += inbuff;

            ////    }
            ////如果正在关闭，忽略操作，直接返回，完成串口监听线程的一次循环
            //try
            //{
            //    Listening = true;
            //    //设置标记，说明我已经开始处理数据，      一会儿要使用系统UI的。
            //    int n = comport.BytesToRead;
            //    //先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
            //    byte[] buf = new byte[n];
            //    //声明一个临时数组存储当前来的串口数据
            //    received_count += n;
            //    //增加接收计数
            //    comport.Read(buf, 0, n);
            //    //读取缓冲数据



            //    //判断是否是显示为16进制
            //    if (checkBoxHexView.Checked)
            //    {
            //        //依次的拼接出16进制字符串
            //        foreach (byte b in buf)
            //        {
            //            builder.Append(b.ToString("X2") + " ");
            //        }

            //    }
            //    else
            //    {
            //        //直接按ASCII规则转换成字符串
            //        builder.Append(Encoding.ASCII.GetString(buf));

            //    }
            //    //追加的形式添加到文本框末端，并滚动到最后。
            //    //this.txt_showinfo.Text += "\r\n接收：";
            //    this.txt_showinfo.Text = builder.ToString() + this.txt_showinfo.Text;
            //    //this.txt_showinfo.AppendText("\n\r" + builder.ToString());
            //    builder.Remove(0, builder.Length);
            //    //修改接收计数
            //    //  labelGetCount.Text = "Get:" + received_count.ToString();
            //    this.lblReceivedCount.Text = received_count.ToString();

            //}
            //finally
            //{
            //    Listening = false;//我用完了，ui可以关闭串口了。
            //}
        }
        #endregion

        private void FrmSerialPort_Load(object sender, EventArgs e)
        {
            btn_closecom.Enabled = false;
        }

        private void btn_opencom_Click(object sender, EventArgs e)
        {
            // 设置串口参数
            if (!comport.IsOpen)
            {
                try
                {
                    Debug.WriteLine("设置串口参数");
                    comport.PortName = Program.serialPortPara.PortName;
                    comport.BaudRate = Program.serialPortPara.BaudRate;
                    comport.DataBits = 8;
                    comport.Parity = Parity.None;
                    comport.StopBits = StopBits.One;
                    comport.Open();//尝试打开串口
                    btn_opencom.Enabled = false;//使打开按钮无效
                    btn_closecom.Enabled = true;    //使关闭按钮有效
                    btnSerialPortConfig.Enabled = false;//不能设置串口参数
                    bClosing = false;

                }
                catch (Exception ex)//进行异常捕获
                {
                    //Trace.WriteLine(ex.Message);
                    //现实异常信息给客户。
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_closecom_Click(object sender, EventArgs e)
        {
            bClosing = true;
            if (comport.IsOpen)
            {
                //打开时点击，则关闭串口
                comport.Close();
                btn_opencom.Enabled = true;
                btn_closecom.Enabled = false;
                btnSerialPortConfig.Enabled = true;//不能设置串口参数
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (!comport.IsOpen)
            {
                MessageBox.Show("串口没有打开，请打开串口！");
                return;
            }
            string textToSend = this.txt_SendData.Text;
            if (textToSend.Length <= 0)
            {
                MessageBox.Show("待发送内容不能为空！");
                return;
            }
            int n = 0;
            //16进制发送
            if (checkBoxHexSend.Checked)
            {
                //正则得到有效的十六进制数
                if (!Regex.IsMatch(textToSend, @"[\da-fA-F]{0,1024}"))
                {
                    MessageBox.Show("输入的内容并不是十六进制数字");
                    return;
                }
                MatchCollection mc = Regex.Matches(textToSend, @"(?i)[\da-f]{2}");
                //MatchCollection mc = Regex.Matches(txt_Send.Text, @"(?i)[\da-f]{2}");
                List<byte> buf = new List<byte>();//填充到这个临时列表中
                //依次添加到列表中
                foreach (Match m in mc)
                {
                    buf.Add(Byte.Parse(m.ToString(), System.Globalization.NumberStyles.HexNumber));
                }
                //  ;
                //转换列表为数组后发送
                comport.Write(buf.ToArray(), 0, buf.Count);
                //记录发送的字节数
                n = buf.Count;
            }
            else//ascii编码直接发送
            {
                string str0;
                str0 = textToSend;
                comport.WriteLine(str0);
                n = textToSend.Length;
            }
            send_count += n;
            //累加发送字节数
            this.lblSentCount.Text = send_count.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_closecom_Click(sender, e);
            this.Close();
        }

        private void btn_RtxtClear_Click(object sender, EventArgs e)
        {
            txt_dataReceive.Clear();
        }

        private void cb_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSerialPortConfig_Click(object sender, EventArgs e)
        {
            FrmSerialPortConfig frm = new FrmSerialPortConfig();
            frm.ShowDialog();
        }
    }

    public enum SerialPortDataStyle
    {

        Hex, Ascii
    }
}
