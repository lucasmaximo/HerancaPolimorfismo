// See https://aka.ms/new-console-template for more information

using HerancaPolimorfismo.Entities;
using System.Globalization;

#region Testes de upcasting e downcasting

//Conta c = new Conta(1001, "Alex", 0.0);

ContaEmpresarial ce = new ContaEmpresarial(1002, "Maria", 0.0, 500.0);

//UPCASTING

Conta conta1 = ce;
Conta conta2 = new ContaEmpresarial(1003, "Bob", 0.0, 200.0);
Conta conta3 = new ContaPoupanca(1004, "Anna", 0.0, 0.01);

//DOWNCASTING

ContaEmpresarial conta4 = (ContaEmpresarial)conta2;
conta4.Emprestimo(100.0);


if(conta3 is ContaEmpresarial) // verifica se o objeto conta3 é do tipo ContaEmpresarial
{
    //ContaEmpresarial conta5 = (ContaEmpresarial)(conta3);
    ContaEmpresarial conta5 = conta3 as ContaEmpresarial;
    conta5.Emprestimo(200.0);
    Console.WriteLine("Empréstimo!");
}

if(conta3 is ContaPoupanca)
{
    ContaPoupanca conta5 = (ContaPoupanca)conta3;
    //ContaPoupanca conta5 = conta3 as ContaPoupanca;
    conta5.AtualizarSaldo();
    Console.WriteLine("Saldo atualizado!");
}

#endregion

List<Conta> list = new List<Conta>();

list.Add(new ContaPoupanca(1001, "Alex", 500.00, 0.01));
list.Add(new ContaEmpresarial(1002, "Maria", 500.00, 400.00));
list.Add(new ContaPoupanca(1003, "Bob", 500.00, 0.01));
list.Add(new ContaEmpresarial(1004, "Anna", 500.00, 500.00));


double soma = 0.0;

foreach (Conta conta in list)
{
    soma += conta.Saldo;
}

Console.WriteLine("Saldo total: " + soma.ToString("F2", CultureInfo.InvariantCulture));

foreach (Conta conta in list)
{
    conta.Sacar(10.0);
}

foreach (Conta conta in list)
{
    Console.WriteLine("Saldo atualizado por conta "
        + conta.Numero
        + ": "
        + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
}