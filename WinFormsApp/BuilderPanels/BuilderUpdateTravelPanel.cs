using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.BuilderPanel;
using WinFormsApp.Panels.RoutOfTravel;

namespace WinFormsApp.BuilderPanels
{
    public class BuilderUpdateTravelPanel
    {
        private Func<Task<IEnumerable<Conductor>>>? _getConAvailableAsync;
        private Func<Task<IEnumerable<Route>>>? _getRoutAvailableAsync;
        private Func<Task<IEnumerable<Bus>>>? _getBusAvailableAsync;


        public UpdateRoutOfTravel Build(TravelRoute Travel, Func<TravelRoute,TravelRoute, Task<bool>> updateAsync, Action subscriptor)
        {
            return new UpdateRoutOfTravel(Travel, updateAsync, subscriptor, _getConAvailableAsync, _getRoutAvailableAsync, _getBusAvailableAsync);
        }

        public BuilderUpdateTravelPanel SetBusesMethods(Func<Task<IEnumerable<Bus>>> getBusAvailableAsync)
        {
            _getBusAvailableAsync = getBusAvailableAsync;
            return this;
        }
        public BuilderUpdateTravelPanel SetConductorsMethods(Func<Task<IEnumerable<Conductor>>> getConAvailableAsync)
        {
            _getConAvailableAsync = getConAvailableAsync;
            return this;
        }
        public BuilderUpdateTravelPanel SetRoutesMethods(Func<Task<IEnumerable<Route>>> getRoutAvailableAsync)
        {
            _getRoutAvailableAsync = getRoutAvailableAsync;
            return this;
        }

    }
}
