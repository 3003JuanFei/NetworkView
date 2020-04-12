namespace 网络拓扑发现工具.Forms
{
    partial class FormEdit
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
            this.lbl_devicemac = new System.Windows.Forms.Label();
            this.lbl_devicename = new System.Windows.Forms.Label();
            this.lbl_deviceType = new System.Windows.Forms.Label();
            this.txt_mac = new System.Windows.Forms.TextBox();
            this.txt_devicetype = new System.Windows.Forms.TextBox();
            this.txt_hostname = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_devicemac
            // 
            this.lbl_devicemac.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_devicemac.Location = new System.Drawing.Point(30, 27);
            this.lbl_devicemac.Name = "lbl_devicemac";
            this.lbl_devicemac.Size = new System.Drawing.Size(137, 23);
            this.lbl_devicemac.TabIndex = 9;
            this.lbl_devicemac.Text = "MAC地址：";
            this.lbl_devicemac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_devicename
            // 
            this.lbl_devicename.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_devicename.Location = new System.Drawing.Point(30, 96);
            this.lbl_devicename.Name = "lbl_devicename";
            this.lbl_devicename.Size = new System.Drawing.Size(109, 24);
            this.lbl_devicename.TabIndex = 8;
            this.lbl_devicename.Text = "HostName:";
            // 
            // lbl_deviceType
            // 
            this.lbl_deviceType.Location = new System.Drawing.Point(31, 64);
            this.lbl_deviceType.Name = "lbl_deviceType";
            this.lbl_deviceType.Size = new System.Drawing.Size(73, 23);
            this.lbl_deviceType.TabIndex = 7;
            this.lbl_deviceType.Text = "设备类型：";
            // 
            // txt_mac
            // 
            this.txt_mac.Location = new System.Drawing.Point(140, 27);
            this.txt_mac.Name = "txt_mac";
            this.txt_mac.Size = new System.Drawing.Size(219, 21);
            this.txt_mac.TabIndex = 10;
            // 
            // txt_devicetype
            // 
            this.txt_devicetype.Location = new System.Drawing.Point(140, 64);
            this.txt_devicetype.Name = "txt_devicetype";
            this.txt_devicetype.Size = new System.Drawing.Size(219, 21);
            this.txt_devicetype.TabIndex = 11;
            // 
            // txt_hostname
            // 
            this.txt_hostname.Location = new System.Drawing.Point(140, 99);
            this.txt_hostname.Name = "txt_hostname";
            this.txt_hostname.Size = new System.Drawing.Size(219, 21);
            this.txt_hostname.TabIndex = 12;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(248, 140);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(111, 43);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 200);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_hostname);
            this.Controls.Add(this.txt_devicetype);
            this.Controls.Add(this.txt_mac);
            this.Controls.Add(this.lbl_devicemac);
            this.Controls.Add(this.lbl_devicename);
            this.Controls.Add(this.lbl_deviceType);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_devicemac;
        private System.Windows.Forms.Label lbl_devicename;
        private System.Windows.Forms.Label lbl_deviceType;
        private System.Windows.Forms.TextBox txt_mac;
        private System.Windows.Forms.TextBox txt_devicetype;
        private System.Windows.Forms.TextBox txt_hostname;
        private System.Windows.Forms.Button btn_save;
    }
}