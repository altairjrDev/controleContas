  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    class Agencia
    {
        private int numero;
        private string CEP;
        private string telefone;
        public Banco banco;

        public int numeroAgenciaProp
        {
            get => numero; set => numero = value;
        }

        public string CEPProp
        {
            get => CEP;
            set
            {
                if (value.Length == 8 && !value.Contains('-'))
                {
                    CEP = value;
                }
                else
                {
                    Console.WriteLine("Necessario ter 8 algarismos sem pontuacao");
                }
            }
        }

        public string telefoneProp
        {
            get => telefone;
            set
            {
                if (value.Length >= 13 && !value.Contains('-'))
                {
                    telefone = value;
                }
                else
                {
                    Console.WriteLine("Necessario colocar ex: 5527999222222");
                }
            }
        }
        public Banco bancoProp
        {
            get => banco; set => banco = value;
        }

        public Agencia(int numero, string CEP, string telefone, Banco banco)
        {
            this.numeroAgenciaProp = numero;
            this.CEPProp = CEP;
            this.telefoneProp = telefone;
            this.bancoProp = banco;
        }
    }
}
