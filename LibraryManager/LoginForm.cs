using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            TextBox[] inputFields = { FirstNameField, LastNameField, ThirdName, AddresField, PhoneNumberField };
            if (!IsCorrectFields(inputFields)) return;

            string userData = "";
            foreach (var field in inputFields)
            {
                userData += $"{field.Text} ";
            }

            LoginUser(userData);
        }

        private bool IsCorrectFields(TextBox[] inputFields)
        {
            if (Common.HasNubers(FirstNameField.Text)) return false;
            if (Common.HasNubers(LastNameField.Text)) return false;
            if (Common.HasNubers(ThirdName.Text)) return false;
            if (!Common.IsOnlyDigits(PhoneNumberField.Text)) return false;

            foreach (var field in inputFields)
            {
                if (field.Text == "") return false;
            }

            return true;
        }

        private void LoginUser(string userData)
        {
            if (!Common.HasUser(userData)) return;

            this.Close();

            LibraryForm library = new LibraryForm();
            library.Show();
        }
    }
}
