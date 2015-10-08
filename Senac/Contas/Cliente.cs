using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM.Treinamento.Senac.Contas
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Cliente() { }

        // Construtor que só recebe o nome
        public Cliente(string nome)
        {
            this.Nome = nome;
        }
        // Construtor que recebe o nome e a idade
        public Cliente(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}
