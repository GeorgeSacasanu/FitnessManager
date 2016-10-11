namespace Fitness_application
{
    partial class Progression
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.result = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pick_ex_cbox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.select_muscle_cb = new System.Windows.Forms.ComboBox();
            this.display_muscle_cbox = new System.Windows.Forms.CheckBox();
            this.all_muscles_cbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // result
            // 
            chartArea1.AxisY.LogarithmBase = 15D;
            chartArea1.Name = "ChartArea1";
            this.result.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.result.Legends.Add(legend1);
            this.result.Location = new System.Drawing.Point(24, 23);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(646, 319);
            this.result.TabIndex = 0;
            this.result.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Weight lifted/Training";
            this.result.Titles.Add(title1);
            this.result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.result_MouseMove);
            // 
            // pick_ex_cbox
            // 
            this.pick_ex_cbox.CheckOnClick = true;
            this.pick_ex_cbox.FormattingEnabled = true;
            this.pick_ex_cbox.HorizontalScrollbar = true;
            this.pick_ex_cbox.Location = new System.Drawing.Point(16, 115);
            this.pick_ex_cbox.Name = "pick_ex_cbox";
            this.pick_ex_cbox.Size = new System.Drawing.Size(177, 169);
            this.pick_ex_cbox.TabIndex = 5;
            this.pick_ex_cbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.pick_ex_cbox_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Muscle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pick Exercises";
            // 
            // select_muscle_cb
            // 
            this.select_muscle_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_muscle_cb.FormattingEnabled = true;
            this.select_muscle_cb.Location = new System.Drawing.Point(16, 48);
            this.select_muscle_cb.Name = "select_muscle_cb";
            this.select_muscle_cb.Size = new System.Drawing.Size(177, 21);
            this.select_muscle_cb.TabIndex = 8;
            this.select_muscle_cb.SelectedIndexChanged += new System.EventHandler(this.select_muscle_cb_SelectedIndexChanged);
            // 
            // display_muscle_cbox
            // 
            this.display_muscle_cbox.AutoSize = true;
            this.display_muscle_cbox.Location = new System.Drawing.Point(16, 299);
            this.display_muscle_cbox.Name = "display_muscle_cbox";
            this.display_muscle_cbox.Size = new System.Drawing.Size(94, 17);
            this.display_muscle_cbox.TabIndex = 9;
            this.display_muscle_cbox.Text = "display muscle";
            this.display_muscle_cbox.UseVisualStyleBackColor = true;
            this.display_muscle_cbox.CheckStateChanged += new System.EventHandler(this.display_muscle_cbox_CheckStateChanged_1);
            // 
            // all_muscles_cbox
            // 
            this.all_muscles_cbox.AutoSize = true;
            this.all_muscles_cbox.Location = new System.Drawing.Point(16, 322);
            this.all_muscles_cbox.Name = "all_muscles_cbox";
            this.all_muscles_cbox.Size = new System.Drawing.Size(112, 17);
            this.all_muscles_cbox.TabIndex = 10;
            this.all_muscles_cbox.Text = "display all muscles";
            this.all_muscles_cbox.UseVisualStyleBackColor = true;
            this.all_muscles_cbox.CheckStateChanged += new System.EventHandler(this.all_muscles_cbox_CheckStateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear_btn);
            this.groupBox1.Controls.Add(this.all_muscles_cbox);
            this.groupBox1.Controls.Add(this.display_muscle_cbox);
            this.groupBox1.Controls.Add(this.select_muscle_cb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pick_ex_cbox);
            this.groupBox1.Location = new System.Drawing.Point(693, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 357);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(134, 299);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 11;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Progression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.result);
            this.Name = "Progression";
            this.Text = "Progression";
            this.Load += new System.EventHandler(this.Progression_Load);
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart result;
        private System.Windows.Forms.CheckedListBox pick_ex_cbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox select_muscle_cb;
        private System.Windows.Forms.CheckBox display_muscle_cbox;
        private System.Windows.Forms.CheckBox all_muscles_cbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear_btn;
    }
}