using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework_db;

namespace Fitness_application
{
    public partial class AddSet : Form
    {
        private int set_nb;
        private Exercises_trainings obj;
        public bool cancel_pressed = false;

        public AddSet(int set_number, Exercises_trainings exercise_tr)
        {
            InitializeComponent();
            set_nb = set_number;
            obj = exercise_tr;
        }

        private void AddSet_Load(object sender, EventArgs e)
        {
            exercise_lbl.Text = "Exercise: " + obj.Exercises.exercise_name;
            setnb_lbl.Text = "Number of set: " + set_nb;
            
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cancel_pressed = true;
            this.Dispose();
        }

        private void AddSet_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            uint num;
            float num2;
            if (((uint.TryParse(reps_tb.Text, out num) != true) || (float.TryParse(weight_tb.Text, out num2)) != true) ||(float.Parse(weight_tb.Text) <1))
            {
                MessageBox.Show("Incorrect fields format!");
            }
            else
            {
                var db = new Model1();
                var set = new Series();
                set.id_exercise_training = obj.id;
                set.set_number = set_nb;
                set.reps = Int32.Parse(reps_tb.Text);
                set.weight = float.Parse(weight_tb.Text);
                db.Series.Add(set);
                db.SaveChanges();
                Close();
            }
        }
    }
}
