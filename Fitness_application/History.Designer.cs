namespace Fitness_application
{
    partial class History
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
            this.Trainings_tab = new System.Windows.Forms.TabPage();
            this.trainings_out = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filter_user_cb = new System.Windows.Forms.ComboBox();
            this.training_date_dtp = new System.Windows.Forms.DateTimePicker();
            this.Delete1_btn = new System.Windows.Forms.Button();
            this.Save1_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Exercises_tab = new System.Windows.Forms.TabPage();
            this.exercises_out = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exercise_cb = new System.Windows.Forms.ComboBox();
            this.Delete2_btn = new System.Windows.Forms.Button();
            this.Save2_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Sets_tab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.setnumber_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.weight_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Delete3_btn = new System.Windows.Forms.Button();
            this.save3_btn = new System.Windows.Forms.Button();
            this.reps_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sets_out = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Trainings_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainings_out)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Exercises_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exercises_out)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.Sets_tab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sets_out)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Trainings_tab);
            this.tabControl1.Controls.Add(this.Exercises_tab);
            this.tabControl1.Controls.Add(this.Sets_tab);
            this.tabControl1.Location = new System.Drawing.Point(21, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 313);
            this.tabControl1.TabIndex = 0;
            // 
            // Trainings_tab
            // 
            this.Trainings_tab.BackColor = System.Drawing.Color.Transparent;
            this.Trainings_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Trainings_tab.Controls.Add(this.trainings_out);
            this.Trainings_tab.Controls.Add(this.groupBox1);
            this.Trainings_tab.Location = new System.Drawing.Point(4, 22);
            this.Trainings_tab.Name = "Trainings_tab";
            this.Trainings_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Trainings_tab.Size = new System.Drawing.Size(480, 287);
            this.Trainings_tab.TabIndex = 0;
            this.Trainings_tab.Text = "Trainings";
            // 
            // trainings_out
            // 
            this.trainings_out.AllowDrop = true;
            this.trainings_out.Location = new System.Drawing.Point(16, 17);
            this.trainings_out.MultiSelect = false;
            this.trainings_out.Name = "trainings_out";
            this.trainings_out.ReadOnly = true;
            this.trainings_out.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.trainings_out.Size = new System.Drawing.Size(193, 237);
            this.trainings_out.TabIndex = 5;
            this.trainings_out.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.trainings_out_CellClick);
            this.trainings_out.SelectionChanged += new System.EventHandler(this.trainings_out_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.filter_user_cb);
            this.groupBox1.Controls.Add(this.training_date_dtp);
            this.groupBox1.Controls.Add(this.Delete1_btn);
            this.groupBox1.Controls.Add(this.Save1_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(224, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Filter by user:";
            // 
            // filter_user_cb
            // 
            this.filter_user_cb.AllowDrop = true;
            this.filter_user_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filter_user_cb.FormattingEnabled = true;
            this.filter_user_cb.Location = new System.Drawing.Point(23, 176);
            this.filter_user_cb.Name = "filter_user_cb";
            this.filter_user_cb.Size = new System.Drawing.Size(197, 21);
            this.filter_user_cb.TabIndex = 6;
            this.filter_user_cb.SelectedIndexChanged += new System.EventHandler(this.filter_user_cb_SelectedIndexChanged);
            // 
            // training_date_dtp
            // 
            this.training_date_dtp.Location = new System.Drawing.Point(23, 55);
            this.training_date_dtp.Name = "training_date_dtp";
            this.training_date_dtp.Size = new System.Drawing.Size(197, 20);
            this.training_date_dtp.TabIndex = 5;
            // 
            // Delete1_btn
            // 
            this.Delete1_btn.Location = new System.Drawing.Point(104, 95);
            this.Delete1_btn.Name = "Delete1_btn";
            this.Delete1_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete1_btn.TabIndex = 4;
            this.Delete1_btn.Text = "Delete";
            this.Delete1_btn.UseVisualStyleBackColor = true;
            this.Delete1_btn.Click += new System.EventHandler(this.Delete1_btn_Click);
            // 
            // Save1_btn
            // 
            this.Save1_btn.Location = new System.Drawing.Point(23, 95);
            this.Save1_btn.Name = "Save1_btn";
            this.Save1_btn.Size = new System.Drawing.Size(75, 23);
            this.Save1_btn.TabIndex = 3;
            this.Save1_btn.Text = "Save";
            this.Save1_btn.UseVisualStyleBackColor = true;
            this.Save1_btn.Click += new System.EventHandler(this.Save1_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Training Date";
            // 
            // Exercises_tab
            // 
            this.Exercises_tab.BackColor = System.Drawing.Color.Transparent;
            this.Exercises_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Exercises_tab.Controls.Add(this.exercises_out);
            this.Exercises_tab.Controls.Add(this.groupBox2);
            this.Exercises_tab.Location = new System.Drawing.Point(4, 22);
            this.Exercises_tab.Name = "Exercises_tab";
            this.Exercises_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Exercises_tab.Size = new System.Drawing.Size(480, 287);
            this.Exercises_tab.TabIndex = 1;
            this.Exercises_tab.Text = "Exercises";
            // 
            // exercises_out
            // 
            this.exercises_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exercises_out.Location = new System.Drawing.Point(15, 17);
            this.exercises_out.MultiSelect = false;
            this.exercises_out.Name = "exercises_out";
            this.exercises_out.ReadOnly = true;
            this.exercises_out.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.exercises_out.Size = new System.Drawing.Size(193, 237);
            this.exercises_out.TabIndex = 4;
            this.exercises_out.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exercises_out_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.exercise_cb);
            this.groupBox2.Controls.Add(this.Delete2_btn);
            this.groupBox2.Controls.Add(this.Save2_btn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(223, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 237);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // exercise_cb
            // 
            this.exercise_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exercise_cb.FormattingEnabled = true;
            this.exercise_cb.Location = new System.Drawing.Point(23, 57);
            this.exercise_cb.Name = "exercise_cb";
            this.exercise_cb.Size = new System.Drawing.Size(176, 21);
            this.exercise_cb.TabIndex = 5;
            // 
            // Delete2_btn
            // 
            this.Delete2_btn.Location = new System.Drawing.Point(104, 102);
            this.Delete2_btn.Name = "Delete2_btn";
            this.Delete2_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete2_btn.TabIndex = 4;
            this.Delete2_btn.Text = "Delete";
            this.Delete2_btn.UseVisualStyleBackColor = true;
            this.Delete2_btn.Click += new System.EventHandler(this.Delete2_btn_Click);
            // 
            // Save2_btn
            // 
            this.Save2_btn.Location = new System.Drawing.Point(23, 102);
            this.Save2_btn.Name = "Save2_btn";
            this.Save2_btn.Size = new System.Drawing.Size(75, 23);
            this.Save2_btn.TabIndex = 3;
            this.Save2_btn.Text = "Save";
            this.Save2_btn.UseVisualStyleBackColor = true;
            this.Save2_btn.Click += new System.EventHandler(this.Save2_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exercise name";
            // 
            // Sets_tab
            // 
            this.Sets_tab.BackColor = System.Drawing.Color.Transparent;
            this.Sets_tab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sets_tab.Controls.Add(this.groupBox3);
            this.Sets_tab.Controls.Add(this.sets_out);
            this.Sets_tab.Location = new System.Drawing.Point(4, 22);
            this.Sets_tab.Name = "Sets_tab";
            this.Sets_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Sets_tab.Size = new System.Drawing.Size(480, 287);
            this.Sets_tab.TabIndex = 2;
            this.Sets_tab.Text = "Sets";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.setnumber_tb);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.weight_tb);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.Delete3_btn);
            this.groupBox3.Controls.Add(this.save3_btn);
            this.groupBox3.Controls.Add(this.reps_tb);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(223, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 250);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // setnumber_tb
            // 
            this.setnumber_tb.Location = new System.Drawing.Point(19, 51);
            this.setnumber_tb.Name = "setnumber_tb";
            this.setnumber_tb.Size = new System.Drawing.Size(141, 20);
            this.setnumber_tb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Set number";
            // 
            // weight_tb
            // 
            this.weight_tb.Location = new System.Drawing.Point(19, 170);
            this.weight_tb.Name = "weight_tb";
            this.weight_tb.Size = new System.Drawing.Size(141, 20);
            this.weight_tb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Weight";
            // 
            // Delete3_btn
            // 
            this.Delete3_btn.Location = new System.Drawing.Point(100, 214);
            this.Delete3_btn.Name = "Delete3_btn";
            this.Delete3_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete3_btn.TabIndex = 4;
            this.Delete3_btn.Text = "Delete";
            this.Delete3_btn.UseVisualStyleBackColor = true;
            this.Delete3_btn.Click += new System.EventHandler(this.Delete3_btn_Click);
            // 
            // save3_btn
            // 
            this.save3_btn.Location = new System.Drawing.Point(19, 214);
            this.save3_btn.Name = "save3_btn";
            this.save3_btn.Size = new System.Drawing.Size(75, 23);
            this.save3_btn.TabIndex = 3;
            this.save3_btn.Text = "Save";
            this.save3_btn.UseVisualStyleBackColor = true;
            this.save3_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // reps_tb
            // 
            this.reps_tb.Location = new System.Drawing.Point(19, 112);
            this.reps_tb.Name = "reps_tb";
            this.reps_tb.Size = new System.Drawing.Size(141, 20);
            this.reps_tb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reps";
            // 
            // sets_out
            // 
            this.sets_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sets_out.Location = new System.Drawing.Point(15, 16);
            this.sets_out.MultiSelect = false;
            this.sets_out.Name = "sets_out";
            this.sets_out.ReadOnly = true;
            this.sets_out.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sets_out.Size = new System.Drawing.Size(193, 237);
            this.sets_out.TabIndex = 1;
            this.sets_out.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sets_out_CellClick);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 346);
            this.Controls.Add(this.tabControl1);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.tabControl1.ResumeLayout(false);
            this.Trainings_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainings_out)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Exercises_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exercises_out)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Sets_tab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sets_out)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Trainings_tab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Delete1_btn;
        private System.Windows.Forms.Button Save1_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Exercises_tab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox exercise_cb;
        private System.Windows.Forms.Button Delete2_btn;
        private System.Windows.Forms.Button Save2_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage Sets_tab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox weight_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Delete3_btn;
        private System.Windows.Forms.Button save3_btn;
        private System.Windows.Forms.TextBox reps_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView sets_out;
        private System.Windows.Forms.DataGridView trainings_out;
        private System.Windows.Forms.DateTimePicker training_date_dtp;
        private System.Windows.Forms.DataGridView exercises_out;
        private System.Windows.Forms.TextBox setnumber_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox filter_user_cb;
    }
}