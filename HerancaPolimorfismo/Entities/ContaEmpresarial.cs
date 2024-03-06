using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
    internal class ContaEmpresarial : Conta
    {
        public double LimiteEmprestimo { get; set; }


        public ContaEmpresarial() { }

        // O ":base" abaixo serve para aproveitar os parâmetros do método construtor da superclasse
        public ContaEmpresarial(int numero, string titular, double saldo, double limiteEmprestimo) : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double quantia)
        {
            if (quantia < LimiteEmprestimo)
            {
                Saldo += quantia;
            }
        }
    }
}
