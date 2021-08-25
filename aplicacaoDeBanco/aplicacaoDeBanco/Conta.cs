using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace aplicacaoDeBanco
{
    class Conta
    {
        public int NumeroDaConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set;}


        public Conta(int numeroDaConta, string titulardaconta, double depositoInicial){

            NumeroDaConta = numeroDaConta;
            Titular = titulardaconta;
            //Saldo = saldo;
            Deposito(depositoInicial);
        }


        public Conta(int numeroDaConta, string titularDaConta)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titularDaConta;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }
        public override string ToString()
        {
            return
                "Número da Conta: "
                + NumeroDaConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
           
}


