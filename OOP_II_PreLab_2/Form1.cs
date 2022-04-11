using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_II_PreLab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = loginUsernameTxt;
            
        }

        private async void registerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTxt.Text))
            {
                MessageBox.Show("You need to fill all boxes", "MEssage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTxt.Focus();
                return;
            }

            else if (string.IsNullOrEmpty(passwordTxt.Text))
            {
                MessageBox.Show("You need to fill all boxes", "MEssage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTxt.Focus();
                return;
            }

            else if (string.IsNullOrEmpty(fullnameTxt.Text))
            {
                MessageBox.Show("You need to fill all boxes", "MEssage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTxt.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(phoneNumberTxt.Text))
            {
                MessageBox.Show("You need to fill all boxes", "MEssage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTxt.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(addressTxt.Text))
            {
                MessageBox.Show("You need to fill all boxes", "MEssage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTxt.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(cityTxt.Text))
            {
                MessageBox.Show("You need to fill all boxes", "MEssage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTxt.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(countryTxt.Text))
            {
                MessageBox.Show("You need to fill all boxes", "MEssage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTxt.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(emailTxt.Text))
            {
                MessageBox.Show("You need to fill all boxes", "MEssage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTxt.Focus();
                return;
            }

            IUserRepository repository = new UserRepository();
            bool result = await repository.Insert(new User() { Username = usernameTxt.Text, Password = passwordTxt.Text, FullName = fullnameTxt.Text, PhoneNumber = phoneNumberTxt.Text, Address = addressTxt.Text, City = cityTxt.Text, Country = countryTxt.Text, Email = emailTxt.Text });
            if (result)
                MessageBox.Show("You have successfully signed up ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
