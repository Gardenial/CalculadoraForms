using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraForms
{
    class ModelCalculadora
    {

        private double operacao;
        public ModelCalculadora()
        {

            ConsultarOperacao = 0;

        }//Fim do construtor

        public double ConsultarOperacao
        {
            get { return operacao; }
            set { this.operacao = value; }
        }//fim do GetSet Consultar Operacao

        public double Somar(double num)
        {
            return ConsultarOperacao += num;
        }//fim do Método Somar

        public double Subtrair(double num)
        {
            return ConsultarOperacao -= num;
        }//fim do Método Subtrair

        public double Multiplicar(double num)
        {
            return ConsultarOperacao *= num;
        }//fim do Método Multiplicar

        public double Divisao(double num)
        {
            return ConsultarOperacao /= num;
        }//fim do Método Multiplicar


    }//Fim da classe
}//Fim do Projeto
