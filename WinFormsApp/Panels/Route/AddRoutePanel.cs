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

namespace WinFormsApp.Panels
{
    public partial class AddRoutePanel : Form
    {
        private readonly Func<Route, Task<bool>> _insertAsync;
        private event EventHandler InsertNewConductor;

        public AddRoutePanel(Func<Route, Task<bool>> InsertAsync, Action subscriptor1, Action subscriptor2)
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
            var textBoxs = new List<TextBox>() { textName, textDescription };
            var status = FormValidator.RouteValidator(textBoxs);

            if (!status.status)
            {
                MessageBox.Show(status.details, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var route = new Route()
            {
                Name = textName.Text,
                Description = textDescription.Text,
            };
            if (await _insertAsync(route))
                SuccessfulRegistration();
        }
    }
}
