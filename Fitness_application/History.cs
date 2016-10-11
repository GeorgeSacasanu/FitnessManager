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
using RegularClasses;

namespace Fitness_application
{
    public partial class History : Form
    {
        string usern;
        int training_id;
        bool isadmin;
        public History(string username, bool admin)
        {
            InitializeComponent();
            usern = username;
            isadmin = admin;
        }

        private void History_Load(object sender, EventArgs e)
        {
            training_date_dtp.Format = DateTimePickerFormat.Custom;
            training_date_dtp.CustomFormat = "MM/dd/yyyy-hh:mm:ss";
            customize_datagridview.Trainings_firstload(trainings_out, isadmin, usern, filter_user_cb, label6);
        }

        private void trainings_out_SelectionChanged(object sender, EventArgs e)
        {          
        }

        private void trainings_out_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var db = new Model1();
            if (trainings_out.SelectedRows.Count > 0)
            {
                
                training_date_dtp.Value = Convert.ToDateTime(trainings_out.SelectedRows[0].Cells[1].Value);
                training_id = Convert.ToInt32(trainings_out.SelectedRows[0].Cells[0].Value);
                List<Exercises> ex_list = new List<Exercises>();
               foreach(var item in db.Exercises_trainings.Where(m => m.id_training == training_id))
                {
                    ex_list.Add(item.Exercises);
                }
                exercises_out.DataSource = ex_list;
                customize_datagridview.hide_all_columns(exercises_out, 1);
                customize_datagridview.equalize_columns_size(exercises_out);
                exercise_cb.Items.Clear();
                foreach(var item in db.Exercises)
                {
                    exercise_cb.Items.Add(item.exercise_name);
                }
                exercise_cb.SelectedIndex = -1;
            }
        }

