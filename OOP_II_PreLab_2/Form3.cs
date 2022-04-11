using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_II_PreLab_2.Properties;

namespace OOP_II_PreLab_2
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            difficultyLabel.Text = Settings.Default["Difficulty"].ToString();
            shapeLabel.Text = Settings.Default["Shape"].ToString();
            colorLabel.Text = Settings.Default["Color"].ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //easy button
        {

            difficultyLabel.Text= button1.Text; ;


            Settings.Default["Difficulty"] = button1.Text.ToString();
            Settings.Default.Save();
            
        }

        private void button2_Click(object sender, EventArgs e) //normal button
        {
            difficultyLabel.Text = button2.Text; 
            


            Settings.Default["Difficulty"] = button2.Text.ToString();
            Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e) //hard button
        {
            difficultyLabel.Text = button3.Text; ;


            Settings.Default["Difficulty"] = button3.Text.ToString();
            Settings.Default.Save();
        }

        private void button4_Click(object sender, EventArgs e) //custom button
        {
            difficultyLabel.Text = button4.Text; ;


            Settings.Default["Difficulty"] = button4.Text.ToString();
            Settings.Default.Save();
        }

        private void saveShapeBtn_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (squareCheckBox.Checked == true)
            {
                temp = temp + squareCheckBox.Text.ToString() + " ";
            }

            if (triangleCheckBox.Checked == true)
            {
                temp = temp + triangleCheckBox.Text.ToString() + " ";
            }

            if (roundCheckBox.Checked == true)
            {
                temp = temp + roundCheckBox.Text.ToString() + " ";
            }

            Settings.Default["Shape"] = temp;
            Settings.Default.Save();
            shapeLabel.Text = temp;
        }

        private void saveColorBtn_Click(object sender, EventArgs e)
        {
            string colortemp = "";
            if (greenCheckBox.Checked == true)
            {
                colortemp = colortemp + greenCheckBox.Text.ToString() + " ";
            }

            if (blueCheckBox.Checked == true)
            {
                colortemp = colortemp + blueCheckBox.Text.ToString() + " ";
            }

            if (yellowCheckBox.Checked == true)
            {
                colortemp = colortemp + yellowCheckBox.Text.ToString() + " ";
            }

            Settings.Default["Color"] = colortemp;
            Settings.Default.Save();
            colorLabel.Text = colortemp;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
