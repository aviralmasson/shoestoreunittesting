namespace Shoestore.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DefaultConnection")
        {
        }

       
        public virtual DbSet<Table_3> Table_3 { get; set; }
        public virtual DbSet<Table_4> Table_4 { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_3>()
                .Property(e => e.Models)
                .IsFixedLength();

            modelBuilder.Entity<Table_3>()
                .Property(e => e.city)
                 .IsFixedLength();
                

            modelBuilder.Entity<Table_4>()
                .Property(e => e.models)
                 .IsFixedLength();
                
        }
    }
}
