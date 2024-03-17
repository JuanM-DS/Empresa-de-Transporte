using FluentValidation;
using Microsoft.IdentityModel.Tokens;

namespace WinFormsApp.FormValidations
{
    public static class FormValidator
    {
        public static Return ConductorValidator(List<TextBox> textBoxs)
        {
            var nullBox = textBoxs.Where(x => x.Text.IsNullOrEmpty()).ToList();
            var r = new Return() { status = true};

            if (nullBox.Count > 0)
            {
                r.status = false;
                foreach(var i in nullBox)
                {
                    r.details += $"{i.Name} is null\n";
                }
            }

            var boxDate = textBoxs.Where(x=>x.Name == "textBirthdate").First();
            try
            {
                if (!boxDate.Text.IsNullOrEmpty())
                    Convert.ToDateTime(boxDate.Text);

            }
            catch
            {
                r.status = false;

                r.details += $"{boxDate.Name} is not in the correct format\n";
            }

            return r;
        }
        public static Return BusValidator(List<TextBox> textBoxs)
        {
            var nullBox = textBoxs.Where(x => x.Text.IsNullOrEmpty()).ToList();
            var r = new Return() { status = true };

            if (nullBox.Count > 0)
            {
                r.status = false;
                foreach (var i in nullBox)
                {
                    r.details += $"{i.Name} is null\n";
                }
            }

            var boxYear = textBoxs.Where(x => x.Name == "textYear").First();
            try
            {
                if (!boxYear.Text.IsNullOrEmpty())
                    Convert.ToDateTime(boxYear.Text);

            }
            catch
            {
                r.status = false;

                r.details += $"{boxYear.Name} is not in the correct format\n";
            }

            return r;
        }
        public static Return RouteValidator(List<TextBox> textBoxs)
        {
            var nullBox = textBoxs.Where(x => x.Text.IsNullOrEmpty()).ToList();
            var r = new Return() { status = true };

            if (nullBox.Count > 0)
            {
                r.status = false;
                foreach (var i in nullBox)
                {
                    r.details += $"{i.Name} is null\n";
                }
            }
            return r;
        }
        public static Return TravelValidator(List<ComboBox> comboBox)
        {
            var nullBox = comboBox.Where(x => Convert.ToString(x.SelectedItem).IsNullOrEmpty()).ToList();
            var r = new Return() { status = true };

            if (nullBox.Count > 0)
            {
                r.status = false;
                foreach (var i in nullBox)
                {
                    r.details += $"{i.Name} is null\n";
                }
            }
            return r;
        }
    }
}
