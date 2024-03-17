using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositoy.Interfaces
{
    public interface IRepositoryBase<T>
    {
        public Task<bool> InsertAsycn(T model);
        public Task<bool> UpdateAsycn(T model);
        public Task<bool> DeleteAsycn(int id);
        public Task<IEnumerable<T>> GetAllAsycn();
        public Task<T> GetByIdAsync(int id);

    }
}
