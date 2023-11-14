
using C__Requisicao_API.Modelos;

namespace C__Requisicao_API.filtros;

internal class LinqFiltro
{
    public static void FiltrarTodosGeneros(List<Musicas> musicas)
    {
        var todosOsGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var generos in todosOsGeneros)
        {
            Console.WriteLine($" -> {generos}");
        }
    }

    public static void FiltrarArtistaPorGenero(List<Musicas> musicas, string genero)
    {
        var artistaPorGenero = musicas.Where(musicas => musicas.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($" Exibindo os artistas por generos -> {genero} ");
        foreach (var artista in artistaPorGenero)
        {
            Console.WriteLine($" -> {artista} ");
        }
    }

    public static void FiltrarMusicas (List<Musicas> musicas, string nomeArtista)
    {
        var musicaArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista)).ToList();
        Console.WriteLine($" Exibindo nome do artista-> {nomeArtista} ");
        foreach (var musica in musicaArtista)
        {
            Console.WriteLine($" -> {musica.Nome} ");
        }
    }

}
