using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInicial
{
    // Visibilidade Internal, quando "public", a visibilidade é externa, permitindo a integração com bibliotecas externas, as DLLs (Dynamic Link Library)
    class Cliente
    {
        private string nome, rg, cpf, endereco;
        private int idade = 15;

        // Sobrecarga de Construtores
        /* public Cliente()
        {

        }
        public Cliente(string nome)
        {
            this.Nome = nome;
        }*/

        // Construtor com parâmetros opcionais, evita a sobrecarga de construtores
        public Cliente(string nome = "Sem nome", string rg = "Sem RG", string cpf = "Sem CPF", string endereco = "Sem endereco", int idade = 0)
        {
            this.Nome = nome;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Endereco = endereco;
            this.Idade = idade;
        }
            // http://blog.caelum.com.br/parametros-opcionais-e-nomeados-do-c/

        // Declaração de Properties (O mesmo que Getters and Setters)
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }

        public bool EhMaiorDeIdade()
        {
            if (this.idade >= 18) return true;
            return false;
        }
    }
}
