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

namespace WinFormsApp.Panels.Buses
{
    public partial class TableBuses : Form
    {
        private readonly Func<Task<IEnumerable<Bus>>> _servicesGetAll;

        public event EventHandler<int> SelectBus;

        private Action<int> _loadUpdate;
        private Action<int> _delete;
        private readonly Action subscriptor2;

        public TableBuses(Func<Task<IEnumerable<Bus>>> servicesGetAll, Action<int> loadUpadate, Action<int> delete, Action subscriptor2)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count > 0)
            {
                int idBus = Convert.ToInt32(this.dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value);
                SelectBus = (sender, e) =>
                {
                    _loadUpdate(e);
                    subscriptor2();
                };
                SelectBus?.Invoke(this, idBus);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedCells.Count > 0)
            {
                int idBus = Convert.ToInt32(this.dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value);
                SelectBus = (sender, e) =>
                {
                    _delete(e);
                    subscriptor2();
                };
                SelectBus?.Invoke(this, idBus);
            }
        }
    }
}

