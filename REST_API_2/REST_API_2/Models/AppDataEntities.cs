namespace REST_API_2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppDataEntities : DbContext
    {
        public AppDataEntities()
            : base("name=AppDataEntities")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<EmployeeInfo> Employees { get; set; }
    }
}
