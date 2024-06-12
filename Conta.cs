using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
     class Conta


    {
        private int numero;
        private decimal saldo;
        private Cliente titular;
        private Agencia agencia;
        public int NumeroProp { get => numero; 
            set => numero = value;  }

        public Cliente titularProp
        {
            get => titular;
            set => titular = value;
        }

        public Agencia agenciaProp
        {
            get => agencia;
            set => agencia = value;
        }


        public decimal SaldoProp { get {  return saldo; } set { if(value >= 0.0m)
                {
                    saldo = value;

                }
                else
                {
                    Console.WriteLine("O saldo não pode ser definido como negativo");
                } 
            } 
        }

        public void Deposito(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Saldo: {saldo}");
            }
            else
            {
                Console.WriteLine("Deposito não realizado por causa do valor negativo");
            }
        }

        public void Trasferencia(decimal valor, Conta conta)
        {
            if (valor >= saldo && valor >0)
            {
                saldo -= valor;
                conta.Deposito(valor);
                Console.WriteLine($"Tranferencia realizada: Conta pagadora - {NumeroProp} valor - {SaldoProp} e conta recebedora {conta.NumeroProp} valor - {conta.SaldoProp}");
              
            }
            else
            {
                Console.WriteLine("O saldo não pode ficar negativo, o valor de transferencia não pode ser negativo");
            }
        }

        public void Saque(decimal valor)
        {
            if (valor > 0  && saldo >= valor)
            {
            
                saldo -= valor;
                saldo -= 0.10m;
                Console.WriteLine($"Saldo: {saldo}");
            }
            else
            {
                Console.WriteLine("Saque não realizado por causa do valor negativo ou sua conta ficaria negativa");
            }
        }

        public Conta(int numero, decimal saldo, Cliente cliente, Agencia agencia)
        {
            this.numero = numero;
           
            if (saldo >= 10.0m) {
                this.SaldoProp = saldo;
            } else {
                Console.WriteLine("Conta não criada por causa do saldo inferior a 10 reais");
            }
            if(cliente != null){ 
                this.titularProp = cliente;
            }
            else
            {
                Console.WriteLine("Conta não criada por causa da falta de titular");
            }
            if (agencia != null)
            {
                this.agenciaProp = agencia;
            }
            else
            {
                Console.WriteLine("Conta não criada por causa da falta de uma agencia");
            }


        }

    }
}
