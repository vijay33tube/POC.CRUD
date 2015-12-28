using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GEP.Core.Models.Mapping
{
    public class authorMap : EntityTypeConfiguration<author>
    {
        public authorMap()
        {
            // Primary Key
            this.HasKey(t => t.au_id);

            // Properties
            this.Property(t => t.au_id)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.au_lname)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.au_fname)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.phone)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(12);

            this.Property(t => t.address)
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
            this.ToTable("authors");
            this.Property(t => t.au_id).HasColumnName("au_id");
            this.Property(t => t.au_lname).HasColumnName("au_lname");
            this.Property(t => t.au_fname).HasColumnName("au_fname");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.city).HasColumnName("city");
            this.Property(t => t.state).HasColumnName("state");
            this.Property(t => t.zip).HasColumnName("zip");
            this.Property(t => t.contract).HasColumnName("contract");
            this.Property(t => t.CreateDts).HasColumnName("CreateDts");
            this.Property(t => t.UpdateDts).HasColumnName("UpdateDts");
            this.Property(t => t.CreateSource).HasColumnName("CreateSource");
            this.Property(t => t.UpdateSource).HasColumnName("UpdateSource");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
        }
    }
}
