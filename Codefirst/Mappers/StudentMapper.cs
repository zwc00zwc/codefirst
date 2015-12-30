using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using Codefirst.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codefirst.Mappers
{
    public class StudentMapper : EntityTypeConfiguration<Student>
    {
        public StudentMapper()
        {
            this.ToTable("StudentInfo");

            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Id).IsRequired();

            this.Property(c => c.Email).IsRequired();
            this.Property(c => c.Email).HasMaxLength(255);

            this.Property(c => c.UserName).IsRequired();
            this.Property(c => c.UserName).HasMaxLength(255);

            this.Property(c => c.Password).IsRequired();
            this.Property(c => c.Password).HasMaxLength(255);

            this.Property(c => c.FirstName).IsRequired();
            this.Property(c => c.FirstName).HasMaxLength(255);

            this.Property(c => c.LastName).HasMaxLength(255);

            this.Property(c => c.Age).HasColumnType("int");
        }
    }
}