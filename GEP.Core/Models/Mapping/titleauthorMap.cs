using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GEP.Core.Models.Mapping
{
    public class titleauthorMap : EntityTypeConfiguration<titleauthor>
    {
        public titleauthorMap()
        {
            // Primary Key
            this.HasKey(t => new { t.au_id, t.title_id });

            // Properties
            this.Property(t => t.au_id)
                .IsRequired()
                .HasMaxLength(11);

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
            this.ToTable("titleauthor");
            this.Property(t => t.au_id).HasColumnName("au_id");
            this.Property(t => t.title_id).HasColumnName("title_id");
            this.Property(t => t.au_ord).HasColumnName("au_ord");
            this.Property(t => t.royaltyper).HasColumnName("royaltyper");
            this.Property(t => t.CreateDts).HasColumnName("CreateDts");
            this.Property(t => t.UpdateDts).HasColumnName("UpdateDts");
            this.Property(t => t.CreateSource).HasColumnName("CreateSource");
            this.Property(t => t.UpdateSource).HasColumnName("UpdateSource");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");

            // Relationships
            this.HasRequired(t => t.author)
                .WithMany(t => t.titleauthors)
                .HasForeignKey(d => d.au_id);
            this.HasRequired(t => t.title)
                .WithMany(t => t.titleauthors)
                .HasForeignKey(d => d.title_id);

        }
    }
}
