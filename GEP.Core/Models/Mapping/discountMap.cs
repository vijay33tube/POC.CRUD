using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GEP.Core.Models.Mapping
{
    public class discountMap : EntityTypeConfiguration<discount>
    {
        public discountMap()
        {
            // Primary Key
            this.HasKey(t => new { t.discounttype, t.discount1, t.TimeStamp });

            // Properties
            this.Property(t => t.discounttype)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.stor_id)
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.discount1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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
            this.ToTable("discounts");
            this.Property(t => t.discounttype).HasColumnName("discounttype");
            this.Property(t => t.stor_id).HasColumnName("stor_id");
            this.Property(t => t.lowqty).HasColumnName("lowqty");
            this.Property(t => t.highqty).HasColumnName("highqty");
            this.Property(t => t.discount1).HasColumnName("discount");
            this.Property(t => t.CreateDts).HasColumnName("CreateDts");
            this.Property(t => t.UpdateDts).HasColumnName("UpdateDts");
            this.Property(t => t.CreateSource).HasColumnName("CreateSource");
            this.Property(t => t.UpdateSource).HasColumnName("UpdateSource");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");

            // Relationships
            this.HasOptional(t => t.store)
                .WithMany(t => t.discounts)
                .HasForeignKey(d => d.stor_id);

        }
    }
}
