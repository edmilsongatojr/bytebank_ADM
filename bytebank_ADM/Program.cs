using bytebank_ADM.Funcionarios;

Console.WriteLine("    *.* Boas Vindas ao ByteBank Administração *.*");
Console.WriteLine("=====================================================");

Funcionario pedro = new(1);
pedro.Nome = "João";
pedro.Cpf = "123456789-48";
pedro.Salario = 2000;

Console.WriteLine("Nome: " + pedro.Nome);
Console.WriteLine("CPF: " + pedro.Cpf);
Console.WriteLine("Salário: " + pedro.Salario);

Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.ReadKey();