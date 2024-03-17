using Modelos;
using Repositoy.Interfaces;
using Services.Interfaces;
using System.Diagnostics;
using System.Transactions;

namespace Services
{
    public class RoutOfTravelServices : ServicesBase<TravelRoute>, IServicesBase<TravelRoute>
    {
        private readonly IRepositoryModelBase<Conductor> _conductorRepo;
        private readonly IRepositoryModelBase<Route> _routRepo;
        private readonly IRepositoryModelBase<Bus> _busRepo;
        private readonly IRepositoryBase<TravelRoute> _travelRepo;

        public RoutOfTravelServices(IRepositoryModelBase<Conductor> ConductorRepo, IRepositoryModelBase<Route> RoutRepo, IRepositoryModelBase<Bus> BusRepo, IRepositoryBase<TravelRoute> TravelRepo)
            : base(TravelRepo)
        {
            _conductorRepo = ConductorRepo;
            _routRepo = RoutRepo;
            _busRepo = BusRepo;
            _travelRepo = TravelRepo;
        }
        public override async Task<bool> InsertAsycn(TravelRoute model)
        {
            bool status = false;
            using (var trans = new TransactionScope())
            {
                status = await _conductorRepo.ChangeTheStateAsync(model.IdConductor, model.IdBus, model.IdRoute, true);
                status = await _routRepo.ChangeTheStateAsync(model.IdRoute, model.IdConductor, model.IdBus, true);
                status = await _busRepo.ChangeTheStateAsync(model.IdBus, model.IdConductor, model.IdRoute, true);
                status = await _travelRepo.InsertAsycn(model);
                if (status)
                    trans.Complete();
            }
            return status;
        }
        public override async Task<bool> DeleteAsycn(int id)
        {
            bool status = false;
            var travel = await _travelRepo.GetByIdAsync(id);
            if (travel is not null)
            {
                status = await _conductorRepo.ChangeTheStateAsync(travel.IdConductor, null, null, false);
                status = await _routRepo.ChangeTheStateAsync(travel.IdRoute, null, null, false);
                status = await _busRepo.ChangeTheStateAsync(travel.IdBus, null, null, false);
                status = await _travelRepo.DeleteAsycn(travel.Id);
            }
            return status;

        }

        public override async Task<bool> UpdateAsycn(TravelRoute model, object oldModel)
        {
            bool status = false;
            using (var trans = new TransactionScope())
            {
                status = await _conductorRepo.ChangeTheStateAsync(model.IdConductor, model.IdBus, model.IdRoute, true);
                status = await _routRepo.ChangeTheStateAsync(model.IdRoute, model.IdConductor, model.IdBus, true);
                status = await _busRepo.ChangeTheStateAsync(model.IdBus, model.IdConductor, model.IdRoute, true);
                status = await _travelRepo.InsertAsycn(model);
                if (status)
                    trans.Complete();
            }
            return status;
        }
    }
}
