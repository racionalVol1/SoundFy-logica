using LogicaSoundFY.Modelos;
using LogicaSoundFY.Menus;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Banda sepultura = new("Sepultura");
        Banda metallica = new("Metallica");

        Album album1 = new("Roots", sepultura);
        Album album2 = new("Black Album", metallica);

        Ouvinte ouvinte1 = new("Guilherme");
        Ouvinte ouvinte2 = new("Carlos");

        Playlist playlist1 = new("Playlist1");
        Playlist playlist2 = new("Playlist2");

        Dictionary<string, Banda> bandasRegistradas = new();
        Dictionary<string, Ouvinte> OuvintesRegistrados = new();

        Dictionary<string, Album> AlbunsRegistrados = new();
        Dictionary<string, Playlist> PlaylistsRegistradas = new();

        bandasRegistradas.Add(sepultura.Nome, sepultura);
        bandasRegistradas.Add(metallica.Nome, metallica);

        AlbunsRegistrados.Add(album1.Nome, album1);
        AlbunsRegistrados.Add(album2.Nome, album2);

        OuvintesRegistrados.Add(ouvinte1.Nome, ouvinte1);
        OuvintesRegistrados.Add(ouvinte2.Nome, ouvinte2);

        PlaylistsRegistradas.Add("Playlist1", new Playlist("Playlist1"));
        PlaylistsRegistradas.Add("Playlist2", new Playlist("Playlist2"));

        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuRegistrarAlbum());
        opcoes.Add(3, new MenuMostrarBandasRegistradas());
        opcoes.Add(4, new MenuExibirDetalhes());
        opcoes.Add(5, new MenuRegistrarOuvinte());
        opcoes.Add(6, new MenuAdicionarPlaylistOuvinte());
        opcoes.Add(7, new MenuMostrarOuvintesRegistrados());
        opcoes.Add(8, new MenuExibirDetalhes());
        opcoes.Add(0, new MenuSair());


        void ExibirOpcoesDoMenu()
        {
            Console.WriteLine("1. Registrar banda");
            Console.WriteLine("2. Adicionar álbum de uma banda");
            Console.WriteLine("3. Mostrar bandas");
            Console.WriteLine("4. Exibir detalhes bandas");
            Console.WriteLine("5. Registrar ouvinte");
            Console.WriteLine("6. Adcionar playlist de um ouvinte");
            Console.WriteLine("7. Mostrar ouvintes");
            Console.WriteLine("8. Exibir detalhes ouvintes");
            Console.WriteLine("0. Sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
            {
                Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
                menuASerExibido.Executar(bandasRegistradas);
                if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Thread.Sleep(2000);
                Console.Clear();
            }       
                     
        }            
        
        ExibirOpcoesDoMenu();
    }
}