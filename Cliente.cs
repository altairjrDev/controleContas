using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    class Cliente
    {
        private string nome;
        private string cpf;
        private int anoNascimento;

        public string nomeProp
        {
            get => nome;
            set => nome = value;
        }
        public int anoNascimentoProp
        {
            get { return anoNascimento; }
            set
            {
                if (value <= 2006)
                {
                    anoNascimento = value;
                }
                else
                {
                    Console.WriteLine("Cliente deve ter mais que 18 anos");
                }

            }
        }

        public string cpfProp
        {
            get { return cpf; }
            set
            {
                if (value.Length == 11 && !value.Contains('-') && !value.Contains('.'))
                {
                    cpf = value.ToString();
                }
                else
                {
                    Console.WriteLine("Seu cpf precisa conter 11 digitos e sem tracos e digitos");
                }

            }
        }

        public void Idade(int ano)
        {
            int idade;
            idade = 2024 - ano;
 
            Console.WriteLine($"A do cliente {nomeProp} e {idade} anos ");
        }
        public Cliente(string nome,string cpf, int anoNascimento)
        {
            this.nome = nome;
            this.cpfProp = cpf;
            this.anoNascimentoProp = anoNascimento;

        }
    }
}
