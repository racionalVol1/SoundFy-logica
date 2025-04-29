using LogicaSoundFY.Modelos;

namespace LogicaSoundFY.Menus;

internal class MenuRegistrarOuvinte : Menu
{
    public override void Executar(Dictionary<string, Ouvinte> ouvintesRegistrados)
    {
        base.Executar(ouvintesRegistrados);
        ExibirTituloDaOpcao("Registro de ouvintes");
        Console.Write("Digite o nome do ouvinte que deseja registrar: ");
        string nomeDoOuvinte = Console.ReadLine()!;
        Ouvinte ouvinte = new Ouvinte(nomeDoOuvinte);
        ouvintesRegistrados.Add(nomeDoOuvinte, ouvinte);
        Console.WriteLine($"O ouvinte {nomeDoOuvinte} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
