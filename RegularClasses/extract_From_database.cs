using EntityFramework_db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularClasses
{
    public static class extract_from_database
    {
        public static Muscles muscle(string musclename)
        {
            var db = new Model1();
            var muscle = db.Muscles.Where(m => m.muscle_name == musclename).First();
            return muscle;
        }
        public static List<String> all_muscle_names()
        {
            var db = new Model1();
            List<string> output = new List<string>();
            foreach(var item in db.Muscles)
            {
                output.Add(item.muscle_name);
            }
            return output;
        }
        public static List<Exercises> all_exercises()
        {
            var db = new Model1();
            var output = new List<Exercises>();
            foreach (var item in db.Exercises)
            {
                output.Add(item);
            }
            return output;
        }
        public static List<Exercises> exercises(Muscles muscle)
        {
            var output = new List<Exercises>();
            foreach (var item in muscle.Exercises)
            {
                output.Add(item);
            }
            return output;
        }
        public static List<String> all_exercises_names()
        {
            var db = new Model1();
            var output = new List<String>();
            foreach (var item in db.Exercises)
            {
                output.Add(item.exercise_name);
            }
            return output;
        }
        public static List<String> exercises_names(Muscles muscle)
        {
            var output = new List<String>();
            foreach (var item in muscle.Exercises)
            {
                output.Add(item.exercise_name);
            }
            return output;
        }
      
    }
}
