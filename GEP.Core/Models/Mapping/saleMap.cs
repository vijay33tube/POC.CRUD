using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GEP.Core.Models.Mapping
{
    public class saleMap : EntityTypeConfiguration<sale>
    {
        public saleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.stor_id, t.ord_num, t.title_id });

            // Properties
            this.Property(t => t.stor_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.ord_num)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.payterms)
                .IsRequired()
                .HasMaxLength(12);

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
            this.ToTable("sales");
            this.Property(t => t.stor_id).HasColumnName("stor_id");
            this.Property(t => t.ord_num).HasColumnName("ord_num");
            this.Property(t => t.ord_date).HasColumnName("ord_date");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.payterms).HasColumnName("payterms");
            this.Property(t => t.title_id).HasColumnName("title_id");
            this.Property(t => t.CreateDts).HasColumnName("CreateDts");
            this.Property(t => t.UpdateDts).HasColumnName("UpdateDts");
            this.Property(t => t.CreateSource).HasColumnName("CreateSource");
            this.Property(t => t.UpdateSource).HasColumnName("UpdateSource");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");

            // Relationships
            this.HasRequired(t => t.store)
                .WithMany(t => t.sales)
                .HasForeignKey(d => d.stor_id);
            this.HasRequired(t => t.title)
                .WithMany(t => t.sales)
                .HasForeignKey(d => d.title_id);

        }
    }
}
