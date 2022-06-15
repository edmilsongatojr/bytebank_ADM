using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;

Console.WriteLine("    *.* Boas Vindas ao ByteBank Administração *.*");
Console.WriteLine("=====================================================");

GerenciadorDeBonificacao gerenciador = new();


Funcionario pedro = new();
pedro.Nome = "João";
pedro.Cpf = "123456789-48";
pedro.Salario = 2000;

Console.WriteLine("Nome: " + pedro.Nome);
Console.WriteLine("CPF: " + pedro.Cpf);
Console.WriteLine("Salário: " + pedro.Salario);
Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.WriteLine("-----------------------------------------------------\n");

Diretor diretor = new();
diretor.Nome = "Jimmy";
diretor.Cpf = "958741354-55";
diretor.Salario = 7000;

Console.WriteLine("Nome: " + diretor.Nome);
Console.WriteLine("CPF: " + diretor.Cpf);
Console.WriteLine("Salário: " + diretor.Salario);
Console.WriteLine("Bonificação: " + diretor.getBonificacao());
Console.WriteLine("-----------------------------------------------------\n");

//totalBonificacao = diretor.getBonificacao();
//totalBonificacao += pedro.getBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(diretor);
Console.WriteLine("Total de Bonificação: R$" + gerenciador.getBonificacao());
Console.ReadKey();