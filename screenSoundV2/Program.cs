Banda banda = new Banda("Red Hot Chilli Peppers");
Album album = new Album("Californication");

Musica musica1 = new Musica(banda, "Scar Tissue")
{
    Duracao = 337,
    Disponivel = true,
};

Musica musica2 = new Musica(banda, "Otherside")
{
    Duracao = 416,
    Disponivel = true,
};

album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
album.ExibirMusicasDoAlbum();

banda.AdicionarAlbum(album);
banda.ExibirDiscografia();



Podcast podcast = new Podcast("PodCharp", "Julio");

Episodio ep1 = new Episodio(1, "C# na prática", 45);
ep1.AdicionarConvidado("Horty");
ep1.AdicionarConvidado("Kemily");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new Episodio(2, "C# orientado a objetos", 50);
ep2.AdicionarConvidado("Horty");
ep2.AdicionarConvidado("Kemily");
Console.WriteLine(ep2.Resumo);

podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();