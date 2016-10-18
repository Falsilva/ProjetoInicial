using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInicial
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeMaria = 25;
            int idadePedro = 47;
            float media = (idadeJoao + idadeMaria + idadePedro)/3f;

            MessageBox.Show("Idades: \n"
                + "João.: " + idadeJoao + "\n"
                + "Maria: " + idadeMaria + "\n"
                + "Pedro: " + idadePedro + "\n"
                + "\n"
                + "Média = " + media);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // int pi = 3.14; NÃO COMPILA, pois o número não cabe dentro de um inteiro

            double pi = 3.14;
            int piQuebrado = (int) pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double delta, a1, a2;

            a = 1;
            b = -2;
            c = -3;

            delta = b * b - 4 * a * c;
            
            if(delta >= 0)
            {
                a1 = (-b + Math.Sqrt(delta)) / (2 * a);
                a2 = (-b - (Math.Sqrt(delta))) / (2 * a);
                MessageBox.Show("a1 = " + a1 + "\na2 = " + a2);
            }            
            else
                MessageBox.Show("A equação não possui raízes reais.");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            double saldo = 5.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso. Saldo R$ " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente. Saldo R$ " + saldo);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double saldo = 500.0;
            if (saldo < 0.0)
            {
                MessageBox.Show("Você está no negativo!");
            }
            else if (saldo < 1000000.0)
            {
                MessageBox.Show("Você é um bom cliente");
            }
            else
            {
                MessageBox.Show("Você é milionário!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double taxa, saldo;

            saldo = 100.00;

            if (saldo < 1000)
            {
                taxa = 0.01;
            }
            else if (saldo <= 5000)
            {
                taxa = 0.05;
            }
            else
            {
                taxa = 0.1;
            }

            MessageBox.Show("Taxa: " + taxa*100 + "%");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileira = true;
            if (brasileira && idade >= 16)
                MessageBox.Show("Apta a votar" +
                    "\nidade: " + idade +
                    "\nbrasileiro");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 1543.00;
            double alíquota = 0.00;
            double imposto;

            if (valorDaNotaFiscal <= 999)
                alíquota = 2 / 100;
            else if (valorDaNotaFiscal >= 1000 && valorDaNotaFiscal <= 2999)
                alíquota = 2.5 / 100;
            else if (valorDaNotaFiscal >= 3000 && valorDaNotaFiscal <= 6999)
                alíquota = 2.8 / 100;
            else if (valorDaNotaFiscal >= 7000)
                alíquota = 3 / 100;

            imposto = valorDaNotaFiscal * alíquota;

            MessageBox.Show("Nota Fiscal\n" +
                "Valor: R$ " + valorDaNotaFiscal + "\n" +
                "Alíquota: " + alíquota*100 + "%\n" +
                "Imposto: R$ " + imposto);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;
            for (int i = 1; i <= 12; i += 1)
            {
                valorInvestido = valorInvestido * 1.01;
            }
            MessageBox.Show("Valor investido agora é " + valorInvestido);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 1000; i++)
                soma += i;
            MessageBox.Show("Total: " + soma);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string multiplos = "";
            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    multiplos += " " + i;
            }
            MessageBox.Show("Múltiplos de 3:\n" + multiplos);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                    soma += i;
            }
            MessageBox.Show("Total: " + soma);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string divisiveis = "";
            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                    divisiveis += " " + i;
            }
            MessageBox.Show("Divisíveis de 3 ou 4: " + divisiveis);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int n = 10;
            int resultado = 1;
            string fatoriais = "";
            for(int i = 1; i <= n; i++)
            {
                resultado *= i;
                fatoriais += " " + resultado;
            }
            MessageBox.Show(10 + "!:  " + fatoriais + " = " + resultado);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double n1 = 0, n2 = 1, soma = 0;
            string fibonacci = n1 + " " + n2;
            for(double i = 2; i < 100; i++)
            {
                soma = n1 + n2;
                n1 = n2;
                n2 = soma;
                fibonacci += " " + soma;
            }
            MessageBox.Show(fibonacci);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ulong num = 10;
            string fibonacci = "";
            for (ulong i = 0; i < num; i++) fibonacci += " " + Fibonaci(i).ToString();
            MessageBox.Show(fibonacci);
        }

        private static ulong Fibonaci(ulong num)
        {
            if (num <= 1)
            {
                if (num == 0) return 0;
                else return 1;
            }
            return Fibonaci(num - 1) + Fibonaci(num - 2);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int num = 4;
            string sequencia = "";
            for(int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    sequencia += " " + i * j;                    
                }
                MessageBox.Show(sequencia);
                sequencia += "\n";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            Cliente cliente = new Cliente();            
            c.Titular = cliente;
            c.Titular.Nome = "Victor";
            MessageBox.Show(c.Titular.Nome);
            c.Numero = 1;
            c.saldo = 1000;
            
            if (c.Saca(500.0))
            {
                if (c.VerificaLimite(500.0))
                    MessageBox.Show("Saque realizado com sucesso." + "\n" + "Saldo: " + c.saldo);
                else
                {
                    c.Deposita(500.0);
                    MessageBox.Show("Limite excedido. Operação cancelada." + "\n" + "Saldo: " + c.saldo);
                }
            }
            else
                MessageBox.Show("Saldo insuficiente." + "\n" + "Saldo: " + c.saldo);

            c.Deposita(100.0);

            MessageBox.Show("Titular: " + c.Titular + "\n" + "Saldo: " + c.saldo);

            Conta c1 = new Conta();
            Cliente mauricio1 = new Cliente();
            c1.Numero = 1;
            c1.Titular = mauricio1;
            c1.Titular.Nome = "Maurício";
            c1.saldo = 2000.0;

            Conta c2 = new Conta();
            Cliente mauricio2 = new Cliente();
            c2.Numero = 1;
            c2.Titular = mauricio2;
            c2.Titular.Nome = "Maurício";
            c2.saldo = 10.0;

            if (c1 == c2)
                MessageBox.Show("Contas iguais");
            else
                MessageBox.Show("Contas diferentes.");

            c2 = c1;
            MessageBox.Show("Saldo c2: " + c2.Saldo);

            // Initializer (Inicia as propriedades no ato da criação do objeto)
            Conta c3 = new Conta()
            {
                Numero = 3,
                Titular = new Cliente()
                {
                    Nome = "Gabriel",
                    Idade = 21,
                    Rg = "13.345.765-9",
                    Cpf = "135.135.135-35",
                    Endereco = "Rua do Velho Chico, 54, Brotas de São Francisco, SE"
                },
                Limite = 1000.0                
            };

            MessageBox.Show("Conta nº " + c3.Numero + "\n" +
                "Titular: " + c3.Titular.Nome + ", " + c3.Titular.Idade + " anos" + "\n" +
                "RG " + c3.Titular.Rg + "\n" +
                "CPF " + c3.Titular.Cpf + "\n" +
                "Endereco: " + c3.Titular.Endereco);

            // Parâmetro Opcional e Nomeado (Para não ter a obrigação de informar todos os campos no construtor, basta utilizar especificar o atributo e adicionar ":")
            Cliente nando = new Cliente(nome: "Fernando");
            MessageBox.Show("Parâmetro Opcional e Nomeado\nNome: " + nando.Nome + "\nEndereço: " + nando.Endereco);
        }
    }
}
