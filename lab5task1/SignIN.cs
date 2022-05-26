using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5task1
{
    public partial class SignIN : Form
    {
        public SignIN()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignUP su = new SignUP();
            su.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                if (lab5.menu.Login(textBox1.Text, textBox2.Text))
                {
                    Menu m = new Menu(textBox1.Text);
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password or account do not exist");
                }
            }
            else
                MessageBox.Show("Kindly fill all required fields");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime iDate;
            iDate = dateTimePicker1.Value;
            MessageBox.Show("Selected date is " + iDate);
        }
            }
}
