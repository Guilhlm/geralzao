using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_de_tudo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double numero = double.Parse(textBox1.Text);
            bool temdescricao = checkBox1.Checked;
            string descricao = " ", menssagem = " ";
            bool comalerta = checkBox2.Checked;

            if (radioButton1.Checked)
            {
                double fahrenheit = 0;

                fahrenheit = (numero * 1.8) + 32;

                if (temdescricao)
                {
                    descricao = "farenheit";
                }
               
                menssagem = fahrenheit.ToString() + descricao;

                if (comalerta)
                {
                    MessageBox.Show(menssagem + "ferenheit");
                }
                else
                {
                    label1.Text = menssagem;
                }
            }


            if (radioButton2.Checked)
            {
                double kelvin = 0;

                kelvin = (numero + 273);

                if (temdescricao)
                {
                    descricao = "kelvin";
                }

                menssagem = kelvin.ToString() + descricao;

                if (comalerta)
                {
                    MessageBox.Show(menssagem + "kelvin");
                }
                else
                {
                    label1.Text = menssagem;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string continente = "";

            continente = comboBox1.SelectedItem.ToString();

            MessageBox.Show(continente);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (string elementos in checkedListBox1.CheckedItems)
            {
                MessageBox.Show(elementos);

                contador++;
            }


            MessageBox.Show("foram selecionados " + contador.ToString() + "checkbox");

        }
    }
}
