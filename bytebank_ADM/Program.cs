using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;

Console.WriteLine("    *.* Boas Vindas ao ByteBank Administração *.*");
Console.WriteLine("=====================================================");

GerenciadorDeBonificacao gerenciador = new();
GerenciadorDeSalarios gerenciadorDeSalarios = new();

Funcionario pedro = new("123456789-48",2000.00);
pedro.Nome = "João";
Console.WriteLine("Total de Funcionários: " + Funcionario.totalDeFuncionarios);
Console.WriteLine("-----------------------------------------------------\n");
Console.WriteLine("Nome: " + pedro.Nome);
Console.WriteLine("CPF: " + pedro.Cpf);
Console.WriteLine("Salário: " + pedro.getSalario());
Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.WriteLine("-----------------------------------------------------\n");

Diretor diretor = new("958741354-55",7000.00);
diretor.Nome = "Jimmy";
Console.WriteLine("Total de Funcionários: " + Funcionario.totalDeFuncionarios);
Console.WriteLine("-----------------------------------------------------\n");
Console.WriteLine("Nome: " + diretor.Nome);
Console.WriteLine("CPF: " + diretor.Cpf);
Console.WriteLine("Salário: " + diretor.getSalario());
Console.WriteLine("Bonificação: " + diretor.getBonificacao());
Console.WriteLine("-----------------------------------------------------\n");

//totalBonificacao = diretor.getBonificacao();
//totalBonificacao += pedro.getBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(diretor);
gerenciadorDeSalarios.RegistrarSalario(pedro);
gerenciadorDeSalarios.RegistrarSalario(diretor);
Console.WriteLine("Total de Bonificação: R$" + gerenciador.getBonificacao());
Console.WriteLine("Total de Salários: R$" + gerenciadorDeSalarios.getTotalSalario());
Console.WriteLine("-----------------------------------------------------\n");
diretor.AumentarSalario();
Console.WriteLine("Novo Salário: " + diretor.Salario);
Console.ReadKey();