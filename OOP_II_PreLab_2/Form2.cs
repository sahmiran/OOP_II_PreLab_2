using OOP_II_PreLab_2.Properties;
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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();



        }

        
        private void backBtn_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            
        }
    }
}
