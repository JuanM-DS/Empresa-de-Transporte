using Modelos;
using WinFormsApp.FormValidations;

namespace WinFormsApp.Paneles
{
    public partial class UpdateConductorPanel : Form
    {
        private readonly Conductor _conductor;
        private readonly Func<Conductor, Conductor, Task<bool>> _updateAsync;
        public event EventHandler UpdateCompleted;

        public UpdateConductorPanel(Conductor conductor, Func<Conductor,Conductor, Task<bool>> updateAsync, Action subscriptor)
        {
            InitializeComponent();
            _conductor = conductor;
            _updateAsync = updateAsync;
            UpdateCompleted += (sender, e) => subscriptor();
            LoadDataOfConductor();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var textBoxs = new List<TextBox>() { textFirstName, textLastName, textBirthdate, textDNI };
            var status = FormValidator.ConductorValidator(textBoxs);

            if (!status.status)
            {
                MessageBox.Show(status.details, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var conductor = new Conductor()
            {
                Id = _conductor.Id,
                FirstName = textFirstName.Text,
                LastName = textLastName.Text,
                Birthdate = Convert.ToDateTime(textBirthdate.Text),
                DNI = textDNI.Text
            };
            if (await _updateAsync(conductor,null))
                UpdateCompleted?.Invoke(this, EventArgs.Empty);

        }

        public void LoadDataOfConductor()
        {
            this.textFirstName.Text = _conductor.FirstName;
            this.textLastName.Text = _conductor.LastName;
            this.textBirthdate.Text = _conductor.Birthdate.ToShortDateString();
            this.textDNI.Text = _conductor.DNI;
        }
    }
}
