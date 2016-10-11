using EntityFramework_db;
using Fitness_application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularClasses
{
    public class add_into_database
    {
        public string add_user()
        {
            string input_username = prompt.ShowDialog("Insert the username:", "Add Username");
            string input_password = null;
            if (input_username!= null)
            {
                var db = new Model1();
                if(db.Users.Where(m=> m.username == input_username).Count() > 0)
                {
                    MessageBox.Show("There already is an user with this name.");
                    input_username = null;
                }
                else
                {
                    input_password = prompt.ShowDialog("Insert the password:", "Add Password");
                    if(input_password!=null)
                    {
                        var is_admin = false;
                        DialogResult user_type = MessageBox.Show("Do you want to promote " + input_username + " as administrator? This will unlock the Admin dashboard for this user.", "User type", MessageBoxButtons.YesNo);
                        if(user_type == DialogResult.Yes)
                        {
                            is_admin = true;
                        }
                        var user = new Users();
                        user.username = input_username;
                        user.password = input_password;
                        user.isAdmin = is_admin;
                        db.Users.Add(user);
                        db.SaveChanges();
                    }
                }
            }
            if(input_password == null)
            {
                input_username = null;
            }
            return input_username;
        }

        public string add_muscle() // ADD MUSCLE
        {
            string input = prompt.ShowDialog("Insert the name of the muscle group:", "Add Muscle");
            if (input != null)
            {
                var db = new Model1();
                if (db.Muscles.Where(m => m.muscle_name == input).Count() > 0)
                {
                    MessageBox.Show("There already is an item with this name.");
                    input = null;
                }
                else
                {
                    var muscle = new Muscles();
                    muscle.muscle_name = input;
                    db.Muscles.Add(muscle);
                    db.SaveChanges();
                }
            }
            return input;
        }

        public string add_exercise(string selected_muscle) // ADD EXERCISE
        {
                string input = prompt.ShowDialog("Insert the name of the exercise:", "Add Exercise");
                if (input != null)
                {

                    var db = new Model1();
                    if (db.Exercises.Where(m => m.exercise_name == input).Count() > 0)
                    {
                        MessageBox.Show("There already is an item with this name.");
                        input = null;
                    }
                    else
                    {
                        var exercise = new Exercises();
                        exercise.exercise_name = input;
                        exercise.id_muscle = db.Muscles.Where(m => m.muscle_name == selected_muscle).First().id;
                        db.Exercises.Add(exercise);
                        db.SaveChanges();
                    }
                }
            return input;
        }

        public Trainings add_training(string username, DateTime training_date)
        {
            var db = new Model1();
            var training = new Trainings();
            training.id_users = (from x in db.Users where x.username == username select x).First().id;
            training.training_date = training_date;
            db.Trainings.Add(training);
            db.SaveChanges();
            return training;
        }
        public Exercises_trainings add_exercise_training(string ex_name, int training_id)
        {
            var db = new Model1();
            var exer_train = new Exercises_trainings();
            exer_train.id_training = training_id;
            exer_train.id_exercise = (from x in db.Exercises where x.exercise_name == ex_name select x).First().id;
            db.Exercises_trainings.Add(exer_train);
            db.SaveChanges();
            return exer_train;
        }

        public void add_sets(Exercises_trainings exer_train, int setnumber)
        {
            var db = new Model1();
            int i;
            for (i = 1; i <= setnumber; i++)
            {
                AddSet f = new AddSet(i, exer_train);
                f.ShowDialog();
                if (f.cancel_pressed == true)
                {
                    break;
                }
                if (i == setnumber)
                {
                    MessageBox.Show("Exercise succesfully added!");
                }

            }
        }

    }
}
