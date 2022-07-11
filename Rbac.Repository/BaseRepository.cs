using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Rbac.Entity;

namespace Rbac.Repository
{
    public class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey> where TEntity : class where TKey : struct
    {
        protected RbacDbContext db;
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public virtual int Create(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
            return db.SaveChanges();
        }
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual int BulkCreate(List<TEntity> entities)
        {
            foreach (var item in entities)
            {
                db.Set<TEntity>().Add(item);
            }
            return db.SaveChanges();
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual int Update(TEntity entity)
        {
            db.Entry<TEntity>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }
        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual int Delete(TKey key)
        {
            var entity = db.Set<TEntity>().Find(key);
            db.Remove(entity);
            return db.SaveChanges();
        }
        public virtual int Delete(Expression<Func<TEntity, bool>> predicate)
        {
            var entity = db.Set<TEntity>().Where(predicate).ToList();
            db.RemoveRange(entity);
            return db.SaveChanges();
        }
        /// <summary>
        /// 返回单件数据
        /// </summary>
        /// <returns></returns>
        public virtual TEntity GetEntity(TKey key)
        {
            return db.Set<TEntity>().Find(key);
        }

        /// <summary>
        /// 返回单件数据
        /// </summary>
        /// <returns></returns>
        public virtual TEntity GetEntity(Expression<Func<TEntity, bool>> predicate)
        {
            return db.Set<TEntity>().Where(predicate).FirstOrDefault();
        }

        /// <summary>
        /// 获取全部数据
        /// </summary>
        /// <returns></returns>
        public virtual List<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        /// <summary>
        /// 获取全部数据
        /// </summary>
        /// <returns></returns>
        public virtual List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            return db.Set<TEntity>().Where(predicate).ToList();
        }

        /// <summary>
        /// 获取全部数据
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<TEntity> GetQuery(Expression<Func<TEntity, bool>> predicate = null)
        {
            return db.Set<TEntity>().Where(predicate);
        }
    }
}
