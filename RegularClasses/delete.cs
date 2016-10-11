using EntityFramework_db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularClasses
{
    public static class delete
    {
        public static void delete_user(int user_id)
        {
            var db = new Model1();
            var user = new Users();
            user = db.Users.Where(m => m.id == user_id).First();
            foreach(var training in db.Trainings.Where(m=> m.id_users == user.id))
            {
                foreach (var ex_train in db.Exercises_trainings.Where(m => m.id_training == training.id))
                {
                    foreach (var set in db.Series.Where(m => m.Exercises_trainings.id == ex_train.id))
                    {
                        db.Series.Attach(set);
                        db.Series.Remove(set);
                    }
                    db.Exercises_trainings.Attach(ex_train);
                    db.Exercises_trainings.Remove(ex_train);
                }
                db.Trainings.Attach(training);
                db.Trainings.Remove(training);
            }
            db.Users.Attach(user);
            db.Users.Remove(user);
            db.SaveChanges();

        }
        public static void delete_muscle(int muscle_id)
        {
            var db = new Model1();
            var muscle = new Muscles();
            muscle = db.Muscles.Where(m => m.id == muscle_id).First();
            foreach (var ex in db.Exercises.Where(m => m.id_muscle == muscle.id))
            {
                foreach (var ex_train in db.Exercises_trainings.Where(m => m.id_exercise == ex.id))
                {
                    foreach (var set in db.Series.Where(m => m.Exercises_trainings.id == ex_train.id))
                    {
                        db.Series.Attach(set);
                        db.Series.Remove(set);
                    }
                    db.Exercises_trainings.Attach(ex_train);
                    db.Exercises_trainings.Remove(ex_train);
                }
                db.Exercises.Attach(ex);
                db.Exercises.Remove(ex);
            }
            db.Muscles.Attach(muscle);
            db.Muscles.Remove(muscle);
            db.SaveChanges();
        }
        public static void delete_exercise(int exercise_id)
        {
            var db = new Model1();
            var ex = new Exercises();
            ex = db.Exercises.Where(m => m.id == exercise_id).First();
            foreach (var ex_train in db.Exercises_trainings.Where(m => m.id_exercise == ex.id))
            {
                foreach (var set in db.Series.Where(m => m.Exercises_trainings.id == ex_train.id))
                {
                    db.Series.Attach(set);
                    db.Series.Remove(set);
                }
                db.Exercises_trainings.Attach(ex_train);
                db.Exercises_trainings.Remove(ex_train);
            }
            db.Exercises.Attach(ex);
            db.Exercises.Remove(ex);
            db.SaveChanges();
        }
    }
}
