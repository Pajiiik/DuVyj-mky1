using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vyjimky3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                Random rng = new Random();
                int[] pole = new int[0];
                int velikost = 0;
                if (int.TryParse(textBox1.Text, out velikost))
                {
                    velikost = int.Parse(textBox1.Text);
                    pole = new int[velikost];
                }
                else
                {
                    MessageBox.Show("Špatně zadáno");
                }
                for (int i = 0; i < int.Parse(textBox1.Text); i++)
                {
                    pole[i] = rng.Next(1, 21);
                }

                foreach (int cislo in pole)
                {
                    listBox1.Items.Add(cislo);
                }

                int umocneni = int.Parse(Math.Pow(pole[0], pole[5]).ToString());
                MessageBox.Show(umocneni.ToString());
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
