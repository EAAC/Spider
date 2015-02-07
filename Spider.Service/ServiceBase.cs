using Spider.Data.Orm;
using Spider.Data.Orm.Configuration;
using Spider.Type;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Spider.Service
{
    public abstract class ServiceBase<TEntity> where TEntity : ModelBase
    {
        public SpiderEntities Db;

        private DbSet<TEntity> _dbSet;
        private OperationResult _success;
        private OperationResult _fail;

        public ServiceBase(SpiderEntities dbContext)
        {
            this.Db = dbContext;
            _dbSet = Db.Set<TEntity>();
            _success = new OperationResult { IsSuccess = true };
            _fail = new OperationResult { IsSuccess = false };
        }

        public TEntity Findd(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id && !x.IsDeleted);
        }

        public virtual List<TEntity> GetAll()
        {
            return _dbSet.OrderBy(x => x.SortingNumber).Where(x => !x.IsDeleted).ToList();
        }

        public virtual List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.OrderBy(x => x.SortingNumber).Where(x => !x.IsDeleted).Where(filter).ToList();
        }

        #region Return Types

        public OperationResult Success(string message)
        {
            _success.Message = message;
            return _success;
        }

        public OperationResult Success(string message, int recordId)
        {
            _success.Message = message;
            _success.RecordId = recordId;
            return _success;
        }

        public OperationResult Success(string message, object record)
        {
            _success.Message = message;
            _success.Record = record;
            return _success;
        }

        public OperationResult Fail(string message)
        {
            _fail.Message = message;
            return _fail;
        }

        public OperationResult Fail(string message, int recordId)
        {
            _fail.Message = message;
            _fail.RecordId = recordId;
            return _fail;
        }

        #endregion

        #region Insert - Update - Delete

        public virtual OperationResult Insert(TEntity entity)
        {
            entity.SortingNumber = entity.SortingNumber == 0 ? 9999999 : entity.SortingNumber;
            entity.AddDate = DateTime.Now;
            entity.IsDeleted = false;

            _dbSet.Add(entity);
            Db.SaveChanges();
            return Success("Insert successful. EZ.", entity.Id);
        }

        public virtual OperationResult Update(TEntity entity)
        {
            entity.LastUpdateDate = DateTime.Now;
            Db.SaveChanges();
            return Success("Update successful. EZ.");
        }

        public virtual OperationResult Delete(int id)
        {
            TEntity entity = _dbSet.Find(id);
            entity.IsDeleted = true;
            entity.DeleteDate = DateTime.Now;
            Db.SaveChanges();
            return Success("Delete successful. EZ.", id);
        }

        #endregion
    }
}
