using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaSoundFY.Modelos
{
    class Musica
    {
        public Musica(Banda artista, string nome, Album album)
        {
            Artista = artista;
            Nome = nome;
            Album = album;
        }

        public string Nome { get; }
        public Banda Artista { get; }
        public Album Album { get; }
        public string DescricaoResumida => $"A música{Nome} - {Artista} pertence ao álbum {Album} ";
    }
}
