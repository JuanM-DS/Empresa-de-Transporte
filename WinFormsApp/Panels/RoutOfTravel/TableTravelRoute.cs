using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Panels.RoutOfTravel
{
    public partial class TableTravelRoute : Form
    {
        private readonly Func<Task<IEnumerable<TravelRoute>>> _servicesGetAll;

        public event Action<int> SelectRoute; // Cambiado a Action<int>

        private Action<int> _loadUpdate;
        private Action<int> _delete;
        private readonly Action subscriptor2;

        public TableTravelRoute(Func<Task<IEnumerable<TravelRoute>>> servicesGetAll, Action<int> loadUpadate, Action<int> delete, Action subscriptor2)
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
            var lola = await _servicesGetAll();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = await _servicesGetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count > 0)
            {
                int idRoute = Convert.ToInt32(this.dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value);
                SelectRoute = (e) => { _loadUpdate(e); subscriptor2(); };
                SelectRoute?.Invoke(idRoute); // Cambiado para pasar idRoute en lugar de this y idRoute
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count > 0)
            {
                int idRoute = Convert.ToInt32(this.dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value);
                SelectRoute = (e) =>
                {
                    _delete(e);
                    subscriptor2();
                };
                SelectRoute?.Invoke(idRoute); // Cambiado para pasar idRoute en lugar de this y idRoute
            }
        }
    }

}
