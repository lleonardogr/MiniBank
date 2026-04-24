// See https://aka.ms/new-console-template for more information
using MiniBank;


var banco = new Banco("MiniBank");

var ana = new Cliente("Ana Silva", "123.456.789-00", "ana@mail.com",TipoCliente.PessoaFisica);

banco.AdicionarCliente(ana);

var ccAna = banco.AbrirContaCorrente(ana, 5000m);
var cpAna = banco.AbrirContaPoupanca(ana, 2000m);

ccAna.Depositar(500m);
ccAna.Sacar(200m);