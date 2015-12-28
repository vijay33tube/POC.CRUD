using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GEP.Core.Models.Mapping
{
    public class storeMap : EntityTypeConfiguration<store>
    {
        public storeMap()
        {
            // Primary Key
            this.HasKey(t => t.stor_id);

            // Properties
            this.Property(t => t.stor_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.stor_name)
                .HasMaxLength(40);

            this.Property(t => t.stor_address)
                .HasMaxLength(40);

            this.Property(t => t.city)
                .HasMaxLength(20);

            this.Property(t => t.state)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.zip)
                .IsFixedLength()
                .HasMaxLength(5);

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
            this.ToTable("stores");
            this.Property(t => t.stor_id).HasColumnName("stor_id");
            this.Property(t => t.stor_name).HasColumnName("stor_name");
            this.Property(t => t.stor_address).HasColumnName("stor_address");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.CreateDts).HasColumnName("CreateDts");
            this.Property(t => t.UpdateDts).HasColumnName("UpdateDts");
            this.Property(t => t.CreateSource).HasColumnName("CreateSource");
            this.Property(t => t.UpdateSource).HasColumnName("UpdateSource");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
        }
    }
}
