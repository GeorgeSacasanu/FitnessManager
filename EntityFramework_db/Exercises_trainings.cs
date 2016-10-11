namespace EntityFramework_db
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Exercises_trainings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exercises_trainings()
        {
            Series = new HashSet<Series>();
        }

        public int id { get; set; }

        public int id_exercise { get; set; }

        public int id_training { get; set; }

        public virtual Exercises Exercises { get; set; }

        public virtual Trainings Trainings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Series> Series { get; set; }
    }
}
