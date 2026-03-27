using System;

namespace MiniBank;

public class ContaPoupanca : ContaBase
{
    public decimal TaxaRendimento { get; }

    public ContaPoupanca(string numero, Cliente titular, decimal saldoInicial = 0, decimal taxa = 0.005m)
        : base(numero, titular, saldoInicial)
    {
        TaxaRendimento = taxa;
    }

    public override bool Sacar(decimal valor)
    {
        if (valor <= 0 || valor > Saldo) return false;
        Saldo -= valor;
        return true;
    }

    public void AplicarRendimento()
    {
        Depositar(Saldo * TaxaRendimento);
    }
}
