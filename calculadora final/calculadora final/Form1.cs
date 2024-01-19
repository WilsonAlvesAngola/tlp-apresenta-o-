using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_final
{
    public partial class Form1 : Form
    {
        public decimal resultando { get; set; }
        public decimal valor { get; set; }
        private Operacao Operacaoselicionada { get; set; }

        private enum Operacao
        {

            Adicao,
            Subtracao,
            Multiplicacao,
            divisao
        }

       
            public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void bzero_Click(object sender, EventArgs e)
        {

            textBox1.Text += "0";
        }

        private void bdois_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btres_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void bquatro_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void bcinco_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void bseis_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void bsete_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void boito_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void bnove_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bsoma_Click(object sender, EventArgs e)
        {
            Operacaoselicionada = Operacao.Adicao;
            valor = Convert.ToDecimal( textBox1.Text);
            textBox1.Text = "";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            Operacaoselicionada = Operacao.Subtracao;
            valor = Convert.ToDecimal( textBox1.Text);
            textBox1.Text = "";
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            Operacaoselicionada = Operacao.Multiplicacao;
            valor = Convert.ToDecimal( textBox1.Text);
            textBox1.Text = "";
        }

        private void bdivisao_Click(object sender, EventArgs e)
        {
            Operacaoselicionada = Operacao.divisao;
            valor = Convert.ToDecimal( textBox1.Text);
            textBox1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (Operacaoselicionada)
            {
                case Operacao.Adicao:
                    resultando = valor +  Convert.ToDecimal(textBox1.Text); ;
                    break;
                case Operacao.Subtracao:
                    resultando = valor - Convert.ToDecimal(textBox1.Text); ;
                    break;
                case Operacao.Multiplicacao:
                    resultando = valor * Convert.ToDecimal(textBox1.Text); ;
                    break;
                case Operacao.divisao:
                    resultando = valor / Convert.ToDecimal(textBox1.Text); ;
                    break;
                
            }
            textBox1.Text  = Convert.ToString(resultando);
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
