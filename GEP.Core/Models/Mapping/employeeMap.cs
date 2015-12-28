using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GEP.Core.Models.Mapping
{
    public class employeeMap : EntityTypeConfiguration<employee>
    {
        public employeeMap()
        {
            // Primary Key
            this.HasKey(t => t.emp_id);

            // Properties
            this.Property(t => t.emp_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.fname)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.minit)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.lname)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.pub_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.CreateSource)
                .HasMaxLength(200);

            this.Property(t => t.UpdateSource)
                .HasMaxLength(200);

            this.Property(t => t.TimeStamp)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("employee");
            this.Property(t => t.emp_id).HasColumnName("emp_id");
            this.Property(t => t.fname).HasColumnName("fname");
            this.Property(t => t.minit).HasColumnName("minit");
            this.Property(t => t.lname).HasColumnName("lname");
            this.Property(t => t.job_id).HasColumnName("job_id");
            this.Property(t => t.job_lvl).HasColumnName("job_lvl");
            this.Property(t => t.pub_id).HasColumnName("pub_id");
            this.Property(t => t.hire_date).HasColumnName("hire_date");
            this.Property(t => t.CreateDts).HasColumnName("CreateDts");
            this.Property(t => t.UpdateDts).HasColumnName("UpdateDts");
            this.Property(t => t.CreateSource).HasColumnName("CreateSource");
            this.Property(t => t.UpdateSource).HasColumnName("UpdateSource");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");

            // Relationships
            this.HasRequired(t => t.job)
                .WithMany(t => t.employees)
                .HasForeignKey(d => d.job_id);
            this.HasRequired(t => t.publisher)
                .WithMany(t => t.employees)
                .HasForeignKey(d => d.pub_id);

        }
    }
}
