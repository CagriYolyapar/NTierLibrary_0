using Project.BLL.DesignPatterns.GenericRepository.IntRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.EFBaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext _db;
        DbSet<T> _dbSet;

        public BaseRepository()
        {
            _db = DBTool.DbInstance;
            _dbSet = _db.Set<T>();
        }

        void Save()
        {
            _db.SaveChanges();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _dbSet.Any(exp);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            Save();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _dbSet.FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetModifieds()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Updated);
        }

        public List<T> GetPassives()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted);

        }

        public void MakePassive(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = ENTITIES.Enums.DataStatus.Deleted;
            Save();
        }

        public object Select(Expression<Func<T, dynamic>> exp)
        {
            return _dbSet.Select(exp);
        }

        public List<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _dbSet.Select(exp).ToList();
        }

        public void Update(T entity)
        {
            T originalEntity = GetById(entity.Id);
            entity.ModifiedDate = DateTime.Now;
            entity.Status = ENTITIES.Enums.DataStatus.Updated;

            _db.Entry(originalEntity).CurrentValues.SetValues(entity);
            Save();
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _dbSet.Where(exp).ToList();
        }
    }




}
