using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0)
                textBox2.Text = "";
            else
            {
                if (textBox1.Focused == false)
                    return;
                uint Decimal = 0;
                try
                {
                    Decimal = checked((uint)Convert.ToUInt32(textBox1.Text));
                }
                catch (OverflowException)
                {

                    textBox2.Text = "Capacidad maxima alcanzada";
                    return;
                }
                textBox2.Text = String.Format("{0:x2}", Decimal);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length <= 0)
                textBox1.Text = "";
            else
            {
                if (textBox2.Focused == false)
                    return;
                uint Hexa = 0;
                try
                {
                    Hexa = Convert.ToUInt16(textBox2.Text, 16);
                }
                catch (OverflowException)
                {

                    textBox1.Text="Capacidad maxima alacanzada";
                    return;
                }
                textBox1.Text = Hexa.ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                int a = 0, b = 0, c = 0, E = 0;
                int[] FackTeam = new int[10];
                string Solu = "";
                a = int.Parse(textBox3.Text);
                while (a >= 1 )
                {
                    b = a / 8;
                    c = a % 8;
                    FackTeam[E] = c;
                    E++;
                    a = b;
                }
                for (int f = E; f >= 0; f--)
                {
                    Solu = Solu +""+ Convert.ToString(FackTeam[f]);
                }
                textBox4.Text = Solu;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                int a, b;
                string c = "";
                a = Convert.ToInt16(textBox3.Text);
                while (a > 0)
                {
                    b = a % 2;
                    a = a / 2;
                    Convert.ToString(b);
                    c = b + c;
                    textBox4.Text = Convert.ToString(c);
                }
                textBox3.Focus();
            }
        }
    }
}
