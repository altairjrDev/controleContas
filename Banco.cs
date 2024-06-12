using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
     class Banco
    {
        private string nome;
        private int numero;

        public string nomeProp
        {
            get => nome; set => nome = value;
        }

        public int numerobancoProp
        {
            get => numero; set => numero = value;
        }

        public Banco(string nome, int numero)
        {
            this.nomeProp = nome;
            this.numerobancoProp = numero;
        }
    }
}
