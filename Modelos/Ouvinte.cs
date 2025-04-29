using System;
using System.Collections.Generic;

namespace LogicaSoundFY.Modelos
{
    class Ouvinte
    {
        private List<Playlist> playlists = new List<Playlist>();

        public Ouvinte(string nome)
        {
            Nome = nome;            
        }

        public string Nome { get; }
        public List<Playlist> Playlists => playlists;

        public void AdicionarPlaylist(Playlist playlist)
        {
            if (playlist != null)
            {
                playlists.Add(playlist);
            }
            else
            {
                throw new ArgumentNullException(nameof(playlist), "A playlist não pode ser nula.");
            }
        }

        public void ExibirPlaylistsDoOuvinte()
        {
            Console.WriteLine($"Playlists do ouvinte {Nome}:");
            foreach (var playlist in playlists)
            {
                Console.WriteLine($"- {playlist.Nome}");
            }
        }
    }
} 
