using Modelos;
using WinFormsApp.BuilderPanel;
using WinFormsApp.FormValidations;

namespace WinFormsApp.Panels.RoutOfTravel
{
    public partial class UpdateTravelOfRoutePanel : Form
    {
        private readonly Func<TravelRoute, Task<bool>> _insertAsync;
        private readonly Func<Task<IEnumerable<Conductor>>> _getConAvailableAsync;
        private readonly Func<Task<IEnumerable<Route>>> _getRoutAvailableAsync;
        private readonly Func<Task<IEnumerable<Bus>>> getBusAvailableAsync;
        private List<ComboBox> _comboBoxs;
        private IEnumerable<Conductor> _conductors;
        private IEnumerable<Route> _routes;
        private IEnumerable<Bus> _buses;

        public event EventHandler InsertNewConductor;

        public UpdateTravelOfRoutePanel(Func<TravelRoute, Task<bool>> InsertAsync, Func<Task<IEnumerable<Conductor>>> getConAvailableAsync, Func<Task<IEnumerable<Route>>> getRoutAvailableAsync, Func<Task<IEnumerable<Bus>>> getBusAvailableAsync)
        {
            InitializeComponent();
            _insertAsync = InsertAsync;
            _getConAvailableAsync = getConAvailableAsync;
            _getRoutAvailableAsync = getRoutAvailableAsync;
            this.getBusAvailableAsync = getBusAvailableAsync;
            _comboBoxs = new List<ComboBox>() { boxConductor, boxRoute, boxBus };
            LoadAvailableModels();
        }
        public static BuilderAddTravelPanel CreateBuilder()
        {
            return new BuilderAddTravelPanel();
        }

        public void SuccessfulRegistration()
        {
            InsertNewConductor?.Invoke(this, EventArgs.Empty);
            LoadAvailableModels();
        }

        public async void LoadAvailableModels()
        {
            foreach (var i in _comboBoxs)
            {
                i.Text = "";
            }

            await LoadModels();
            _comboBoxs[0].DataSource = _conductors.Select(x => x.FirstName).ToList();
            _comboBoxs[1].DataSource = _routes.Select(x => x.Name).ToList();
            _comboBoxs[2].DataSource = _buses.Select(x => x.Plate).ToList();

        }
        public async Task LoadModels()
        {
            _conductors = await _getConAvailableAsync();
            _routes = await _getRoutAvailableAsync();
            _buses = await getBusAvailableAsync();
        }
        public async Task<TravelRoute> IndexOfModels()
        {
            await LoadModels();
            var nameOfConductor = _comboBoxs[0].Text;
            var nameOfRoute = _comboBoxs[1].Text;
            var plateOfBus = _comboBoxs[2].Text;

            var travel = new TravelRoute()
            {
                IdConductor = _conductors.Where(x => x.FirstName == nameOfConductor).FirstOrDefault().Id,
                IdRoute = _routes.Where(x => x.Name == nameOfRoute).FirstOrDefault().Id,
                IdBus = _buses.Where(x => x.Plate == plateOfBus).FirstOrDefault().Id
            };
            return travel;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var status = FormValidator.TravelValidator(_comboBoxs);

            if (!status.status)
            {
                MessageBox.Show(status.details, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var travel = await IndexOfModels();
            if (await _insertAsync(travel))
                SuccessfulRegistration();
        }
    }
}
