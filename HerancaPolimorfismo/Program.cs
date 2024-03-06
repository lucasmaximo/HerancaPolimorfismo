// See https://aka.ms/new-console-template for more information

using HerancaPolimorfismo.Entities;

#region Testes de upcasting e downcasting

Conta c = new Conta(1001, "Alex", 0.0);

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

Conta c1 = new Conta(1001, "Alex", 500.00);
Conta c2 = new ContaPoupanca(1002, "Anna", 500.00, 0.01);

c1.Sacar(10.0);
c2.Sacar(10.0);

Console.WriteLine(c1.Saldo);
Console.WriteLine(c2.Saldo);