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
    public partial class AddBusPanel : Form
    {
        private readonly Func<Bus, Task<bool>> _insertAsync;
        private event EventHandler InsertNewConductor;

        public AddBusPanel(Func<Bus, Task<bool>> InsertAsync, Action subscriptor1, Action subscriptor2)
        {
            InitializeComponent();
            _insertAsync = InsertAsync;
            InsertNewConductor += (sender, e) =>
            {
                subscriptor1();
                subscriptor2();
            };
        }

        public void SuccessfulRegistration()
        {
            InsertNewConductor?.Invoke(this, EventArgs.Empty);
        }

        private async void button2_Click_1(object sender, EventArgs e)
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
                Brand = textBrand.Text,
                Model = textModel.Text,
                Plate = textPlate.Text,
                Color = textColor.Text,
                Year = Convert.ToDateTime(textYear.Text),
            };
            if (await _insertAsync(Bus))
                SuccessfulRegistration();
        }
    }
}
