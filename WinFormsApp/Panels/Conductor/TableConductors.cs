using Modelos;
using Services.Interfaces;


namespace WinFormsApp.Paneles
{
    public partial class TableConductors : Form
    {
        private readonly Func<Task<IEnumerable<Conductor>>> _servicesGetAll;

        public event EventHandler<int> SelectConductor;

        private Action<int> _loadUpdate;
        public Action<int> _delete;
        private readonly Action subscriptor2;

        public TableConductors(Func<Task<IEnumerable<Conductor>>> servicesGetAll, Action<int> loadUpadate, Action<int> delete, Action subscriptor2)
        {
            InitializeComponent();
            _servicesGetAll = servicesGetAll;
            _loadUpdate = loadUpadate;
            _delete = delete;
            this.subscriptor2 = subscriptor2;
            RefreshTable();
        }

        public async void RefreshTable()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = await _servicesGetAll();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count > 0)
            {
                int idConductor = Convert.ToInt32(this.dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value);
                SelectConductor = (sender, e) =>
                {
                    _loadUpdate(e);
                    subscriptor2();
                };
                SelectConductor?.Invoke(this, idConductor);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count > 0)
            {
                int idConductor = Convert.ToInt32(this.dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value);
                SelectConductor = (sender, e) =>
                {
                    _delete(e);
                    subscriptor2();
                };
                SelectConductor?.Invoke(this, idConductor);
            }
        }
    }
}
