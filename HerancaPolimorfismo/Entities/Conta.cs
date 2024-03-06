using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
    internal class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; } // o protected permite que o valor dessa variável seja alterado através da subclasse

        public Conta() { }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Sacar(double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }
    }
}
