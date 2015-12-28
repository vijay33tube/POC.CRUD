using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GEP.Core.Models.Mapping
{
    public class titleMap : EntityTypeConfiguration<title>
    {
        public titleMap()
        {
            // Primary Key
            this.HasKey(t => t.title_id);

            // Properties
            this.Property(t => t.title_id)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.title1)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.pub_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.notes)
                .HasMaxLength(200);

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
            this.ToTable("titles");
            this.Property(t => t.title_id).HasColumnName("title_id");
            this.Property(t => t.title1).HasColumnName("title");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.pub_id).HasColumnName("pub_id");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.advance).HasColumnName("advance");
            this.Property(t => t.royalty).HasColumnName("royalty");
            this.Property(t => t.ytd_sales).HasColumnName("ytd_sales");
            this.Property(t => t.notes).HasColumnName("notes");
            this.Property(t => t.pubdate).HasColumnName("pubdate");
            this.Property(t => t.CreateDts).HasColumnName("CreateDts");
            this.Property(t => t.UpdateDts).HasColumnName("UpdateDts");
            this.Property(t => t.CreateSource).HasColumnName("CreateSource");
            this.Property(t => t.UpdateSource).HasColumnName("UpdateSource");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");

            // Relationships
            this.HasOptional(t => t.publisher)
                .WithMany(t => t.titles)
                .HasForeignKey(d => d.pub_id);

        }
    }
}
