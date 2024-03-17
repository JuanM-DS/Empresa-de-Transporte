using Modelos;
using Services.Interfaces;
using WinFormsApp.BuilderPanel;
using WinFormsApp.Paneles;
using WinFormsApp.Panels;
using WinFormsApp.Panels.Buses;
using WinFormsApp.Panels.RoutOfTravel;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly IServicesModelBase<Conductor> _ConServices;
        private readonly IServicesModelBase<Bus> _busServices;
        private readonly IServicesModelBase<Route> _routeServices;
        private readonly IServicesBase<TravelRoute> _travelServices;
        private AddConductorPanel _addConPanel;
        private TableConductors _tableConPanel;
        private AddBusPanel _addBusPanel;
        private TableBuses _tableBusPanel;
        private AddRoutePanel _addRoutePanel;
        private TableRoutes _tableRoute;
        private UpdateTravelOfRoutePanel _addTravelPanel;
        private TableTravelRoute _tableTravel;

        public Form1(IServicesModelBase<Conductor> Conservices, IServicesModelBase<Bus> BusServices, IServicesModelBase<Route> routeServices, IServicesBase<TravelRoute> travelServices)
        {
            InitializeComponent();
            _ConServices = Conservices;
            _busServices = BusServices;
            _routeServices = routeServices;
            _travelServices = travelServices;
            SetPanels();
        }

        private async void SetPanels()
        {
            //RouteOfTravel using Buiilder patron
            _addTravelPanel = UpdateTravelOfRoutePanel.CreateBuilder()
                .SetConductorsMethods(_ConServices.GetAvailableAsync)
                .SetBusesMethods(_busServices.GetAvailableAsync)
                .SetRoutesMethods(_routeServices.GetAvailableAsync)
                .Build(_travelServices.InsertAsycn);
            _tableTravel = new TableTravelRoute(_travelServices.GetAllAsycn, LoadUpdateTravelForm, DeleTravel, _addTravelPanel.LoadAvailableModels);

            //conductor
            _tableConPanel = new TableConductors(_ConServices.GetAllAsycn, LoadUpdateConForm, DeleConductor, _addTravelPanel.LoadAvailableModels);
            _addConPanel = new AddConductorPanel(_ConServices.InsertAsycn, _tableConPanel.RefreshTable, _addTravelPanel.LoadAvailableModels);
            //Bus
            _tableBusPanel = new TableBuses(_busServices.GetAllAsycn, LoadUpdateBusForm, DeleBus, _addTravelPanel.LoadAvailableModels);
            _addBusPanel = new AddBusPanel(_busServices.InsertAsycn, _tableBusPanel.RefreshTable, _addTravelPanel.LoadAvailableModels);
            //Route
            _tableRoute = new TableRoutes(_routeServices.GetAllAsycn, LoadUpdateRouteForm, DeleRoute, _addTravelPanel.LoadAvailableModels);
            _addRoutePanel = new AddRoutePanel(_routeServices.InsertAsycn, _tableRoute.RefreshTable, _addTravelPanel.LoadAvailableModels);

            _addTravelPanel.InsertNewConductor += (sender, e) =>
            {
                _tableConPanel.RefreshTable();
                _tableBusPanel.RefreshTable();
                _tableRoute.RefreshTable();
                _tableTravel.RefreshTable();
            };
        }
        public async void DeleConductor(int id)
        {
            DialogResult result = MessageBox.Show("¿Seguro de que quieres eliminar el conductor?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (await _ConServices.DeleteAsycn(id))
                    _tableConPanel.RefreshTable();
            }

        }
        public async void DeleTravel(int id)
        {
            DialogResult result = MessageBox.Show("¿Seguro de que quieres eliminar el viaje?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (await _travelServices.DeleteAsycn(id))
                {
                    _tableConPanel.RefreshTable();
                    _tableBusPanel.RefreshTable();
                    _tableRoute.RefreshTable();
                    _tableTravel.RefreshTable();
                    _addTravelPanel.LoadAvailableModels();
                }
            }
        }
        public async void DeleBus(int id)
        {

            DialogResult result = MessageBox.Show("¿Seguro de que quieres eliminar el bus?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (await _busServices.DeleteAsycn(id))
                    _tableBusPanel.RefreshTable();
            }
        }
        public async void DeleRoute(int id)
        {

            DialogResult result = MessageBox.Show("¿Seguro de que quieres eliminar la Ruta?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (await _routeServices.DeleteAsycn(id))
                    _tableRoute.RefreshTable();
            }
        }
        public void LoadSubForm(Panel mainPanel, Form form)
        {
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(form);
            mainPanel.Tag = form;
            form.Show();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            var lista = await _ConServices.GetAllAsycn();
            foreach (var i in lista)
            {
                Console.WriteLine(i);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LoadSubForm(this.formPanel, _addConPanel);
            LoadSubForm(this.tablePanel, _tableConPanel);
        }
        public async void LoadUpdateBusForm(int id)
        {

            var Bus = await _busServices.GetByIdAsync(id);
            var form = new UpdateBusPanel(Bus, _busServices.UpdateAsycn, _tableBusPanel.RefreshTable);
            LoadSubForm(this.formPanel, form);
        }
        public async void LoadUpdateRouteForm(int id)
        {

            var route = await _routeServices.GetByIdAsync(id);
            var form = new UpdateRoute(route, _routeServices.UpdateAsycn, _tableRoute.RefreshTable);
            LoadSubForm(this.formPanel, form);
        }
        public async void LoadUpdateTravelForm(int id)
        {

            var travel = await _travelServices.GetByIdAsync(id);
            var form = UpdateRoutOfTravel.CreateBuilder()
                .SetConductorsMethods(_ConServices.GetAvailableAsync)
                .SetBusesMethods(_busServices.GetAvailableAsync)
                .SetRoutesMethods(_routeServices.GetAvailableAsync)
                .Build(travel, _travelServices.UpdateAsycn, _tableTravel.RefreshTable);

            LoadSubForm(this.formPanel, form);
        }
        public async void LoadUpdateConForm(int id)
        {
            var conductor = await _ConServices.GetByIdAsync(id);
            var form = new UpdateConductorPanel(conductor, _ConServices.UpdateAsycn, _tableConPanel.RefreshTable);
            LoadSubForm(this.formPanel, form);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            LoadSubForm(this.formPanel, _addBusPanel);
            LoadSubForm(this.tablePanel, _tableBusPanel);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            LoadSubForm(this.formPanel, _addRoutePanel);
            LoadSubForm(this.tablePanel, _tableRoute);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadSubForm(this.formPanel, _addTravelPanel);
            LoadSubForm(this.tablePanel, _tableTravel);
        }
    }
}
