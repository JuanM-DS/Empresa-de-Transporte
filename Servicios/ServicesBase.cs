using Repositoy.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public abstract class ServicesBase<T>:IServicesBase<T>
    {
        private readonly IRepositoryBase<T> _repo;

        public ServicesBase(IRepositoryBase<T> repo)
        {
            _repo = repo;
        }
        public abstract Task<bool> DeleteAsycn(int id);

        public abstract Task<bool> InsertAsycn(T model);

        public async Task<IEnumerable<T>> GetAllAsycn()
        {
            return await _repo.GetAllAsycn();
        }

        public abstract Task<bool> UpdateAsycn(T model, object oldModel);

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }
    }
}
