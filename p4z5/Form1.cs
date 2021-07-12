using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p4z5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<Konta> ListaKont = new List<Konta>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("") && !textBox2.Text.Equals("") && !textBox3.Text.Equals(""))
            {
                if (textBox2.Text.Equals(textBox3.Text))
                {


                    if (checkBox1.Checked)
                    {
                        ListaKont.Add(new Konta(textBox1.Text, textBox2.Text));
                        MessageBox.Show("Zarejestrowano pomyślnie.");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        checkBox1.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Zgoda RODO wymagana.");
                    }
                }
                else
                {
                    MessageBox.Show("Hasła muszą być takie same");
                }
            }
            else
            {
                MessageBox.Show("Pola nie mogą być puste.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in ListaKont)
            {
                if (textBox4.Text == item.UserName && textBox5.Text == item.Password)
                {
                    MessageBox.Show("Zalogowano pomyślnie.");
                    break;
                }
                else
                {
                    MessageBox.Show("Nie znaleziono użytkownika");
                    break;
                }
            }
        }
    }
}
