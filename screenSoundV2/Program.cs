Album album = new Album();
album.Nome = "Californication";

Musica musica1 = new Musica();
musica1.Nome = "Scar Tissue";
musica1.Duracao = 337;

Musica musica2 = new Musica();
musica2.Nome = "Otherside";
musica2.Duracao = 416;

album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);

album.ExibirMusicasDoAlbum();