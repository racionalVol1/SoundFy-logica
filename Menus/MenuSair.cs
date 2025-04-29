using LogicaSoundFY.Modelos;

namespace LogicaSoundFY.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Saindo do programa...");
    }

}
