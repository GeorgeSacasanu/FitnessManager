namespace EntityFramework_db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Trainings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainings()
        {
            Exercises_trainings = new HashSet<Exercises_trainings>();
        }

        public int id { get; set; }

        public DateTime training_date { get; set; }

        public int id_users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exercises_trainings> Exercises_trainings { get; set; }

        public virtual Users Users { get; set; }
    }
}
