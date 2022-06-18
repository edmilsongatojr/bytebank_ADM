using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;

Console.WriteLine("    *.* Boas Vindas ao ByteBank Administração *.*");
Console.WriteLine("=====================================================");

CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new();
    Designer pedro = new("833.222.048-39");
    pedro.Nome = "Pedro";

    Desenvolvedor samya = new("123.789.654-55");
    samya.Nome = "Samya";

    Diretor paula = new("159.753.398-04");
    paula.Nome = "Paula";

    Auxiliar igor = new("981.198.778-53");
    igor.Nome = "Igor";

    GerenteDeContas camila = new("326.985.628-89");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(samya);

    Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao()); 
}

Console.ReadKey();