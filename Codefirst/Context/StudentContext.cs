using Codefirst.Mappers;
using Codefirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Codefirst.Context
{
    public class StudentContext : DbContext
    {
        public StudentContext() :
            base("studonstr")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentContext,Configuration>());
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new StudentMapper());
            
        }
    }
}