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
    public partial class Menu : Form
    {
        public Menu(string username)
        {
            InitializeComponent();
            label1.Text = username;
        }

        static int items=0;
        string[,] ord_item = new string[5, 3];
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            int price = 0;
            if (checkBox1.Checked)
            {
                ord_item[items, 0] = "Cappuccino";
                price = (int.Parse(textBox1.Text)) * 5;
                ord_item[items, 1] = price.ToString();
                ord_item[items++, 2] = textBox1.Text ;
            }
            if (checkBox2.Checked)
            {
                ord_item[items, 0] = "Flat White";
                price = (int.Parse(textBox2.Text)) * 4;
                ord_item[items, 1] = price.ToString();
                ord_item[items++, 2] = textBox2.Text;
            }
            if (checkBox3.Checked)
            {
                ord_item[items, 0] = "Long Black";
                price = (int.Parse(textBox3.Text)) * 5;
                ord_item[items, 1] = price.ToString();
                ord_item[items++, 2] = textBox3.Text;
            }
            if (checkBox4.Checked)
            {
                ord_item[items, 0] = "Mochaccino";
                price = (int.Parse(textBox4.Text)) * 6;
                ord_item[items, 1] = price.ToString();
                ord_item[items++, 2] = textBox4.Text;
            }
            if (checkBox5.Checked)
            {
                ord_item[items, 0] = "Vienna";
                price = (int.Parse(textBox5.Text)) * 6;
                ord_item[items, 1] = price.ToString();
                ord_item[items++, 2] = textBox5.Text;
            }
            b.showBill(ord_item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIN si = new SignIN();
            si.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Creating and setting the
            // properties of the Label
            Label l = new Label();
            l.Location = new Point(183, 162);
            l.Size = new Size(172, 20);
            l.Text = "Select Date and Time";
            l.Font = new Font("Comic Sans MS", 12);

            // Adding this control
            // to the form
            this.Controls.Add(l);

            // Creating and setting the
            // properties of the DateTimePicker
            DateTimePicker d = new DateTimePicker();
            d.Location = new Point(360, 162);
            d.Size = new Size(292, 26);
            d.MaxDate = new DateTime(2500, 12, 20);
            d.MinDate = new DateTime(1753, 1, 1);
            d.Format = DateTimePickerFormat.Long;
            d.Name = "MyPicker";
            d.Font = new Font("Comic Sans MS", 12);
            d.Visible = true;
            d.Value = DateTime.Today;

            // Adding this control
            // to the form
            this.Controls.Add(d);
        }
    }
}
