namespace HTTP_Request_Response
{
    partial class Form1
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
            this.URL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.proxyAddr = new System.Windows.Forms.TextBox();
            this.proxyUser = new System.Windows.Forms.TextBox();
            this.proxyPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ifProxy = new System.Windows.Forms.CheckBox();
            this.response = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(86, 23);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(345, 20);
            this.URL.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // proxyAddr
            // 
            this.proxyAddr.Location = new System.Drawing.Point(86, 104);
            this.proxyAddr.Name = "proxyAddr";
            this.proxyAddr.Size = new System.Drawing.Size(163, 20);
            this.proxyAddr.TabIndex = 3;
            // 
            // proxyUser
            // 
            this.proxyUser.Location = new System.Drawing.Point(291, 105);
            this.proxyUser.Name = "proxyUser";
            this.proxyUser.Size = new System.Drawing.Size(138, 20);
            this.proxyUser.TabIndex = 3;
            // 
            // proxyPassword
            // 
            this.proxyPassword.Location = new System.Drawing.Point(491, 106);
            this.proxyPassword.Name = "proxyPassword";
            this.proxyPassword.Size = new System.Drawing.Size(163, 20);
            this.proxyPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proxy Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "User:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // ifProxy
            // 
            this.ifProxy.AutoSize = true;
            this.ifProxy.Location = new System.Drawing.Point(72, 60);
            this.ifProxy.Name = "ifProxy";
            this.ifProxy.Size = new System.Drawing.Size(52, 17);
            this.ifProxy.TabIndex = 7;
            this.ifProxy.Text = "Proxy";
            this.ifProxy.UseVisualStyleBackColor = true;
            // 
            // response
            // 
            this.response.Location = new System.Drawing.Point(86, 158);
            this.response.Multiline = true;
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(568, 442);
            this.response.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Response:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 630);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.response);
            this.Controls.Add(this.ifProxy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proxyPassword);
            this.Controls.Add(this.proxyUser);
            this.Controls.Add(this.proxyAddr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox proxyAddr;
        private System.Windows.Forms.TextBox proxyUser;
        private System.Windows.Forms.TextBox proxyPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ifProxy;
        private System.Windows.Forms.TextBox response;
        private System.Windows.Forms.Label label5;
    }
}

