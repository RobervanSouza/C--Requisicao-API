using C__Requisicao_API.Modelos;


namespace C__Requisicao_API.filtros;

internal class LinqOrden
{
    public static void ExibirArtista (List<Musicas> musicas)
    {
        var artistaOrdenar = musicas.OrderBy(musicas => musicas.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artista ordenados");
        foreach (var ordenarArtista in artistaOrdenar)
        {
            Console.WriteLine($" -> {ordenarArtista} ");
        }

    }
}
