// See https://aka.ms/new-console-template for more information
using MiniBank;

var ana = new Cliente("Ana Silva", "123.456.789-00", "ana@mail.com",TipoCliente.PessoaFisica);

var contaCorrente = new ContaCorrente("CC-001", ana, 1000m, limite: 500m);
var contaPoupanca = new ContaPoupanca("CP-001", ana, 2000m);

var contas = new List<IConta> { contaCorrente, contaPoupanca };

contaCorrente.Depositar(500m);
contaCorrente.Depositar(200m);

foreach (var conta in contas)
{
    Console.WriteLine(conta.ExibirExtrato());
}

contaCorrente.Sacar(1200m); // usa cheque especial
bool ok = contaPoupanca.Sacar(9999m); // false — sem cheque especial