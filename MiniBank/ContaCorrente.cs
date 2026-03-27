using System;

namespace MiniBank;

public sealed class ContaCorrente : ContaBase
{
    public decimal LimiteChequeEspecial { get; }

    public ContaCorrente(string numero, Cliente titular, decimal saldoInicial = 0, decimal limite = 500m)
        : base(numero, titular, saldoInicial)
    {
        LimiteChequeEspecial = limite;
    }

    public override bool Sacar(decimal valor)
    {
        if (valor <= 0) return false;
        if (valor > Saldo + LimiteChequeEspecial) return false;
        Saldo -= valor;
        return true;
    }

    public override string ExibirExtrato()
        => base.ExibirExtrato() + $" | Limite: {LimiteChequeEspecial:C}";
}
