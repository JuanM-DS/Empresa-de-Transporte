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
    public partial class UpdateRoute : Form
    {
        private readonly Route _route;
        private readonly Func<Route,Route, Task<bool>> _updateAsync;
        public event EventHandler UpdateCompleted;

        public UpdateRoute(Route route, Func<Route,Route, Task<bool>> updateAsync, Action subscriptor)
        {
            InitializeComponent();
            _route = route;
            _updateAsync = updateAsync;
            UpdateCompleted += (sender, e) => subscriptor();
            LoadDataOfConductor();
        }

        public void LoadDataOfConductor()
        {
            this.textName.Text = _route.Name;
            this.textDescription.Text = _route.Description;
        }

        private async void button1_Click(object sender, EventArgs e)
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
                Id = _route.Id,
                Name = textName.Text,
                Description = textDescription.Text,
            };
            if (await _updateAsync(route,null))
                UpdateCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
