namespace EntityFramework_db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Exercises
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exercises()
        {
            Exercises_trainings = new HashSet<Exercises_trainings>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string exercise_name { get; set; }

        public int id_muscle { get; set; }

        public virtual Muscles Muscles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exercises_trainings> Exercises_trainings { get; set; }
    }
}
