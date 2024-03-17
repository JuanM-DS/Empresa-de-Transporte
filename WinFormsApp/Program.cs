using Modelos;
using Repositoy;
using Repositoy.Interfaces;
using Services;
using Services.Interfaces;
using System.Configuration;
namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // "Dependensy"
            var configuration = new Settings();
            IRepositoryModelBase<Conductor> ConRepo = new ConductorsRepository(configuration.SrtSqlServer);
            IServicesModelBase<Conductor> COnServi = new GenericServices<Conductor>(ConRepo);
             
            IRepositoryModelBase<Bus> BusRepo = new BusRepository(configuration.SrtSqlServer);
            IServicesModelBase<Bus> BusServi = new GenericServices<Bus>(BusRepo);

            IRepositoryModelBase<Route> RouteRepo = new RouteRepository(configuration.SrtSqlServer);
            IServicesModelBase<Route> RouteServi = new GenericServices<Route>(RouteRepo);

            IRepositoryBase<TravelRoute> TravelRepo = new RoutOfTravelRepository(configuration.SrtSqlServer);
            IServicesBase<TravelRoute> TravelServi = new RoutOfTravelServices(ConRepo, RouteRepo, BusRepo, TravelRepo);


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(COnServi, BusServi, RouteServi, TravelServi));
        }
    }
}