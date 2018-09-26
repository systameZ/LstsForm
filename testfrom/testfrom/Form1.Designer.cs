namespace testfrom
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSeri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShowData = new System.Windows.Forms.TextBox();
            this.lbClient = new System.Windows.Forms.ListBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDefault = new System.Windows.Forms.TextBox();
            this.btnSqlInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(414, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 46);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "监听端口：";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(487, 22);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(113, 25);
            this.tbPort.TabIndex = 1;
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPort_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率：";
            // 
            // tbRate
            // 
            this.tbRate.Location = new System.Drawing.Point(487, 84);
            this.tbRate.Name = "tbRate";
            this.tbRate.Size = new System.Drawing.Size(113, 25);
            this.tbRate.TabIndex = 3;
            this.tbRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRate_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "串口号：";
            // 
            // tbSeri
            // 
            this.tbSeri.Location = new System.Drawing.Point(487, 53);
            this.tbSeri.Name = "tbSeri";
            this.tbSeri.Size = new System.Drawing.Size(113, 25);
            this.tbSeri.TabIndex = 2;
            this.tbSeri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeri_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "客户端列表";
            // 
            // txtShowData
            // 
            this.txtShowData.BackColor = System.Drawing.SystemColors.Control;
            this.txtShowData.Location = new System.Drawing.Point(0, 13);
            this.txtShowData.Margin = new System.Windows.Forms.Padding(4);
            this.txtShowData.Multiline = true;
            this.txtShowData.Name = "txtShowData";
            this.txtShowData.ReadOnly = true;
            this.txtShowData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShowData.Size = new System.Drawing.Size(405, 354);
            this.txtShowData.TabIndex = 8;
            // 
            // lbClient
            // 
            this.lbClient.FormattingEnabled = true;
            this.lbClient.ItemHeight = 15;
            this.lbClient.Location = new System.Drawing.Point(445, 177);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(155, 124);
            this.lbClient.TabIndex = 5;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(412, 321);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(98, 46);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "开启";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "默认值：";
            // 
            // tbDefault
            // 
            this.tbDefault.Location = new System.Drawing.Point(487, 115);
            this.tbDefault.Name = "tbDefault";
            this.tbDefault.Size = new System.Drawing.Size(113, 25);
            this.tbDefault.TabIndex = 4;
            this.tbDefault.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRate_KeyPress);
            // 
            // btnSqlInfo
            // 
            this.btnSqlInfo.Location = new System.Drawing.Point(519, 321);
            this.btnSqlInfo.Name = "btnSqlInfo";
            this.btnSqlInfo.Size = new System.Drawing.Size(98, 46);
            this.btnSqlInfo.TabIndex = 7;
            this.btnSqlInfo.Text = "配置数据库";
            this.btnSqlInfo.UseVisualStyleBackColor = true;
            this.btnSqlInfo.Click += new System.EventHandler(this.btnSqlInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 380);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.txtShowData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDefault);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSeri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSqlInfo);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "服务端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSeri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShowData;
        private System.Windows.Forms.ListBox lbClient;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDefault;
        private System.Windows.Forms.Button btnSqlInfo;
    }
}

