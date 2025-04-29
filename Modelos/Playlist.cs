using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    class Playlist
    {
        private List<Musica> musicas = new List<Musica>();

        public Playlist(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }
        public List<Musica> Musicas => musicas;

        public void AdicionarMusica(Musica musica)
        {
            if (musica != null)
            {
                musicas.Add(musica);
            }
            else
            {
                throw new ArgumentNullException(nameof(musica), "A música não pode ser nula.");
            }
        }

        public void ExibirMusicasDaPlaylist()
        {
            Console.WriteLine($"Músicas da playlist {Nome}:");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }
    }
}
