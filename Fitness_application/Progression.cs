using EntityFramework_db;
using RegularClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Fitness_application
{
    public partial class Progression : Form
    {
        string username;
        ToolTip ToolTip1 = new ToolTip();
        bool muscle_changed = false;
        string previous_item;


        public Progression(string usern)
        {
            InitializeComponent();
            username = usern;
        }

        private void Progression_Load(object sender, EventArgs e)
        {
            var db = new Model1();
            var selected_exercise = new Exercises();
            select_muscle_cb.DataSource = extract_from_database.all_muscle_names();
            result.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            result.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
        }

        private void result_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void select_muscle_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            muscle_changed = true;
            var db = new Model1();
            var selected_muscle = new Muscles();
            selected_muscle = db.Muscles.Where(m => m.muscle_name == select_muscle_cb.Text).First();
            var ex_list = extract_from_database.exercises_names(selected_muscle);
            pick_ex_cbox.DataSource = ex_list;
            if(display_muscle_cbox.CheckState == CheckState.Checked)
            {
                display_muscle_cbox.CheckState = CheckState.Unchecked;
                charting.clear_series(result, previous_item);
            }
            if (all_muscles_cbox.CheckState == CheckState.Checked)
            {
                all_muscles_cbox.CheckState = CheckState.Unchecked;
                foreach(var item in db.Muscles)
                {
                    charting.clear_series(result, item.muscle_name);
                }
                
            }
            all_muscles_cbox.CheckState = CheckState.Unchecked;
            charting.clear_series(result, previous_item);
            display_muscle_cbox.CheckState = CheckState.Unchecked;
            customize_checkedlistbox.clear(pick_ex_cbox);
            customize_checkedlistbox.check_common_ellements(pick_ex_cbox, result);
            muscle_changed = false;
            previous_item = select_muscle_cb.Text;
        }
        private void pick_ex_cbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if ((e.NewValue == CheckState.Checked) && (muscle_changed == false))
            {
                var db = new Model1();
                var checked_cell = pick_ex_cbox.Items[e.Index].ToString();
                var selected_exercise = db.Exercises.Where(m => m.exercise_name == checked_cell).First();
                var current_username = db.Users.Where(m => m.username == username).First();
                string orderBy = "predefined";
                charting.Total_weight_pertraining(result, current_username, selected_exercise, orderBy);
            }
            if ((e.NewValue == CheckState.Unchecked) && (muscle_changed == false))
            {
                var db = new Model1();
                var unchecked_cell = pick_ex_cbox.Items[e.Index].ToString();
                charting.clear_series(result, unchecked_cell);

                if (result.Series.Count == 1)
                {
                    result.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = true;
                }

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double xMax = result.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
            double yMax = result.ChartAreas[0].AxisY.ScaleView.ViewMaximum;
        }

        private void display_muscle_cbox_CheckStateChanged_1(object sender, EventArgs e)
        {
            var db = new Model1();
            var current_username = db.Users.Where(m => m.username == username).First();
            var selected_muscle = db.Muscles.Where(m => m.muscle_name == select_muscle_cb.Text).First();
            if (display_muscle_cbox.CheckState == CheckState.Checked)
            {
                charting.Total_weight_pertraining(result, current_username, selected_muscle);
                all_muscles_cbox.Enabled = false;
            }
            if (display_muscle_cbox.CheckState == CheckState.Unchecked)
            {
                charting.clear_series(result, select_muscle_cb.Text);
                all_muscles_cbox.Enabled = true;
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            customize_checkedlistbox.clear(pick_ex_cbox);
            charting.clear_series(result);
            all_muscles_cbox.CheckState = CheckState.Unchecked;
            display_muscle_cbox.CheckState = CheckState.Unchecked;
        }

        private void all_muscles_cbox_CheckStateChanged(object sender, EventArgs e)
        {
            var db = new Model1();
            var current_username = db.Users.Where(m => m.username == username).First();
            var selected_muscles = db.Muscles.ToList();
            if (all_muscles_cbox.CheckState == CheckState.Checked)
            {
                foreach(var item in selected_muscles)
                {
                    charting.Total_weight_pertraining(result, current_username, item);
                }
                display_muscle_cbox.Enabled = false;
            }
            if (all_muscles_cbox.CheckState == CheckState.Unchecked)
            {
                foreach (var item in selected_muscles)
                {
                    charting.clear_series(result, item.muscle_name);
                }
                display_muscle_cbox.Enabled = true;
            }
        }
    }
}
