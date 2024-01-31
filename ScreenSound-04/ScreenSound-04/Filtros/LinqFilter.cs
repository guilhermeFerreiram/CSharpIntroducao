using ScreenSound_04.Modelos;

namespace ScreenSound_04.FIltros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo artistas por gênero musical >>> {genero}\n");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine($"{nomeDoArtista}\n");
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidadeEscolhida)
    {
        var musicasPorTonalidade = musicas.Where(musica => musica.Tonalidade == tonalidadeEscolhida).ToList();
        Console.WriteLine($"Musicas da tonalidade {tonalidadeEscolhida}: ");
        foreach(var musica in musicasPorTonalidade)
        {
            musica.ExibirDetalhesDaMusica();
            Console.WriteLine("");
        }
    }
}
