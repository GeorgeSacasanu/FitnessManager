using EntityFramework_db;
using RegularClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fitness_application
{
    public partial class FirstForm : Form
    {

        public string usern;
        public bool isAdm;
        bool training_started = false;
        Trainings inserted_training = new Trainings();

        public FirstForm(string username, bool isAdmin)
        {
            
            InitializeComponent();
            usern = username;
            isAdm = isAdmin;
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            this.Width = 505;
            this.Height = 460;
            tabControl1.Width = 450;
            tabControl1.Height = 370;

            muscles_list.HorizontalScrollbar = true;
            exercises_list.HorizontalScrollbar = true;
            date_dtp.Format = DateTimePickerFormat.Custom;
            date_dtp.CustomFormat = "MM/dd/yyyy-hh:mm:ss";
            Finalize_btn.Enabled = false;
            if (isAdm == false)
            {
                Admin.Enabled = false;
                tabControl1.TabPages.RemoveAt(1);
            }

            var db = new Model1();

            foreach (var item in db.Muscles)
            {
                muscles_cb.Items.Add(item.muscle_name);
                muscles_list.Items.Add(item.muscle_name);
            }
            foreach (var item in db.Users)
            {
                users_list.Items.Add(item.username);
            }
        }

        private void muscles_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new Model1();
            //exercises_cb.DataSource = null;
            //exercises_cb.Items.Clear();
            var selected = new Muscles();
            selected = db.Muscles.Where(m => m.muscle_name == muscles_cb.Text).FirstOrDefault();
            var ex_list = extract_from_database.exercises_names(selected);
            exercises_cb.DataSource = ex_list;
            

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            Finalize_btn.Enabled = true;
            int num;
            if((exercises_cb.Text == "") || (muscles_cb.Text == ""))
            {
                MessageBox.Show("Muscle and Exercise fields cannot be empty!");
            }
            else
            {
                if ((int.TryParse(Sets_tb.Text, out num) != true) || (Int32.Parse(Sets_tb.Text) < 1))
                {
                    MessageBox.Show("Invalid format for the field: Number of sets!");
                }
                else
                {
                    var db = new Model1();
                    var obj = new add_into_database();
                    Exercises_trainings inserted_extrain = new Exercises_trainings();
                    if (training_started == false)
                    {
                        training_started = true;
                        inserted_training = obj.add_training(usern, date_dtp.Value);
                    }

                    inserted_extrain = obj.add_exercise_training(exercises_cb.Text, inserted_training.id);
                    obj.add_sets(inserted_extrain, Int32.Parse(Sets_tb.Text));
                    Sets_tb.Text = "";

                }
            }
            
        }

        private void results_btn_Click(object sender, EventArgs e)
        {
            History f = new History(usern, false);
            f.ShowDialog();

        }

        private void Finalize_btn_Click(object sender, EventArgs e)
        {
            training_started = false;
            date_dtp.Enabled = true;
            date_dtp.Value = DateTime.Now;
            muscles_cb.SelectedIndex = 0;
            exercises_cb.SelectedIndex = -1;
            Sets_tb.Text = "";
            MessageBox.Show("Current training has been completed. Input data will correspond to a new training.");
            Finalize_btn.Enabled = false;
        }

        private void muscles_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            exercises_list.Items.Clear();
            var db = new Model1();
            string selected_muscle = muscles_list.GetItemText(muscles_list.SelectedItem);
            foreach (var item in db.Exercises.Where(m => m.Muscles.muscle_name == selected_muscle))
            {
                exercises_list.Items.Add(item.exercise_name);
            }
            muscle_tb.Text = selected_muscle;
            exercise_tb.Text = "";
        }

        private void exercises_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected_exercise = exercises_list.GetItemText(exercises_list.SelectedItem);
            exercise_tb.Text = selected_exercise;
        }

        private void rename_btn_Click(object sender, EventArgs e)
        {
            var new_muscle = muscles_list.GetItemText(muscles_list.SelectedItem);
            var output = rename.rename_muscle_exercise(muscles_list, exercises_list, muscle_tb.Text, exercise_tb.Text);
            switch (output)
            {
                case ("Item(s) succesfully updated!"):
                    {
                        MessageBox.Show(output);
                        int index = muscles_cb.Items.IndexOf(new_muscle);
                        muscles_cb.Items[index] = muscle_tb.Text;
                        break;
                    }
                    
                default:
                    {
                        MessageBox.Show(output);
                        break;
                    }
            }
        }

        private void add_muscle_btn_Click(object sender, EventArgs e)
        {
            var obj = new add_into_database();
            var insert = obj.add_muscle();
            if (insert!= null)
            {
                muscles_list.Items.Add(insert);
                muscles_cb.Items.Add(insert);
                MessageBox.Show("Muscle group succesfully created.");
            }
        }

        private void add_ex_btn_Click(object sender, EventArgs e)
        {
            if (muscles_list.SelectedItems.Count < 1)
            {
                MessageBox.Show("A muscle group should be selected first!");
            }
            else
            {
                var obj = new add_into_database();
                var input = obj.add_exercise(muscles_list.GetItemText(muscles_list.SelectedItem));
                if(input!= null)
                {
                    exercises_list.Items.Add(input);
                    MessageBox.Show("Exercise succesfully created.");
                }
            }
        }

        private void all_results_btn_Click(object sender, EventArgs e)
        {
            History f = new History(usern, true);
            f.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f = new Login();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void delete_muscle_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All saved data including users records will be removed for this muscle group. Do you want to continue?", "Delete Muscle", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if(muscles_list.SelectedItems.Count < 1)
                {
                    MessageBox.Show("A muscle group should be selected in the list!");
                }
                else
                {
                    var db = new Model1();
                    var muscle = new Muscles();
                    muscle.muscle_name = muscles_list.GetItemText(muscles_list.SelectedItem);
                    muscle.id = db.Muscles.Where(m => m.muscle_name == muscle.muscle_name).First().id;
                    delete.delete_muscle(muscle.id);
                    muscles_list.Items.Remove(muscles_list.Items[muscles_list.SelectedIndex]);
                    exercises_list.Items.Clear();
                    muscles_cb.Items.Remove(muscle.muscle_name);
                }
            }
        }

        private void delete_exercise_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All saved data including users records will be removed for this exercise. Do you want to continue?", "Delete Muscle", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if ((exercises_list.SelectedItems.Count < 1) || (muscles_list.SelectedItems.Count < 1))
                {
                    MessageBox.Show("An exercise and a muscle group should be selected in the list!");
                }
                else
                {
                    var db = new Model1();
                    var exercise = new Exercises();
                    exercise.exercise_name = exercises_list.GetItemText(exercises_list.SelectedItem);
                    exercise.id = db.Exercises.Where(m => m.exercise_name == exercise.exercise_name).First().id;
                    delete.delete_exercise(exercise.id); 
                    exercises_list.Items.Remove(exercises_list.Items[exercises_list.SelectedIndex]);
                    exercises_cb.Items.Remove(exercise.exercise_name);
                }
            }
                

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == Admin)
            {
                FirstForm.ActiveForm.Width = 777;
                FirstForm.ActiveForm.Height = 636;
                tabControl1.Width = 714;
                tabControl1.Height = 546;
            }
            else
            {
                FirstForm.ActiveForm.Width = 505;
                FirstForm.ActiveForm.Height = 460;
                tabControl1.Width = 450;
                tabControl1.Height = 370;
            }
        }

        private void users_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            isadmin_cb.Checked = false;
            var db = new Model1();
            string selected_username = users_list.GetItemText(users_list.SelectedItem);
            if(selected_username!= "")
            {
                var selected_user = db.Users.Where(m => m.username == selected_username).First();
                username_tb.Text = selected_user.username;
                user_pass_tb.Text = selected_user.password;
                if (selected_user.isAdmin)
                {
                    isadmin_cb.Checked = true;
                }
            }
            else
            {
                username_tb.Text = "";
                user_pass_tb.Text = "";
            }
        }

        private void add_user_btn_Click(object sender, EventArgs e)
        {
            var obj = new add_into_database();
            var insert = obj.add_user();
            if (insert != null)
            {
                users_list.Items.Add(insert);
                MessageBox.Show("The user was succesfully created.");
            }
        }

        private void delete_user_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All saved data will be removed for this user. Do you want to continue?", "Delete User", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (users_list.SelectedItems.Count < 1)
                {
                    MessageBox.Show("A user should be selected in the list!");
                }
                else
                {
                    var db = new Model1();
                    var user = new Users();
                    var selected_username = users_list.GetItemText(users_list.SelectedItem);
                    user = db.Users.Where(m => m.username == selected_username).First();
                    delete.delete_user(user.id);
                    users_list.Items.Remove(users_list.Items[users_list.SelectedIndex]);
                    MessageBox.Show("The user has been succesfully removed.");
                }
            }
        }

        private void update_user_btn_Click(object sender, EventArgs e)
        {
            var db = new Model1();
            var selected_user = users_list.GetItemText(users_list.SelectedItem);
            var olduser = db.Users.Where(m => m.username == selected_user).First();
            var newuser = new Users();
            newuser.username = username_tb.Text;
            newuser.password = user_pass_tb.Text;
            newuser.isAdmin = isadmin_cb.Checked;
            if(rename.update_user(olduser, newuser)==null)
            {
                MessageBox.Show("Only letters, space and hyphen characters are allowed!");
            }
            else
            {
                users_list.Items[users_list.SelectedIndex] = newuser.username;
                MessageBox.Show("User succesfully updated.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Progression f = new Progression(usern);
            f.Show();
        }
    }
}
