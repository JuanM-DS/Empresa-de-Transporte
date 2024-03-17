using Microsoft.IdentityModel.Tokens;
using Modelos;
using System.Net;
using WinFormsApp.FormValidations;

namespace WinFormsApp.Paneles
{
    public partial class AddConductorPanel : Form
    {
        private readonly Func<Conductor, Task<bool>> _insertAsync;
        private event EventHandler InsertNewConductor;

        public AddConductorPanel(Func<Conductor, Task<bool>> InsertAsync, Action subscriptor1, Action subscriptor2)
        {
            InitializeComponent();
            _insertAsync = InsertAsync;
            InsertNewConductor += (sender, e)=>
            {
                subscriptor1();
                subscriptor2();
            };
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var textBoxs = new List<TextBox>() { textFirstName, textLastName, textBirthdate, textDNI };
            var status = FormValidator.ConductorValidator(textBoxs);

            if (!status.status) {
                MessageBox.Show(status.details, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var conductor = new Conductor()
            {
                FirstName = textFirstName.Text,
                LastName = textLastName.Text,
                Birthdate = Convert.ToDateTime(textBirthdate.Text),
                DNI = textDNI.Text
            };
            if(await _insertAsync(conductor))
                SuccessfulRegistration();
        }

        public void SuccessfulRegistration()
        {
            InsertNewConductor?.Invoke(this, EventArgs.Empty);    
        }
    }
}
