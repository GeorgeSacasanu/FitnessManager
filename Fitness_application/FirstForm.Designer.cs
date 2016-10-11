namespace Fitness_application
{
    partial class FirstForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Regular = new System.Windows.Forms.TabPage();
            this.Progress_btn = new System.Windows.Forms.Button();
            this.results_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Finalize_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.Sets_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.date_dtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.exercises_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.muscles_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.update_user_btn = new System.Windows.Forms.Button();
            this.isadmin_cb = new System.Windows.Forms.CheckBox();
            this.users_list = new System.Windows.Forms.ListBox();
            this.delete_user_btn = new System.Windows.Forms.Button();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.user_pass_tb = new System.Windows.Forms.TextBox();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.all_results_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exercises_list = new System.Windows.Forms.ListBox();
            this.delete_exercise_btn = new System.Windows.Forms.Button();
            this.delete_muscle_btn = new System.Windows.Forms.Button();
            this.muscle_tb = new System.Windows.Forms.TextBox();
            this.add_ex_btn = new System.Windows.Forms.Button();
            this.exercise_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rename_muscle_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.muscles_list = new System.Windows.Forms.ListBox();
            this.add_muscle_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.Regular.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Admin.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Regular);
            this.tabControl1.Controls.Add(this.Admin);
            this.tabControl1.Location = new System.Drawing.Point(22, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(714, 546);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Regular
            // 
            this.Regular.BackColor = System.Drawing.Color.Transparent;
            this.Regular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Regular.Controls.Add(this.Progress_btn);
            this.Regular.Controls.Add(this.results_btn);
            this.Regular.Controls.Add(this.groupBox1);
            this.Regular.Location = new System.Drawing.Point(4, 22);
            this.Regular.Name = "Regular";
            this.Regular.Padding = new System.Windows.Forms.Padding(3);
            this.Regular.Size = new System.Drawing.Size(706, 520);
            this.Regular.TabIndex = 0;
            this.Regular.Text = "Regular";
            // 
            // Progress_btn
            // 
            this.Progress_btn.Location = new System.Drawing.Point(179, 299);
            this.Progress_btn.Name = "Progress_btn";
            this.Progress_btn.Size = new System.Drawing.Size(91, 23);
            this.Progress_btn.TabIndex = 4;
            this.Progress_btn.Text = "Progress";
            this.Progress_btn.UseVisualStyleBackColor = true;
            this.Progress_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // results_btn
            // 
            this.results_btn.Location = new System.Drawing.Point(179, 255);
            this.results_btn.Name = "results_btn";
            this.results_btn.Size = new System.Drawing.Size(91, 23);
            this.results_btn.TabIndex = 3;
            this.results_btn.Text = "View Results";
            this.results_btn.UseVisualStyleBackColor = true;
            this.results_btn.Click += new System.EventHandler(this.results_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Finalize_btn);
            this.groupBox1.Controls.Add(this.insert_btn);
            this.groupBox1.Controls.Add(this.Sets_tb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.date_dtp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.exercises_cb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.muscles_cb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Training";
            // 
            // Finalize_btn
            // 
            this.Finalize_btn.Location = new System.Drawing.Point(262, 185);
            this.Finalize_btn.Name = "Finalize_btn";
            this.Finalize_btn.Size = new System.Drawing.Size(108, 23);
            this.Finalize_btn.TabIndex = 9;
            this.Finalize_btn.Text = "Finalize Training";
            this.Finalize_btn.UseVisualStyleBackColor = true;
            this.Finalize_btn.Click += new System.EventHandler(this.Finalize_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(61, 185);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(108, 23);
            this.insert_btn.TabIndex = 8;
            this.insert_btn.Text = "Insert Exercise";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // Sets_tb
            // 
            this.Sets_tb.Location = new System.Drawing.Point(124, 146);
            this.Sets_tb.Name = "Sets_tb";
            this.Sets_tb.Size = new System.Drawing.Size(189, 20);
            this.Sets_tb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of sets";
            // 
            // date_dtp
            // 
            this.date_dtp.CustomFormat = "";
            this.date_dtp.Location = new System.Drawing.Point(124, 111);
            this.date_dtp.Name = "date_dtp";
            this.date_dtp.Size = new System.Drawing.Size(189, 20);
            this.date_dtp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Training Date";
            // 
            // exercises_cb
            // 
            this.exercises_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exercises_cb.FormattingEnabled = true;
            this.exercises_cb.Location = new System.Drawing.Point(124, 75);
            this.exercises_cb.Name = "exercises_cb";
            this.exercises_cb.Size = new System.Drawing.Size(189, 21);
            this.exercises_cb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exercise";
            // 
            // muscles_cb
            // 
            this.muscles_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.muscles_cb.FormattingEnabled = true;
            this.muscles_cb.Location = new System.Drawing.Point(124, 39);
            this.muscles_cb.Name = "muscles_cb";
            this.muscles_cb.Size = new System.Drawing.Size(189, 21);
            this.muscles_cb.TabIndex = 1;
            this.muscles_cb.SelectedIndexChanged += new System.EventHandler(this.muscles_cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Muscle";
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.Transparent;
            this.Admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Admin.Controls.Add(this.groupBox4);
            this.Admin.Controls.Add(this.all_results_btn);
            this.Admin.Controls.Add(this.groupBox2);
            this.Admin.Location = new System.Drawing.Point(4, 22);
            this.Admin.Name = "Admin";
            this.Admin.Padding = new System.Windows.Forms.Padding(3);
            this.Admin.Size = new System.Drawing.Size(706, 520);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Admin";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.update_user_btn);
            this.groupBox4.Controls.Add(this.isadmin_cb);
            this.groupBox4.Controls.Add(this.users_list);
            this.groupBox4.Controls.Add(this.delete_user_btn);
            this.groupBox4.Controls.Add(this.add_user_btn);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.user_pass_tb);
            this.groupBox4.Controls.Add(this.username_tb);
            this.groupBox4.Location = new System.Drawing.Point(457, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 479);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Users";
            // 
            // update_user_btn
            // 
            this.update_user_btn.Location = new System.Drawing.Point(57, 348);
            this.update_user_btn.Name = "update_user_btn";
            this.update_user_btn.Size = new System.Drawing.Size(98, 23);
            this.update_user_btn.TabIndex = 16;
            this.update_user_btn.Text = "Update User";
            this.update_user_btn.UseVisualStyleBackColor = true;
            this.update_user_btn.Click += new System.EventHandler(this.update_user_btn_Click);
            // 
            // isadmin_cb
            // 
            this.isadmin_cb.AutoSize = true;
            this.isadmin_cb.Location = new System.Drawing.Point(22, 310);
            this.isadmin_cb.Name = "isadmin_cb";
            this.isadmin_cb.Size = new System.Drawing.Size(133, 17);
            this.isadmin_cb.TabIndex = 15;
            this.isadmin_cb.Text = "Administrator privileges";
            this.isadmin_cb.UseVisualStyleBackColor = true;
            // 
            // users_list
            // 
            this.users_list.FormattingEnabled = true;
            this.users_list.Location = new System.Drawing.Point(22, 28);
            this.users_list.Name = "users_list";
            this.users_list.Size = new System.Drawing.Size(165, 134);
            this.users_list.TabIndex = 13;
            this.users_list.SelectedIndexChanged += new System.EventHandler(this.users_list_SelectedIndexChanged);
            // 
            // delete_user_btn
            // 
            this.delete_user_btn.Location = new System.Drawing.Point(57, 428);
            this.delete_user_btn.Name = "delete_user_btn";
            this.delete_user_btn.Size = new System.Drawing.Size(100, 23);
            this.delete_user_btn.TabIndex = 12;
            this.delete_user_btn.Text = "Delete User";
            this.delete_user_btn.UseVisualStyleBackColor = true;
            this.delete_user_btn.Click += new System.EventHandler(this.delete_user_btn_Click);
            // 
            // add_user_btn
            // 
            this.add_user_btn.Location = new System.Drawing.Point(57, 389);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(100, 23);
            this.add_user_btn.TabIndex = 11;
            this.add_user_btn.Text = "New User";
            this.add_user_btn.UseVisualStyleBackColor = true;
            this.add_user_btn.Click += new System.EventHandler(this.add_user_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "username";
            // 
            // user_pass_tb
            // 
            this.user_pass_tb.Location = new System.Drawing.Point(22, 267);
            this.user_pass_tb.Name = "user_pass_tb";
            this.user_pass_tb.Size = new System.Drawing.Size(165, 20);
            this.user_pass_tb.TabIndex = 1;
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(22, 212);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(165, 20);
            this.username_tb.TabIndex = 0;
            // 
            // all_results_btn
            // 
            this.all_results_btn.ForeColor = System.Drawing.Color.Maroon;
            this.all_results_btn.Location = new System.Drawing.Point(19, 472);
            this.all_results_btn.Name = "all_results_btn";
            this.all_results_btn.Size = new System.Drawing.Size(100, 23);
            this.all_results_btn.TabIndex = 11;
            this.all_results_btn.Text = "View All Results";
            this.all_results_btn.UseVisualStyleBackColor = true;
            this.all_results_btn.Click += new System.EventHandler(this.all_results_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exercises_list);
            this.groupBox2.Controls.Add(this.delete_exercise_btn);
            this.groupBox2.Controls.Add(this.delete_muscle_btn);
            this.groupBox2.Controls.Add(this.muscle_tb);
            this.groupBox2.Controls.Add(this.add_ex_btn);
            this.groupBox2.Controls.Add(this.exercise_tb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rename_muscle_btn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.muscles_list);
            this.groupBox2.Controls.Add(this.add_muscle_btn);
            this.groupBox2.Location = new System.Drawing.Point(31, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 357);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Muscles/Exercises";
            // 
            // exercises_list
            // 
            this.exercises_list.FormattingEnabled = true;
            this.exercises_list.Location = new System.Drawing.Point(214, 28);
            this.exercises_list.Name = "exercises_list";
            this.exercises_list.ScrollAlwaysVisible = true;
            this.exercises_list.Size = new System.Drawing.Size(165, 134);
            this.exercises_list.TabIndex = 2;
            this.exercises_list.SelectedIndexChanged += new System.EventHandler(this.exercises_lb_SelectedIndexChanged);
            // 
            // delete_exercise_btn
            // 
            this.delete_exercise_btn.Location = new System.Drawing.Point(279, 294);
            this.delete_exercise_btn.Name = "delete_exercise_btn";
            this.delete_exercise_btn.Size = new System.Drawing.Size(100, 23);
            this.delete_exercise_btn.TabIndex = 10;
            this.delete_exercise_btn.Text = "Delete Exercise";
            this.delete_exercise_btn.UseVisualStyleBackColor = true;
            this.delete_exercise_btn.Click += new System.EventHandler(this.delete_exercise_btn_Click);
            // 
            // delete_muscle_btn
            // 
            this.delete_muscle_btn.Location = new System.Drawing.Point(25, 294);
            this.delete_muscle_btn.Name = "delete_muscle_btn";
            this.delete_muscle_btn.Size = new System.Drawing.Size(100, 23);
            this.delete_muscle_btn.TabIndex = 9;
            this.delete_muscle_btn.Text = "Delete Muscle";
            this.delete_muscle_btn.UseVisualStyleBackColor = true;
            this.delete_muscle_btn.Click += new System.EventHandler(this.delete_muscle_btn_Click);
            // 
            // muscle_tb
            // 
            this.muscle_tb.Location = new System.Drawing.Point(25, 212);
            this.muscle_tb.Name = "muscle_tb";
            this.muscle_tb.Size = new System.Drawing.Size(165, 20);
            this.muscle_tb.TabIndex = 5;
            // 
            // add_ex_btn
            // 
            this.add_ex_btn.Location = new System.Drawing.Point(279, 254);
            this.add_ex_btn.Name = "add_ex_btn";
            this.add_ex_btn.Size = new System.Drawing.Size(100, 22);
            this.add_ex_btn.TabIndex = 3;
            this.add_ex_btn.Text = "New Exercise";
            this.add_ex_btn.UseVisualStyleBackColor = true;
            this.add_ex_btn.Click += new System.EventHandler(this.add_ex_btn_Click);
            // 
            // exercise_tb
            // 
            this.exercise_tb.Location = new System.Drawing.Point(214, 212);
            this.exercise_tb.Name = "exercise_tb";
            this.exercise_tb.Size = new System.Drawing.Size(165, 20);
            this.exercise_tb.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Exercise";
            // 
            // rename_muscle_btn
            // 
            this.rename_muscle_btn.Location = new System.Drawing.Point(149, 254);
            this.rename_muscle_btn.Name = "rename_muscle_btn";
            this.rename_muscle_btn.Size = new System.Drawing.Size(100, 23);
            this.rename_muscle_btn.TabIndex = 8;
            this.rename_muscle_btn.Text = "Rename";
            this.rename_muscle_btn.UseVisualStyleBackColor = true;
            this.rename_muscle_btn.Click += new System.EventHandler(this.rename_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Muscle";
            // 
            // muscles_list
            // 
            this.muscles_list.FormattingEnabled = true;
            this.muscles_list.Location = new System.Drawing.Point(25, 28);
            this.muscles_list.Name = "muscles_list";
            this.muscles_list.ScrollAlwaysVisible = true;
            this.muscles_list.Size = new System.Drawing.Size(165, 134);
            this.muscles_list.TabIndex = 1;
            this.muscles_list.SelectedIndexChanged += new System.EventHandler(this.muscles_lb_SelectedIndexChanged);
            // 
            // add_muscle_btn
            // 
            this.add_muscle_btn.Location = new System.Drawing.Point(25, 254);
            this.add_muscle_btn.Name = "add_muscle_btn";
            this.add_muscle_btn.Size = new System.Drawing.Size(100, 22);
            this.add_muscle_btn.TabIndex = 0;
            this.add_muscle_btn.Text = "New Muscle";
            this.add_muscle_btn.UseVisualStyleBackColor = true;
            this.add_muscle_btn.Click += new System.EventHandler(this.add_muscle_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logoutToolStripMenuItem.Text = "Log-out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 597);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.Load += new System.EventHandler(this.FirstForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.Regular.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Admin.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Regular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.TextBox Sets_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_dtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox exercises_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox muscles_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Admin;
        private System.Windows.Forms.Button add_muscle_btn;
        private System.Windows.Forms.Button results_btn;
        private System.Windows.Forms.Button Finalize_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox exercise_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox muscle_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_ex_btn;
        private System.Windows.Forms.ListBox exercises_list;
        private System.Windows.Forms.ListBox muscles_list;
        private System.Windows.Forms.Button rename_muscle_btn;
        private System.Windows.Forms.Button all_results_btn;
        private System.Windows.Forms.Button delete_exercise_btn;
        private System.Windows.Forms.Button delete_muscle_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button delete_user_btn;
        private System.Windows.Forms.Button add_user_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox user_pass_tb;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.ListBox users_list;
        private System.Windows.Forms.CheckBox isadmin_cb;
        private System.Windows.Forms.Button update_user_btn;
        private System.Windows.Forms.Button Progress_btn;
    }
}