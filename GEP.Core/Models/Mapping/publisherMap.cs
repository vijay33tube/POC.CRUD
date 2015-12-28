using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GEP.Core.Models.Mapping
{
    public class publisherMap : EntityTypeConfiguration<publisher>
    {
        public publisherMap()
        {
            // Primary Key
            this.HasKey(t => t.pub_id);

            // Properties
            this.Property(t => t.pub_id)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            this.Property(t => t.pub_name)
                .HasMaxLength(40);

            this.Property(t => t.city)
                .HasMaxLength(20);

            this.Property(t => t.state)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.country)
                .HasMaxLength(30);

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
            this.ToTable("publishers");
            this.Property(t => t.pub_id).HasColumnName("pub_id");
            this.Property(t => t.pub_name).HasColumnName("pub_name");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.country).HasColumnName("country");
            this.Property(t => t.CreateDts).HasColumnName("CreateDts");
            this.Property(t => t.UpdateDts).HasColumnName("UpdateDts");
            this.Property(t => t.CreateSource).HasColumnName("CreateSource");
            this.Property(t => t.UpdateSource).HasColumnName("UpdateSource");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
        }
    }
}
