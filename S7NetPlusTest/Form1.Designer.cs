namespace S7NetPlusTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.地址 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_val = new System.Windows.Forms.TextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.lbMsg = new System.Windows.Forms.Label();
            this.cb_ip = new System.Windows.Forms.ComboBox();
            this.cb_addr = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP：";
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_connect.Location = new System.Drawing.Point(361, 89);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(88, 31);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // 地址
            // 
            this.地址.AutoSize = true;
            this.地址.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.地址.Location = new System.Drawing.Point(18, 148);
            this.地址.Name = "地址";
            this.地址.Size = new System.Drawing.Size(73, 21);
            this.地址.TabIndex = 3;
            this.地址.Text = "地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "数值：";
            // 
            // txt_val
            // 
            this.txt_val.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_val.Location = new System.Drawing.Point(85, 195);
            this.txt_val.Name = "txt_val";
            this.txt_val.Size = new System.Drawing.Size(208, 31);
            this.txt_val.TabIndex = 6;
            this.txt_val.Text = "0";
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_read.Location = new System.Drawing.Point(361, 138);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(88, 31);
            this.btn_read.TabIndex = 7;
            this.btn_read.Text = "读取";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_write
            // 
            this.btn_write.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_write.Location = new System.Drawing.Point(361, 195);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(88, 31);
            this.btn_write.TabIndex = 8;
            this.btn_write.Text = "写入";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(24, 269);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(29, 12);
            this.lbMsg.TabIndex = 9;
            this.lbMsg.Text = "……";
            // 
            // cb_ip
            // 
            this.cb_ip.FormattingEnabled = true;
            this.cb_ip.Items.AddRange(new object[] {
            "192.168.1.10",
            "192.168.1.20",
            "192.168.1.30"});
            this.cb_ip.Location = new System.Drawing.Point(85, 99);
            this.cb_ip.Name = "cb_ip";
            this.cb_ip.Size = new System.Drawing.Size(208, 20);
            this.cb_ip.TabIndex = 10;
            // 
            // cb_addr
            // 
            this.cb_addr.FormattingEnabled = true;
            this.cb_addr.Items.AddRange(new object[] {
            "DB2000.DBW2",
            "DB2000.DBW4",
            "DB2000.DBC42.50",
            "DB2000.DBC94.50"});
            this.cb_addr.Location = new System.Drawing.Point(85, 148);
            this.cb_addr.Name = "cb_addr";
            this.cb_addr.Size = new System.Drawing.Size(208, 20);
            this.cb_addr.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 321);
            this.Controls.Add(this.cb_addr);
            this.Controls.Add(this.cb_ip);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.txt_val);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.地址);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "S7NetPlusTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label 地址;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_val;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.ComboBox cb_ip;
        private System.Windows.Forms.ComboBox cb_addr;
    }
}

