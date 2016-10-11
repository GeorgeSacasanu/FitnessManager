namespace EntityFramework_db
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Exercises> Exercises { get; set; }
        public virtual DbSet<Exercises_trainings> Exercises_trainings { get; set; }
        public virtual DbSet<Muscles> Muscles { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<Trainings> Trainings { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exercises>()
                .Property(e => e.exercise_name)
                .IsUnicode(false);

            modelBuilder.Entity<Exercises>()
                .HasMany(e => e.Exercises_trainings)
                .WithRequired(e => e.Exercises)
                .HasForeignKey(e => e.id_exercise)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Exercises_trainings>()
                .HasMany(e => e.Series)
                .WithRequired(e => e.Exercises_trainings)
                .HasForeignKey(e => e.id_exercise_training)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Muscles>()
                .Property(e => e.muscle_name)
                .IsUnicode(false);

            modelBuilder.Entity<Muscles>()
                .HasMany(e => e.Exercises)
                .WithRequired(e => e.Muscles)
                .HasForeignKey(e => e.id_muscle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Trainings>()
                .HasMany(e => e.Exercises_trainings)
                .WithRequired(e => e.Trainings)
                .HasForeignKey(e => e.id_training)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Trainings)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.id_users)
                .WillCascadeOnDelete(false);
        }
    }
}
