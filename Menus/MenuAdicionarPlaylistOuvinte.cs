using LogicaSoundFY.Modelos;

namespace LogicaSoundFY.Menus;

internal class MenuAdicionarPlaylistOuvinte : Menu
{
    public override void Executar(Dictionary<string, Ouvinte> ouvintesRegistrados)
    {
        base.Executar(ouvintesRegistrados);
        ExibirTituloDaOpcao("Adicionar playlist de um ouvinte");
        Console.Write("Digite o nome do ouvinte que deseja adicionar uma playlist: ");
        string nomeDoOuvinte = Console.ReadLine()!;
        Console.Write("Agora digite o título da playlist: ");
        string tituloPlaylist = Console.ReadLine()!;
        /**
         * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
         */
        Console.WriteLine($"A playlist {tituloPlaylist} foi adicionada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();        
    }
}
