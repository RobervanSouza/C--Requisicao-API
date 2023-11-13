
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
}
