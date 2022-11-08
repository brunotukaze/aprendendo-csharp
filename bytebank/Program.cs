using bytebank.Contas;
using bytebank.Titular;

//comentar  (CTRL + K + C), descomentar (CTRL + K + U)

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "andré silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.saldo = 100;
//Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre2.titular = "andré silva";
//contaDoAndre2.numero_agencia = 15;
//contaDoAndre2.conta = "1010-x";
//contaDoAndre2.saldo = 100;
//Console.WriteLine("Saldo da conta do André = " + contaDoAndre2.saldo);

//Console.WriteLine(contaDoAndre == contaDoAndre2);

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Flores";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta do Maria = " + contaDaMaria.saldo);
//Console.WriteLine("****Executando transferência****");

//contaDoAndre.Transferir(12.52, contaDaMaria);
//Console.WriteLine("Saldo da conta do André pós transferência = " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da conta do Maria pós transferência = " + contaDaMaria.saldo);

//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("Nº Conta = " + conta.conta);
//Console.WriteLine("Nº Agência = " + conta.numero_agencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "987654321";
//conta2.conta = "9999-X";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);


ContaCorrente conta3 = new ContaCorrente();
conta3.SetSaldo(120);
Console.WriteLine(conta3.GetSaldo());