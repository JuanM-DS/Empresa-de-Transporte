using Modelos;
using Repositoy.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GenericServices<T> : ServicesBase<T> , IServicesModelBase<T>
    {
        private readonly IRepositoryModelBase<T> _repo;

        public GenericServices(IRepositoryModelBase<T> repo)
            : base(repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<T>> GetAvailableAsync()
        {
            return await _repo.GetAvailableAsync();
        }

        public async Task<bool> ChangeTheStateAsync(int idModelMain, int idModelSecond, int idModelThird, bool Available)
        {
            return await _repo.ChangeTheStateAsync(idModelMain, idModelSecond, idModelThird, Available);
        }
        public override async Task<bool> DeleteAsycn(int id)
        {
            var status = await _repo.DeleteAsycn(id);
            return (status) ? status : false;
        }

        public override async Task<bool> InsertAsycn(T model)
        {
            var status = await _repo.InsertAsycn(model);
            return (status) ? status : false;
        }
        public override async Task<bool> UpdateAsycn(T model, object oldModel)
        {
            var status = await _repo.UpdateAsycn(model);
            return (status) ? status : false;
        }
    }
}
