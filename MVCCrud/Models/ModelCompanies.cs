namespace MVCCrud
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelCompanies : DbContext
    {
        public ModelCompanies()
            : base("name=ModelCompanies")
        {
        }

        public virtual DbSet<Directory> Directories { get; set; }
        public virtual DbSet<Logs_Table> Logs_Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
