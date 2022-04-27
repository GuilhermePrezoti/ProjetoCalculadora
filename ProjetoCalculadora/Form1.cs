using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        ModelCalculadora model;
        public Form1()
        {
            InitializeComponent();
            model = new ModelCalculadora();
        }

        private void soma_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado = model.Somar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                label3.Text = "" + resultado;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Os números não foram digitados\n\n\n" + erro);
            }

        }//Fim do botão soma

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim da caixa de texto para o primeiro número

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim da caixa de texto para o segundo número

        private void Subtracao_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado = model.Subtrair(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                label3.Text = "" + resultado;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Os números não foram Digitidos\n\n\n" + erro);
            }

        }//fim do botão subtração

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado = model.Multiplicar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                label3.Text = "" + resultado;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Os números não foram Digitidos\n\n\n" + erro);
            }
        }//fim do botão Multiplicar

        private void divisao_Click(object sender, EventArgs e)
        {
            try
            {


                double resultado = model.Dividir(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                label3.Text = "" + resultado;
                if (resultado == -1)
                {
                    label3.Text = "Impossivel dividir por zero";
                }
                else
                {
                    label3.Text = "" + resultado;
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Os números não foram Digitidos\n\n\n" + erro);
            }
        }//Fim do botão Dividir

        private void Potencia_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado = model.Potencia(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
                label3.Text = "" + resultado;
            }
            catch(Exception erro)
            {
                MessageBox.Show("Os números não foram Digitidos\n\n\n" + erro);
            }
        }//fim do botão potência

        private void Raiz_Click(object sender, EventArgs e)
        {
            try
            {


                double resultado = model.Raiz(Convert.ToDouble(textBox1.Text));
                label3.Text = "" + resultado;
                if (resultado == -1)
                {
                    label3.Text = "" + resultado;
                }
                else
                {
                    label3.Text = "Impossivel calcular a raiz";
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show("Os números não foram Digitidos\n\n\n" + erro);
            }
        }//Fim do botão Raiz

        private void label1_Click_1(object sender, EventArgs e)
        {

        }//Fim do primeiro numero 

        private void label3_Click(object sender, EventArgs e)
        {

        }//Fim do resultado
    }//Fim da classe
}//Fim do projeto
