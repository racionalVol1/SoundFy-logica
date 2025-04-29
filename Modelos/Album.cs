namespace LogicaSoundFY.Modelos
{
    class Album
    {
        private List<Musica> musicas = new List<Musica>();

        public Album(string nome, Banda artista)
        {
            Nome = nome;
            Artista = artista;
        }

        public string Nome { get; }
        public Banda Artista { get; }

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

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Músicas do álbum {Nome} de {Artista}:");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }

    }
}

