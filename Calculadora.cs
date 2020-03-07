using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Calculadora
    {
        private List<double> listNumero = new List<double>();

        public void addNumero(double num)
        {
            this.listNumero.Add(num);

        }

        public double somar()
        {
            double resultado = 0;
            foreach (double numero in this.listNumero)
            {
                resultado += numero;
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double subtrair()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado -= numero;
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double multiplicador()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado *= numero;
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double dividir()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado /= numero;
            }
            this.listNumero.Clear();
            return resultado;
        }
    }
}
