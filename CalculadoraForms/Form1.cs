using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public partial class Calculadora : Form
    {
        ModelCalculadora ModeloCalculadora;
        public Boolean flag;
        public double exp;
        public double bas;

        public Calculadora()
        {
            InitializeComponent();
            this.ModeloCalculadora = new ModelCalculadora();
            flag = false;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }// tela

        private void label1_Click(object sender, EventArgs e)
        {

        }//Fim do "Insira um valor"

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim da caixa de texto

        private void soma_Click(object sender, EventArgs e)
        {

            textBoxResultado.Text = "" + this.ModeloCalculadora.Somar(Convert.ToDouble(maskedTextBox1.Text));
            maskedTextBox1.Text = "";
            

        }//Fim da soma botão

        private void subtracao_Click(object sender, EventArgs e)
        {

            textBoxResultado.Text = "" + this.ModeloCalculadora.Subtrair(Convert.ToDouble(maskedTextBox1.Text));
            maskedTextBox1.Text = "";


        }//Fim da subtração botão

        private void multiplicacao_Click(object sender, EventArgs e)
        {

            if (Chave(flag) == true)
            {
                bas = Convert.ToDouble(maskedTextBox1.Text);

            }
            else
            {
                exp = Convert.ToDouble(maskedTextBox1.Text);

            }//Fim do If...Else

            textBoxResultado.Text = "" + this.ModeloCalculadora.Multiplicar(bas, exp);
            flag = Chave(flag);
        }//Fim da multiplicação botão

        private void divisao_Click(object sender, EventArgs e)
        {

            if (Chave(flag) == true)
            {
                bas = Convert.ToDouble(maskedTextBox1.Text);

            }
            else
            {
                exp = Convert.ToDouble(maskedTextBox1.Text);

            }//Fim do If...Else

            textBoxResultado.Text = "" + this.ModeloCalculadora.Divisao(bas, exp);
            flag = Chave(flag);

        }//Fim da divisão botão



        private void Potencia_Click(object sender, EventArgs e)
        {
            if(Chave(flag) == true)
            {
                exp = Convert.ToDouble(maskedTextBox1.Text);
                
            }
            else
            {
                bas = Convert.ToDouble(maskedTextBox1.Text);
               
            }//Fim do If...Else

            textBoxResultado.Text = "" + this.ModeloCalculadora.Potencia(exp, bas);
            flag = Chave(flag);
        }//Fim da Potencia Botão

        private void Raiz_Click(object sender, EventArgs e)
        {

            textBoxResultado.Text = "" + this.ModeloCalculadora.Raiz(Convert.ToDouble(maskedTextBox1.Text));
            maskedTextBox1.Text = "";

        }//Fim da Raiz botão


        private void labelResultado_Click(object sender, EventArgs e)
        {

        }//Fim da label Resultado

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {
            

        }//fim da caixa de texto resultado


        //--------------------------------CHAVE------------------------------------------
        public Boolean Chave(Boolean entrada)
        {
            if (entrada == true)
            {
                return false;
            }
            else
            {
                return true;
            }//Fim do if
        }//fim do método
         //--------------------------------CHAVE------------------------------------------


    }//Fim da classe
}//Fim do projeto
