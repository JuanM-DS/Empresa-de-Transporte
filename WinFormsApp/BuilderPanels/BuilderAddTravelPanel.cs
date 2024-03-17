using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Panels.RoutOfTravel;

namespace WinFormsApp.BuilderPanel
{
    public class BuilderAddTravelPanel
    {
        private Func<Task<IEnumerable<Conductor>>>? _getConAvailableAsync;
        private Func<Task<IEnumerable<Route>>>? _getRoutAvailableAsync;
        private Func<Task<IEnumerable<Bus>>>? _getBusAvailableAsync;


        public UpdateTravelOfRoutePanel Build(Func<TravelRoute, Task<bool>> InsertAsync)
        {
            return new UpdateTravelOfRoutePanel(InsertAsync, _getConAvailableAsync, _getRoutAvailableAsync, _getBusAvailableAsync);
        }

        public BuilderAddTravelPanel SetBusesMethods(Func<Task<IEnumerable<Bus>>> getBusAvailableAsync)
        {
            _getBusAvailableAsync = getBusAvailableAsync;
            return this;
        }
        public BuilderAddTravelPanel SetConductorsMethods(Func<Task<IEnumerable<Conductor>>> getConAvailableAsync)
        {
            _getConAvailableAsync = getConAvailableAsync;
            return this;
        }
        public BuilderAddTravelPanel SetRoutesMethods(Func<Task<IEnumerable<Route>>> getRoutAvailableAsync)
        {
            _getRoutAvailableAsync = getRoutAvailableAsync;
            return this;
        }

    }
}
