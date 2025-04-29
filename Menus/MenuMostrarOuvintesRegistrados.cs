using LogicaSoundFY.Modelos;

namespace LogicaSoundFY.Menus;

internal class MenuMostrarOuvintesRegistrados : Menu
{
    public override void Executar(Dictionary<string, Ouvinte> ouvintesRegistrados)
    {
        base.Executar(ouvintesRegistrados);
        ExibirTituloDaOpcao("Exibindo todos os ouvintes registrados na nossa aplicação");
        foreach (string ouvinte in ouvintesRegistrados.Keys)
        {
            Console.WriteLine($"Ouvinte: {ouvinte}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();        
    }
}

