using GEP.Core;
using GEP.Core.Models;
using GEP.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GEP.Data
{
    public abstract class AbstractDao<TContext, T, TId> : ICrudDao<T>
        where TContext : BaseDbContext, new()
        where T : BaseEntity
        where TId : IComparable
    {
        public IList<T> GetAll()
        {
            IList<T> result = null;
            using (TContext dbContext = GetDbContext())
            {
                result = dbContext.Set<T>().ToList();
            }
            return result;
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            T entity = null;
            using (TContext dbContext = GetDbContext())
            {
                entity = dbContext.Set<T>().Where(predicate).FirstOrDefault();
            }
            return entity;
        }

        public void Add(T entity)
        {
            using (TContext dbContext = GetDbContext())
            {
                entity = dbContext.Set<T>().Add(entity);
                Save(dbContext);
            }
        }

        public void Update(T entity)
        {
            using (TContext dbContext = GetDbContext())
            {
                entity = dbContext.Set<T>().Add(entity);
                dbContext.Entry<T>(entity).State = EntityState.Modified;
                Save(dbContext);
            }
        }

        public void Remove(Expression<Func<T, bool>> predicate)
        {
            using (TContext dbContext = GetDbContext())
            {
                T entity = dbContext.Set<T>().Where(predicate).FirstOrDefault();
                dbContext.Set<T>().Remove(entity);
                Save(dbContext);
            }
        }        

        public TContext GetDbContext()
        {
            TContext tContext = new TContext();
            tContext.Configuration.ProxyCreationEnabled = false;
            tContext.Configuration.AutoDetectChangesEnabled = false;
            tContext.Configuration.LazyLoadingEnabled = false;            

            return tContext;
        }

        private void Save(TContext dbContext)
        {
            bool hasSaved = false;
            int attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    dbContext.SaveChanges();
                    hasSaved = true;
                }
                catch (DbUpdateConcurrencyException updateEx)
                {
                    if (attempts > 1)
                        throw;

                    foreach (DbEntityEntry entry in updateEx.Entries)
                    {
                        //TODO use log4net to log
                        //Trace.TraceInformation("Resolving dependency on {0}. {1}{2}", entry.Entity.GetType(),
                        //    Environment.NewLine, updateEx);
                        if (!TryResolveConcurrency(entry))
                        {
                            throw;
                        }
                    }

                    Save(dbContext);
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException valEx)
                {
                    foreach (var validationError in valEx.EntityValidationErrors)
                    {
                        foreach (var error in validationError.ValidationErrors)
                        {
                            string entryValue;
                            try
                            {
                                var prorpertyValue = validationError.Entry.CurrentValues[error.PropertyName];
                                entryValue = prorpertyValue == null ? "null" : prorpertyValue.ToString();
                            }
                            catch
                            {
                                entryValue = "????";
                            }
                            //TODO use log4net to log
                            //Trace.TraceInformation("Db Validation Error on Property [{0}]; Value: [{1}]; Error Message: [{2}]", error.PropertyName, entryValue, error.ErrorMessage);
                        }

                    }
                    throw;
                }
            } while (!hasSaved);
        }

        private bool TryResolveConcurrency(DbEntityEntry entry)
        {
            try
            {
                DbPropertyValues databaseValues = entry.GetDatabaseValues();
                DbPropertyValues currentValues = entry.CurrentValues;

                if (currentValues.GetValue<DateTime>("UpdateDts").Ticks >
                    databaseValues.GetValue<DateTime>("UpdateDts").Ticks)
                {
                    //TODO use log4net to log
                    //Trace.TraceInformation("Resolving dependency on {0}: Keeping current values.",
                    //    entry.Entity.GetType());
                    entry.OriginalValues.SetValues(databaseValues);
                }
                else
                {
                    //TODO use log4net to log
                    //Trace.TraceInformation("Resolving dependency on {0}: Reloading values from database.",
                    //    entry.Entity.GetType());
                    entry.Reload();
                }
            }
            catch (Exception ex)
            {
                //TODO use log4net to log
                //Trace.TraceError("Error resolving concurrency conflict. {0}", ex);

                return false;
            }
            return true;
        }
    }
}
