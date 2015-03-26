namespace SerialLog
{
    partial class FrmSerialPort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerialPort));
            this.btn_opencom = new System.Windows.Forms.Button();
            this.btn_closecom = new System.Windows.Forms.Button();
            this.txt_showinfo = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBoxHexView = new System.Windows.Forms.CheckBox();
            this.checkBoxHexSend = new System.Windows.Forms.CheckBox();
            this.btn_RtxtClear = new System.Windows.Forms.Button();
            this.cb_box = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblReceivedCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSentCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSerialPortConfig = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_opencom
            // 
            this.btn_opencom.Location = new System.Drawing.Point(609, 32);
            this.btn_opencom.Name = "btn_opencom";
            this.btn_opencom.Size = new System.Drawing.Size(85, 29);
            this.btn_opencom.TabIndex = 19;
            this.btn_opencom.Text = "打开串口(&O)";
            this.btn_opencom.UseVisualStyleBackColor = true;
            this.btn_opencom.Click += new System.EventHandler(this.btn_opencom_Click);
            // 
            // btn_closecom
            // 
            this.btn_closecom.Location = new System.Drawing.Point(609, 79);
            this.btn_closecom.Name = "btn_closecom";
            this.btn_closecom.Size = new System.Drawing.Size(85, 29);
            this.btn_closecom.TabIndex = 20;
            this.btn_closecom.Text = "关闭串口(&C)";
            this.btn_closecom.UseVisualStyleBackColor = true;
            this.btn_closecom.Click += new System.EventHandler(this.btn_closecom_Click);
            // 
            // txt_showinfo
            // 
            this.txt_showinfo.Location = new System.Drawing.Point(6, 15);
            this.txt_showinfo.Multiline = true;
            this.txt_showinfo.Name = "txt_showinfo";
            this.txt_showinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_showinfo.Size = new System.Drawing.Size(564, 206);
            this.txt_showinfo.TabIndex = 21;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(486, 159);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(81, 23);
            this.btnSendData.TabIndex = 23;
            this.btnSendData.Text = "发送(&S)";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 29);
            this.button2.TabIndex = 24;
            this.button2.Text = "退出(&X)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBoxHexView
            // 
            this.checkBoxHexView.AutoSize = true;
            this.checkBoxHexView.Location = new System.Drawing.Point(6, 227);
            this.checkBoxHexView.Name = "checkBoxHexView";
            this.checkBoxHexView.Size = new System.Drawing.Size(96, 16);
            this.checkBoxHexView.TabIndex = 25;
            this.checkBoxHexView.Text = "十六进制显示";
            this.checkBoxHexView.UseVisualStyleBackColor = true;
            // 
            // checkBoxHexSend
            // 
            this.checkBoxHexSend.AutoSize = true;
            this.checkBoxHexSend.Checked = true;
            this.checkBoxHexSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHexSend.Location = new System.Drawing.Point(10, 24);
            this.checkBoxHexSend.Name = "checkBoxHexSend";
            this.checkBoxHexSend.Size = new System.Drawing.Size(96, 16);
            this.checkBoxHexSend.TabIndex = 26;
            this.checkBoxHexSend.Text = "十六进制发送";
            this.checkBoxHexSend.UseVisualStyleBackColor = true;
            // 
            // btn_RtxtClear
            // 
            this.btn_RtxtClear.Location = new System.Drawing.Point(487, 222);
            this.btn_RtxtClear.Name = "btn_RtxtClear";
            this.btn_RtxtClear.Size = new System.Drawing.Size(83, 23);
            this.btn_RtxtClear.TabIndex = 28;
            this.btn_RtxtClear.Text = "清空显示(&C)";
            this.btn_RtxtClear.UseVisualStyleBackColor = true;
            this.btn_RtxtClear.Click += new System.EventHandler(this.btn_RtxtClear_Click);
            // 
            // cb_box
            // 
            this.cb_box.FormattingEnabled = true;
            this.cb_box.Location = new System.Drawing.Point(257, 20);
            this.cb_box.Name = "cb_box";
            this.cb_box.Size = new System.Drawing.Size(311, 20);
            this.cb_box.TabIndex = 31;
            this.cb_box.SelectedIndexChanged += new System.EventHandler(this.cb_box_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(587, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 10);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.cb_box);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.checkBoxHexSend);
            this.groupBox3.Controls.Add(this.btnSendData);
            this.groupBox3.Location = new System.Drawing.Point(12, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 198);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送数据：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(558, 95);
            this.textBox1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 36;
            this.label1.Text = "预定义指令：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_showinfo);
            this.groupBox4.Controls.Add(this.checkBoxHexView);
            this.groupBox4.Controls.Add(this.btn_RtxtClear);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(577, 251);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数据记录";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblReceivedCount);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.lblSentCount);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(-3, 473);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(773, 41);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            // 
            // lblReceivedCount
            // 
            this.lblReceivedCount.AutoSize = true;
            this.lblReceivedCount.Location = new System.Drawing.Point(189, 16);
            this.lblReceivedCount.Name = "lblReceivedCount";
            this.lblReceivedCount.Size = new System.Drawing.Size(11, 12);
            this.lblReceivedCount.TabIndex = 3;
            this.lblReceivedCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "已接收：";
            // 
            // lblSentCount
            // 
            this.lblSentCount.AutoSize = true;
            this.lblSentCount.Location = new System.Drawing.Point(53, 16);
            this.lblSentCount.Name = "lblSentCount";
            this.lblSentCount.Size = new System.Drawing.Size(11, 12);
            this.lblSentCount.TabIndex = 1;
            this.lblSentCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "已发送：";
            // 
            // btnSerialPortConfig
            // 
            this.btnSerialPortConfig.Location = new System.Drawing.Point(609, 126);
            this.btnSerialPortConfig.Name = "btnSerialPortConfig";
            this.btnSerialPortConfig.Size = new System.Drawing.Size(85, 29);
            this.btnSerialPortConfig.TabIndex = 37;
            this.btnSerialPortConfig.Text = "串口设置";
            this.btnSerialPortConfig.UseVisualStyleBackColor = true;
            this.btnSerialPortConfig.Click += new System.EventHandler(this.btnSerialPortConfig_Click);
            // 
            // FrmSerialPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 509);
            this.Controls.Add(this.btnSerialPortConfig);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_closecom);
            this.Controls.Add(this.btn_opencom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSerialPort";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "串口调试工具";
            this.Load += new System.EventHandler(this.FrmSerialPort_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_opencom;
        private System.Windows.Forms.Button btn_closecom;
        private System.Windows.Forms.TextBox txt_showinfo;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBoxHexView;
        private System.Windows.Forms.CheckBox checkBoxHexSend;
        private System.Windows.Forms.Button btn_RtxtClear;
        private System.Windows.Forms.ComboBox cb_box;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblReceivedCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSentCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSerialPortConfig;
        private System.Windows.Forms.TextBox textBox1;
    }
}