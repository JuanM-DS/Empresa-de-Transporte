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
using WinFormsApp.FormValidations;

namespace WinFormsApp.Panels.Buses
{
    public partial class UpdateBusPanel : Form
    {
        private readonly Bus _Bus;
        private readonly Func<Bus,Bus, Task<bool>> _updateAsync;
        public event EventHandler UpdateCompleted;

        public UpdateBusPanel(Bus bus, Func<Bus,Bus, Task<bool>> updateAsync, Action subscriptor)
        {
            InitializeComponent();
            _Bus = bus;
            _updateAsync = updateAsync;
            UpdateCompleted += (sender, e) => subscriptor();
            LoadDataOfConductor();
        }

        public void LoadDataOfConductor()
        {
            this.textBrand.Text = _Bus.Brand;
            this.textModel.Text = _Bus.Model;
            this.textPlate.Text = _Bus.Plate;
            this.textColor.Text = _Bus.Color;
            this.textYear.Text = _Bus.Year.ToShortDateString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var textBoxs = new List<TextBox>() { textBrand, textModel, textPlate, textColor, textYear };
            var status = FormValidator.BusValidator(textBoxs);

            if (!status.status)
            {
                MessageBox.Show(status.details, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var Bus = new Bus()
            {
                Id = _Bus.Id,
                Brand = textBrand.Text,
                Model = textModel.Text,
                Plate = textPlate.Text,
                Color = textColor.Text,
                Year =  Convert.ToDateTime(textYear.Text),
            };
            if (await _updateAsync(Bus,null))
                UpdateCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
