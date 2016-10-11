namespace Fitness_application
{
    partial class AddSet
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
            this.exercise_lbl = new System.Windows.Forms.Label();
            this.setnb_lbl = new System.Windows.Forms.Label();
            this.Add_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.weight_tb = new System.Windows.Forms.TextBox();
            this.reps_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exercise_lbl);
            this.groupBox1.Controls.Add(this.setnb_lbl);
            this.groupBox1.Controls.Add(this.Add_btn);
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.Controls.Add(this.weight_tb);
            this.groupBox1.Controls.Add(this.reps_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 238);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // exercise_lbl
            // 
            this.exercise_lbl.AutoSize = true;
            this.exercise_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exercise_lbl.Location = new System.Drawing.Point(44, 25);
            this.exercise_lbl.Name = "exercise_lbl";
            this.exercise_lbl.Size = new System.Drawing.Size(35, 13);
            this.exercise_lbl.TabIndex = 8;
            this.exercise_lbl.Text = "label3";
            // 
            // setnb_lbl
            // 
            this.setnb_lbl.AutoSize = true;
            this.setnb_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setnb_lbl.Location = new System.Drawing.Point(44, 58);
            this.setnb_lbl.Name = "setnb_lbl";
            this.setnb_lbl.Size = new System.Drawing.Size(35, 13);
            this.setnb_lbl.TabIndex = 7;
            this.setnb_lbl.Text = "label3";
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(135, 174);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 23);
            this.Add_btn.TabIndex = 6;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(21, 174);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 5;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // weight_tb
            // 
            this.weight_tb.Location = new System.Drawing.Point(96, 128);
            this.weight_tb.Name = "weight_tb";
            this.weight_tb.Size = new System.Drawing.Size(114, 20);
            this.weight_tb.TabIndex = 4;
            // 
            // reps_tb
            // 
            this.reps_tb.Location = new System.Drawing.Point(96, 92);
            this.reps_tb.Name = "reps_tb";
            this.reps_tb.Size = new System.Drawing.Size(114, 20);
            this.reps_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reps";
            // 
            // AddSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddSet";
            this.Text = "AddSet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSet_FormClosing);
            this.Load += new System.EventHandler(this.AddSet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TextBox weight_tb;
        private System.Windows.Forms.TextBox reps_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label setnb_lbl;
        private System.Windows.Forms.Label exercise_lbl;
    }
}