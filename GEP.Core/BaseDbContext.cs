using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEP.Core
{
    public abstract class BaseDbContext : DbContext
    {
        public BaseDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        #region Methods

        public override int SaveChanges()
        {
            try
            {
                if (ChangeTracker.HasChanges())
                {
                    DateTime now = DateTime.Now.ToUniversalTime();
                    // Need to have uniformity of time across the entire transaction
                    //Get inserts for modifying create and update date
                    List<DbEntityEntry> inserts =
                        ChangeTracker.Entries().Where(i => i.State == EntityState.Added).ToList();
                    //Get updates and deletes for updating update date
                    List<DbEntityEntry> updates =
                        ChangeTracker.Entries()
                            .Where(i => i.State == EntityState.Modified || i.State == EntityState.Deleted)
                            .ToList();

                    inserts.ForEach(i =>
                    {
                        SetPropertyValue(i, "CreateDts", now);
                        SetPropertyValue(i, "UpdateDts", now);
                    });

                    updates.ForEach(i => SetPropertyValue(i, "UpdateDts", now));
                }

                return base.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SetPropertyValue(DbEntityEntry entity, string propertyName, object value)
        {
            DbPropertyEntry property = entity.Property(propertyName);
            if (property == null)
                throw new Exception(String.Format("Object property {0} could not be found", propertyName));

            if (entity.State != EntityState.Deleted)
                entity.CurrentValues[property.Name] = value;
        }

        #endregion Methods
    }
}
