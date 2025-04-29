using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
     class Banda
    {
        private List<Album> albuns = new List<Album>();

        public Banda(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }
        public List<Album> Albuns => albuns;

        public void AdicionarAlbum(Album album)
        {
            if (album != null)
            {
                albuns.Add(album);
            }
            else
            {
                throw new ArgumentNullException(nameof(album), "O álbum não pode ser nulo.");
            }
        }

        public void ExibirAlbunsDaBanda()
        {
            Console.WriteLine($"Álbuns da banda {Nome}:");
            foreach (var album in albuns)
            {
                Console.WriteLine($"- {album.Nome}");
            }
        }
    }
}