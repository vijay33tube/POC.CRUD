using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GEP.Core.Models.Mapping
{
    public class pub_infoMap : EntityTypeConfiguration<pub_info>
    {
        public pub_infoMap()
        {
            // Primary Key
            this.HasKey(t => t.pub_id);

            // Properties
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
            this.ToTable("pub_info");
            this.Property(t => t.pub_id).HasColumnName("pub_id");
            this.Property(t => t.logo).HasColumnName("logo");
            this.Property(t => t.pr_info).HasColumnName("pr_info");
            this.Property(t => t.CreateDts).HasColumnName("CreateDts");
            this.Property(t => t.UpdateDts).HasColumnName("UpdateDts");
            this.Property(t => t.CreateSource).HasColumnName("CreateSource");
            this.Property(t => t.UpdateSource).HasColumnName("UpdateSource");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");

            // Relationships
            this.HasRequired(t => t.publisher)
                .WithOptional(t => t.pub_info);

        }
    }
}
