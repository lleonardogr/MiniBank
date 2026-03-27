using System;

namespace MiniBank;

public abstract class ContaBase : IConta
{
    public string Numero { get; }
    public decimal Saldo { get; protected set; }
    public Cliente Titular { get; }

    protected ContaBase(string numero, Cliente titular, decimal saldoInicial = 0)
    {
        Numero = numero;
        Titular = titular;
        Saldo = saldoInicial;
    }

    // Encapsulamento: deposito valida valor
    public void Depositar(decimal valor)
    {
        if (valor <= 0) return;
        Saldo += valor;
    }

    // Polimorfismo: cada tipo de conta define sua regra de saque
    public abstract bool Sacar(decimal valor);

    public virtual string ExibirExtrato()
        => $"[{GetType().Name}] Conta {Numero} | {Titular.Nome} | Saldo: {Saldo:C}";
}
