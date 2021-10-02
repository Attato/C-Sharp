using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 1;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string from, to;

            from = listBox1.SelectedItem.ToString();
            to = listBox2.SelectedItem.ToString();

            double rub = 0.0, usd = 0.0, eur = 0.0, currency;

            if(!double.TryParse(textBox1.Text, out currency))
            {
                return;
            }
            
            if (from == to)
            {
                MessageBox.Show("Это одна и та же валюта!");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Введите количество валюты!");
            }

            else
            {
                switch (from)
                {
                    case "RUB":
                        usd = 0.014;
                        eur = 0.012;
                        rub = 1.0;
                        break;
                    case "USD":
                        usd = 1.0;
                        eur = 1.16;
                        rub = 72.67;
                        break;
                    case "EUR":
                        usd = 0.86;
                        eur = 1.0;
                        rub = 84.26;
                        break;
                }

                switch (to)
                {
                    case "RUB":
                        textBox2.Text = Convert.ToString(currency * rub);
                        break;
                    case "USD":
                        textBox2.Text = Convert.ToString(currency * usd);
                        break;
                    case "EUR":
                        textBox2.Text = Convert.ToString(currency * eur);
                        break;
                }
            }
        }

      
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46))
            {
                e.Handled = true;
            }
            
        }
    }
}
