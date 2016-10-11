namespace Fitness_application
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.login_btn);
            this.groupBox1.Controls.Add(this.password_tb);
            this.groupBox1.Controls.Add(this.username_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(115, 116);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(79, 23);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(88, 75);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(162, 20);
            this.password_tb.TabIndex = 3;
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(88, 33);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(162, 20);
            this.username_tb.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 185);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

