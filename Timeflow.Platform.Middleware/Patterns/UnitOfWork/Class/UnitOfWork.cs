using Microsoft.EntityFrameworkCore;
using Timeflow.Platform.Middleware.Patterns.UnitOfWork.Interface;

namespace Timeflow.Platform.Middleware.Patterns.UnitOfWork.Class
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T: class
    {
        private readonly T repository;
        private readonly DbContext _dbContext;
        public UnitOfWork(DbContext dataContext, T _repository) 
        {
            this.repository = _repository;
            this._dbContext= dataContext;
        }

        public T Instance => this.repository;

        public async Task SaveAsync() 
        {
            await this._dbContext.SaveChangesAsync();
        }
    }
}
