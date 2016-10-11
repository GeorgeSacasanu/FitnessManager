namespace EntityFramework_db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Series
    {
        public int id { get; set; }

        public int id_exercise_training { get; set; }

        public int set_number { get; set; }

        public int reps { get; set; }

        public double weight { get; set; }

        public virtual Exercises_trainings Exercises_trainings { get; set; }
    }
}
