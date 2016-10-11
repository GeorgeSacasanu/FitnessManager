using EntityFramework_db;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RegularClasses
{
    public static class charting
    {
        public static void Total_weight_pertraining(Chart result, Users current_user, Muscles selected_muscle)
        {
            var db = new Model1();
            bool trigger = false;
            List<Trainings> train_list = new List<Trainings>();
            foreach (var training in db.Trainings.Where(m => m.id_users == current_user.id))
            {
                train_list.Add(training);
            }
            train_list = train_list.OrderBy(x => x.training_date).ToList();
            result.Series.Add(selected_muscle.muscle_name);
            var index = result.Series.IndexOf(selected_muscle.muscle_name);
            result.Series[index].ChartType = SeriesChartType.Line;
            foreach (var training in train_list)
            {
                double total_lifted = 0;
                foreach (var ex in db.Exercises.Where(m => m.id_muscle == selected_muscle.id))
                {
                    
                    foreach (var ex_train in db.Exercises_trainings.Where(m => m.id_training == training.id).Where(m => m.id_exercise == ex.id))
                    {

                        foreach (var set in db.Series.Where(m => m.id_exercise_training == ex_train.id))
                        {
                            trigger = true;
                            total_lifted += set.weight * set.reps;
                        }
                    }
                }
                if (trigger == true)
                {
                    //DateTime dt = DateTime.ParseExact(training.training_date.ToString("dd/MM/yyyy/hh/mm/ss"), "dd/MM/yyyy/hh/mm/ss", CultureInfo.InvariantCulture);
                    result.Series[selected_muscle.muscle_name].Points.AddXY(training.training_date.ToString("dd/MM/yyyy-hh:mm"), total_lifted);
                    trigger = false;
                }
                
            }
        }
        public static void Total_weight_pertraining(Chart result, Users current_user, Exercises selected_exercise, string orderBy)
        {
            var db = new Model1();
            bool trigger = false;
            List<Trainings> train_list = new List<Trainings>();
            foreach (var training in db.Trainings.Where(m => m.id_users == current_user.id))
            {
                train_list.Add(training);
            }

            train_list = train_list.OrderBy(x => x.training_date).ToList();

            
            result.Series.Add(selected_exercise.exercise_name);
            var index = result.Series.IndexOf(selected_exercise.exercise_name);
            result.Series[index].ChartType = SeriesChartType.Line;
            foreach (var training in train_list)
            {
                double total_lifted = 0;
                foreach (var ex_train in db.Exercises_trainings.Where(m => m.id_training == training.id).Where(m => m.id_exercise == selected_exercise.id))
                {

                    foreach (var set in db.Series.Where(m => m.id_exercise_training == ex_train.id))
                    {
                        trigger = true;
                        total_lifted += set.weight * set.reps;
                    }
                }
                if (trigger == true)
                {
                    switch(orderBy)
                    {
                        case "predefined":
                            {
                                if (result.Series.Count > 1)
                                {
                                    result.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                                }
                                result.Series[selected_exercise.exercise_name].Points.AddXY(training.training_date.ToString("dd/MM/yyyy-hh:mm").Substring(0, 16), total_lifted);
                                break;
                            }
                        case "date":
                            {
                                DateTime dt = DateTime.ParseExact(training.training_date.ToString("dd/MM/yyyy").Substring(0, 10), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                result.Series[selected_exercise.exercise_name].Points.AddXY(dt, total_lifted);
                                break;
                            }
                    }

                    trigger = false;

                }


            }
        }
        public static void clear_series(Chart result, string series_name)
        {
            foreach(var series in result.Series)
            {
                if(series.Name.ToString() == series_name.ToString())
                {
                    //series.Points.Clear();
                    result.Series.Remove(series);
                    break;
                }
            }
        }
        public static void clear_series(Chart result)
        {
            
            for (int i = 0; i< result.Series.Count; i++)
            {
                var item = result.Series[i];
                result.Series.Remove(item);
                i--;
            }
        }
    }
}
