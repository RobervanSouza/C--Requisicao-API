using C__Requisicao_API.Modelos;
using System.Text.Json;
using C__Requisicao_API.filtros;



using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musicas>> (resposta)!;
      //   LinqFiltro.FiltrarTodosGeneros(musicas);
        //LinqOrden.ExibirArtista(musicas);
       LinqFiltro.FiltrarArtistaPorGenero(musicas, "pop");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Houve algum problema: {ex.Message}");
    }
}

