using EntityFramework_db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularClasses
{
    public static class rename
    {
        //public static Exercises_trainings rename_exercise_for_training(int exercise_id, int training_id)
        public static Trainings rename_training(int training_id, DateTime newdate)
        {
            var db = new Model1();
            var training = new Trainings();
            training = (from x in db.Trainings where x.id == training_id select x).First();
            training.training_date = newdate;
            db.SaveChanges();
            return training;
        }

        public static Users update_user(Users olduser, Users newuser)
        {
            var db = new Model1();
            int user_id = olduser.id;
            olduser = db.Users.Where(m => m.id == user_id).First();
            if ((Regex.IsMatch(newuser.username, @"^[0-9a-zA-Z -]+$") == false) || (Regex.IsMatch(newuser.password, @"^[0-9a-zA-Z -]+$") == false))
            {
                return null;
            }
            olduser.username = newuser.username;
            olduser.password = newuser.password;
            olduser.isAdmin = newuser.isAdmin;
            db.SaveChanges();
            return olduser;

        }
        public static string rename_muscle_exercise(ListBox muscles_list, ListBox exercises_list, string muscle_newname, string exercise_newname)
        {
            string output;

            if (muscles_list.SelectedItems.Count < 1)
            {
                output = ("A muscle should be selected first!");
            }
            else
            {
                if (Regex.IsMatch(muscle_newname, @"^[a-zA-Z -]+$") == false)
                {
                    output = ("Only letters, space and hyphen characters are allowed!");
                }
                else
                {
                    var db = new Model1();
                    var muscle = new Muscles();
                    var selected_muscle = muscles_list.GetItemText(muscles_list.SelectedItem);
                    muscle = db.Muscles.Where(m => m.muscle_name == selected_muscle).First();
                    muscle.muscle_name = muscle_newname;


                    if (exercises_list.SelectedItems.Count > 0)
                    {
                        if (Regex.IsMatch(exercise_newname, @"^[a-zA-Z ':-]+$") == false)
                        {
                            output = ("Only letters, space and hyphen characters are allowed!");
                        }
                        else
                        {
                            var exercise = new Exercises();
                            var selected_exercise = exercises_list.GetItemText(exercises_list.SelectedItem);
                            exercise = db.Exercises.Where(m => m.exercise_name == selected_exercise).First();
                            exercise.exercise_name = exercise_newname;
                            db.SaveChanges();
                            exercises_list.Items[exercises_list.SelectedIndex] = exercise_newname;
                            muscles_list.Items[muscles_list.SelectedIndex] = muscle_newname;
                            output = ("Item(s) succesfully updated!");
                        }
                    }
                    else
                    {
                        if (exercise_newname != "")
                        {
                            output = ("Can't modify exercise field if no exercise was selected!");
                        }
                        else
                        {
                            db.SaveChanges();
                            muscles_list.Items[muscles_list.SelectedIndex] = muscle_newname;
                            output = ("Item(s) succesfully updated!");
                        }

                    }

                }
            }

            return output;
        }
    }
}
