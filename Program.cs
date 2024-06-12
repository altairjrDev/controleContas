using System;


namespace controleContas
{

     class Program
    {


        static void Main(string[] args)
        {
            decimal saldoMaior = 0m;
            int contaMaior = 0;
            decimal saldoTotal = 0m;
            Banco banco1 = new Banco("Santander", 1010);
            Agencia agencia1 = new Agencia(100, "27777777", "5527995555554", banco1);
            Agencia agencia2 = new Agencia(101, "27777788", "5527992222222", banco1);
            Cliente cliente1 = new Cliente("Altair", "12345678911", 2005);
            Cliente cliente2 = new Cliente("Altair2", "12345432101", 2000);
            List<Conta> contas = new List<Conta>
        {
            new Conta(123456, 1235.42m, cliente1,agencia1),
            new Conta(654321, 2341.42m, cliente2, agencia1)
        };
        
         
            foreach (var conta in contas)
                {
                saldoTotal += conta.SaldoProp;
                };

            foreach (var conta in contas)
            {
                if(conta.SaldoProp > saldoMaior)
                {
                    saldoMaior = conta.SaldoProp;
                    contaMaior = conta.NumeroProp;
                }
               
            };
            Console.WriteLine($"Contas: ");
            foreach (var conta in contas)
            {
                Console.WriteLine(
                $"\n Agencia {conta.agenciaProp.numeroAgenciaProp} do Banco {conta.agenciaProp.bancoProp.nomeProp} " +
                $"\n numero {conta.NumeroProp} do cliente {conta.titularProp.nomeProp} tem saldo {conta.SaldoProp}. ");
            };
            Console.WriteLine(
                $"\n Numero da Conta com Maior Saldo: {contaMaior}. " +
                $"\n Saldo Inicial Geral {saldoTotal}");
            Console.Read();
        }
    }
}
