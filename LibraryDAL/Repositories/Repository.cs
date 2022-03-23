using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace LibraryDAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly LibraryContext _libraryContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(LibraryContext context)
        {
            _libraryContext = context;
            _dbSet = _libraryContext.Set<TEntity>();
        }

        public TEntity Add(TEntity entity)
        {
            var res = _dbSet.Add(entity);

            _libraryContext.SaveChanges();

            return res;
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);

            if (_libraryContext.Entry(entity).State == EntityState.Detached)
                _dbSet.Attach(entity);
            _dbSet.Remove(entity);

            _libraryContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _libraryContext.Entry(entity).State = EntityState.Modified;

            _libraryContext.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _libraryContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}