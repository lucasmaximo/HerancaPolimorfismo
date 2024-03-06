using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
    internal class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca() { }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }

        public sealed override void Sacar(double quantia)
        {
            base.Sacar(quantia);
            Saldo -= 2.0;
        }
    }
}
