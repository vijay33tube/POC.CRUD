using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GEP.Core.Models.Mapping
{
    public class jobMap : EntityTypeConfiguration<job>
    {
        public jobMap()
        {
            // Primary Key
            this.HasKey(t => t.job_id);

            // Properties
            this.Property(t => t.job_desc)
                .IsRequired()
                .HasMaxLength(50);

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
            this.ToTable("jobs");
            this.Property(t => t.job_id).HasColumnName("job_id");
            this.Property(t => t.job_desc).HasColumnName("job_desc");
            this.Property(t => t.min_lvl).HasColumnName("min_lvl");
            this.Property(t => t.max_lvl).HasColumnName("max_lvl");
            this.Property(t => t.CreateDts).HasColumnName("CreateDts");
            this.Property(t => t.UpdateDts).HasColumnName("UpdateDts");
            this.Property(t => t.CreateSource).HasColumnName("CreateSource");
            this.Property(t => t.UpdateSource).HasColumnName("UpdateSource");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
        }
    }
}
