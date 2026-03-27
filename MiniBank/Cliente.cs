using System;

namespace MiniBank;

public class Cliente
{
    public string Nome { get; private set; }
    public string Cpf { get; private set; }
    public string Email { get; set; }

    public Cliente(string nome, string cpf, string email)
    {
        Nome = nome;
        Cpf = cpf;
        Email = email;
    }

    public override string ToString() => $"{Nome} (CPF: {Cpf})";
}
