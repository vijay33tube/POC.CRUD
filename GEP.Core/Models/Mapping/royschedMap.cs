using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GEP.Core.Models.Mapping
{
    public class royschedMap : EntityTypeConfiguration<roysched>
    {
        public royschedMap()
        {
            // Primary Key
            this.HasKey(t => new { t.title_id, t.TimeStamp });

            // Properties
            this.Property(t => t.title_id)
                .IsRequired()
                .HasMaxLength(6);

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
            this.ToTable("roysched");
            this.Property(t => t.title_id).HasColumnName("title_id");
            this.Property(t => t.lorange).HasColumnName("lorange");
            this.Property(t => t.hirange).HasColumnName("hirange");
            this.Property(t => t.royalty).HasColumnName("royalty");
            this.Property(t => t.CreateDts).HasColumnName("CreateDts");
            this.Property(t => t.UpdateDts).HasColumnName("UpdateDts");
            this.Property(t => t.CreateSource).HasColumnName("CreateSource");
            this.Property(t => t.UpdateSource).HasColumnName("UpdateSource");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");

            // Relationships
            this.HasRequired(t => t.title)
                .WithMany(t => t.royscheds)
                .HasForeignKey(d => d.title_id);

        }
    }
}
