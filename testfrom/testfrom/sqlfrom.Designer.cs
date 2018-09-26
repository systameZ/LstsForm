namespace testfrom
{
    partial class sqlfrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSerIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.tbUid = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbCloname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP：";
            // 
            // tbSerIp
            // 
            this.tbSerIp.Location = new System.Drawing.Point(82, 27);
            this.tbSerIp.Name = "tbSerIp";
            this.tbSerIp.Size = new System.Drawing.Size(124, 25);
            this.tbSerIp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "DATA：";
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(82, 58);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(124, 25);
            this.tbData.TabIndex = 2;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(37, 92);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(39, 15);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "UID:";
            // 
            // tbUid
            // 
            this.tbUid.Location = new System.Drawing.Point(82, 89);
            this.tbUid.Name = "tbUid";
            this.tbUid.Size = new System.Drawing.Size(124, 25);
            this.tbUid.TabIndex = 3;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(37, 123);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(39, 15);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "PWD:";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(82, 120);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.Size = new System.Drawing.Size(124, 25);
            this.tbPwd.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(46, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(132, 221);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 33);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbCloname
            // 
            this.tbCloname.Location = new System.Drawing.Point(82, 182);
            this.tbCloname.Name = "tbCloname";
            this.tbCloname.Size = new System.Drawing.Size(124, 25);
            this.tbCloname.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "列名：";
            // 
            // tbTableName
            // 
            this.tbTableName.Location = new System.Drawing.Point(82, 151);
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(124, 25);
            this.tbTableName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "表名：";
            // 
            // sqlfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 265);
            this.Controls.Add(this.tbCloname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTableName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbPwd);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.tbUid);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSerIp);
            this.Controls.Add(this.label1);
            this.Name = "sqlfrom";
            this.Text = "数据配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSerIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tbUid;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbCloname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTableName;
        private System.Windows.Forms.Label label3;
    }
}