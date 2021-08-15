using ApiProjectX.Infra.Data.Context;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace ApiProjectX.Infra.Data.Repository
{
    public class UnitOfWork : IDisposable
    {
        private readonly ProjectXContext _dbContext;
        private readonly IDbContextTransaction _dbContextTransaction;

        public UnitOfWork(ProjectXContext dbContext)
        {
            _dbContext = dbContext;
            _dbContextTransaction = _dbContext.Database.BeginTransaction();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            try
            {
                if (disposing)
                {
                    _dbContext.SaveChanges();
                    _dbContextTransaction.Commit();
                }
            }
            catch (Exception)
            {
                _dbContextTransaction.Rollback();
            }
        }
    }
}
