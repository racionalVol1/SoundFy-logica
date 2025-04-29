using LogicaSoundFY.Modelos;

namespace LogicaSoundFY.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            /**
            * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
            */
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();        

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();           
        }
    }
    public override void Executar(Dictionary<string, Ouvinte> ouvintesRegistrados)
    {
        base.Executar(ouvintesRegistrados);
        ExibirTituloDaOpcao("Exibir detalhes do ouvinte");
        Console.Write("Digite o nome do ouvinte que deseja conhecer melhor: ");
        string nomeDoOuvinte = Console.ReadLine()!;
        if (ouvintesRegistrados.ContainsKey(nomeDoOuvinte))
        {
            Ouvinte ouvinte = ouvintesRegistrados[nomeDoOuvinte];
            /**
            * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
            */
            Console.WriteLine("Digite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO ouvinte {nomeDoOuvinte} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
