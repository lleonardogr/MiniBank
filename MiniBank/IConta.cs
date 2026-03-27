using System;

namespace MiniBank;

public interface IConta
{
    string Numero { get; }
    decimal Saldo { get; }
    Cliente Titular { get; }
    void Depositar(decimal valor);
    bool Sacar(decimal valor);
    string ExibirExtrato();
}