        private void exercises_out_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var db = new Model1();
            if (exercises_out.SelectedRows.Count > 0)
            {
                exercise_cb.SelectedItem = exercises_out.SelectedRows[0].Cells[1].Value.ToString();
                int exercise_id = Convert.ToInt32(exercises_out.SelectedRows[0].Cells[0].Value);
                List<Series> sets_list = new List<Series>();
                foreach (var item in db.Series.Where(m => m.Exercises_trainings.id_exercise == exercise_id).Where(m=>m.Exercises_trainings.id_training == training_id))
                {
                    sets_list.Add(item);
                }
                sets_out.DataSource = sets_list;
                customize_datagridview.hide_all_columns(sets_out, 2, 3, 4);
                customize_datagridview.equalize_columns_size(sets_out);
                setnumber_tb.Text = "";
                reps_tb.Text = "";
                weight_tb.Text = "";
            }
        }

        private void sets_out_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(sets_out.SelectedRows.Count > 0)
            {
                setnumber_tb.Text = sets_out.SelectedRows[0].Cells[2].Value.ToString();
                reps_tb.Text = sets_out.SelectedRows[0].Cells[3].Value.ToString();
                weight_tb.Text = sets_out.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void Save2_btn_Click(object sender, EventArgs e)
        {
            if(exercises_out.SelectedRows.Count == 0)
            {
                MessageBox.Show("No set was selected for update!");
            }
            else
            {
                if(exercise_cb.SelectedIndex == 0)
                {
                    MessageBox.Show("No exercise name was selected for update!");
                }
                else
                {
                    var db = new Model1();
                    var exercise_train = new Exercises_trainings();
                    int exercise_id = Convert.ToInt32(exercises_out.SelectedRows[0].Cells[0].Value);
                    int training_id = Convert.ToInt32(trainings_out.SelectedRows[0].Cells[0].Value);
                    exercise_train = (from x in db.Exercises_trainings where x.id_exercise == exercise_id where x.id_training == training_id select x).First();
                    exercise_train.id_exercise = (from x in db.Exercises where x.exercise_name == exercise_cb.Text select x).First().id;
                    db.SaveChanges();
                    exercises_out.SelectedRows[0].Cells[0].Value = exercise_train.id_exercise;
                    exercises_out.SelectedRows[0].Cells[1].Value = exercise_cb.Text;
                    MessageBox.Show("Item successfully updated.");
                }
            }
        }

        private void Save1_btn_Click(object sender, EventArgs e)
        {
            if (trainings_out.SelectedRows.Count == 0)
            {
                MessageBox.Show("No training was selected for update!");
            }
            else
            {
                var renamed_training = rename.rename_training(Convert.ToInt32(trainings_out.SelectedRows[0].Cells[0].Value), training_date_dtp.Value);
                trainings_out.SelectedRows[0].Cells[1].Value = renamed_training.training_date;
                MessageBox.Show("Item successfully updated.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num;
            float num2;
            if (sets_out.SelectedRows.Count == 0)
            {
                MessageBox.Show("No set was selected for update!");
            }
            else
            {
                if (((int.TryParse(setnumber_tb.Text, out num) != true) ||
                    (int.TryParse(reps_tb.Text, out num) != true)) ||
                    (float.TryParse(weight_tb.Text, out num2) != true))
                {
                    MessageBox.Show("Inserted data must be numeric!");
                }
                else
                {
                    if (((Int32.Parse(setnumber_tb.Text) < 1) || (Int32.Parse(reps_tb.Text) < 1)) || (float.Parse(weight_tb.Text) < 0.1))
                    {
                        MessageBox.Show("Only positive numeric characters are allowed!");
                    }
                    else
                    {
                        var db = new Model1();
                        var set = new Series();
                        int set_id = Convert.ToInt32(sets_out.SelectedRows[0].Cells[0].Value);
                        set = (from x in db.Series where x.id == set_id select x).First();
                        set.set_number = Int32.Parse(setnumber_tb.Text);
                        set.reps = Int32.Parse(reps_tb.Text);
                        set.weight = float.Parse(weight_tb.Text);
                        db.SaveChanges();
                        sets_out.SelectedRows[0].Cells[2].Value = setnumber_tb.Text;
                        sets_out.SelectedRows[0].Cells[3].Value = set.reps;
                        sets_out.SelectedRows[0].Cells[4].Value = set.weight;
                        MessageBox.Show("Item successfully updated.");
                    }

                }
            }
            
        }

        private void Delete1_btn_Click(object sender, EventArgs e)
        {
            if (trainings_out.SelectedRows.Count == 0)
            {
                MessageBox.Show("No training was selected for delete!");
            }
            else
            {
                var db = new Model1();
                var training = new Trainings();
                training.id = Convert.ToInt32(trainings_out.SelectedRows[0].Cells[0].Value);


                foreach (var ex_train in db.Exercises_trainings.Where(m => m.id_training == training.id))
                {
                    foreach (var set in db.Series.Where(x => x.id_exercise_training == ex_train.id))
                    {
                        db.Series.Attach(set);
                        db.Series.Remove(set);
                    }
                    db.Exercises_trainings.Attach(ex_train);
                    db.Exercises_trainings.Remove(ex_train);
                }
                db.Trainings.Attach(training);
                db.Trainings.Remove(training);
                
                db.SaveChanges();
                MessageBox.Show("The item was deleted!");
                
                if (isadmin)
                {
                    trainings_out.Columns.Remove("username");
                    trainings_out.DataSource = db.Trainings.ToList();
                    trainings_out.Refresh();
                    trainings_out.Columns.Add("username", "username");
                    foreach (DataGridViewRow item in trainings_out.Rows)
                    {
                        var user_id = Convert.ToInt32(trainings_out.Rows[item.Index].Cells[2].Value);
                        trainings_out.Rows[item.Index].Cells[5].Value = db.Users.Where(m => m.id == user_id).First().username;
                    }
                }
                else
                {
                    trainings_out.DataSource = db.Trainings.Where(m => m.Users.username == usern).ToList();
                    trainings_out.Refresh();
                }
            }
        }

        private void Delete2_btn_Click(object sender, EventArgs e)
        {
            if (exercises_out.SelectedRows.Count == 0)
            {
                MessageBox.Show("No exercise was selected for delete!");
            }
            else
            {
                var db = new Model1();
                var exercise_id = Convert.ToInt32(exercises_out.SelectedRows[0].Cells[0].Value);
                var training_id = Convert.ToInt32(trainings_out.SelectedRows[0].Cells[0].Value);
                var exer_training = db.Exercises_trainings.Where(m => m.id_exercise == exercise_id).Where(m => m.id_training == training_id).First();
                
                    foreach (var set in db.Series.Where(x => x.id_exercise_training == exer_training.id))
                    {
                        db.Series.Attach(set);
                        db.Series.Remove(set);
                    }
                
                db.Exercises_trainings.Attach(exer_training);
                db.Exercises_trainings.Remove(exer_training);

                db.SaveChanges();
                training_id = Convert.ToInt32(trainings_out.SelectedRows[0].Cells[0].Value);
                List<Exercises> ex_list = new List<Exercises>();
                foreach (var item in db.Exercises_trainings.Where(m => m.id_training == training_id))
                {
                    ex_list.Add(item.Exercises);
                }
                exercises_out.DataSource = ex_list;
                customize_datagridview.hide_all_columns(exercises_out, 1);
                MessageBox.Show("The item was deleted!");

            }

        }

        private void Delete3_btn_Click(object sender, EventArgs e)
        {
            
            if (sets_out.SelectedRows.Count == 0)
            {
                MessageBox.Show("No set was selected for delete!");
            }
            else
            {
                var db = new Model1();
                var set_id = Convert.ToInt32(sets_out.SelectedRows[0].Cells[0].Value);
                var set = db.Series.Where(m => m.id == set_id).First();
                db.Series.Attach(set);
                db.Series.Remove(set);
                db.SaveChanges();
                int exercise_id = Convert.ToInt32(exercises_out.SelectedRows[0].Cells[0].Value);
                List<Series> sets_list = new List<Series>();
                foreach (var item in db.Series.Where(m => m.Exercises_trainings.id_exercise == exercise_id).Where(m => m.Exercises_trainings.id_training == training_id))
                {
                    sets_list.Add(item);
                }
                sets_out.DataSource = sets_list;
                MessageBox.Show("The item was deleted!");
            }
            
        }

        private void filter_user_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter.filter_trainings_by_user(trainings_out, filter_user_cb);
           
        }
    }
} 