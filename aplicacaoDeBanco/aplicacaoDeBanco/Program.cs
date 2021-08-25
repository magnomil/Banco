using System;
using System.Globalization;

namespace aplicacaoDeBanco
{
    class Program
    {
        static void Main(string[] args)
        {

            // projeto de banco

            Conta contaBancaria;
            
            Console.Write("Entre o número da conta:");

            int numeroDaConta = int.Parse(Console.ReadLine());
           

            Console.WriteLine("Entre o titular da conta:");
           
            string titulardaconta = Console.ReadLine();


            Console.WriteLine("Haverá depósito inicial? Para sim digite s ou para não digite n ");

            char resp = char.Parse(Console.ReadLine()); 
            
            if (resp =='s' || resp =='S')
            {
                Console.WriteLine("Digite o quanto quer depositar");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                contaBancaria = new Conta(numeroDaConta, titulardaconta, depositoInicial );
            }
            else
            {
                contaBancaria = new Conta(numeroDaConta, titulardaconta);
            }


            Console.WriteLine("Dados Atualizados da conta: ");
            Console.WriteLine(contaBancaria);


            Console.Write("Entre com o valor para Depósito");
            double quantia= double.Parse( Console.ReadLine(),CultureInfo.InvariantCulture);
            contaBancaria.Deposito(quantia);

            Console.WriteLine("Dados Atualizados da conta: ");
            Console.WriteLine(contaBancaria);


            Console.Write("Entre com o valor para Saque");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(saque);

            Console.WriteLine("Dados Atualizados da conta: ");
            Console.WriteLine(contaBancaria);








        }
    }
}
