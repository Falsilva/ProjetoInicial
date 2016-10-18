using System;

namespace ProjetoInicial
{
    internal class Conta
    {
        private int numero;
        private Cliente titular;
        public double saldo = 1000.0;
        private double limite = 200.0;
        public Conta()
        {
        }

        // Declaração de Propriedades (Equivalente aos Getters and Setters do Java)
        /*public int Numero {
            // Leitura
            get 
            {
                return this.numero;
            }
            // Escrita
            set
            {
                this.numero = value;
            }
        }*/

        // Auto-Implemented Properties
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; private set; }
        public double Limite { get; set; }

        public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
                return true; 
            }
            return false;
        }

        public bool VerificaLimite(double valor)
        {
            if (this.Titular.EhMaiorDeIdade() && valor < this.Limite) {
                return true;
            }
            else return false;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            if (this.Saca(valor)) destino.Deposita(valor);
        }
    }
}