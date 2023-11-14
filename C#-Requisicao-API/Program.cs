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
        //LinqFiltro.FiltrarArtistaPorGenero(musicas, "pop");
        // LinqFiltro.FiltrarMusicas(musicas, "U2");
        var musicasPreferidas = new MusicasPreferidas("Robervan Souza");
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[8]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[12]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[16]);

        musicasPreferidas.ExibirMusicasFavoritas();
        musicasPreferidas.GerarArquivoJson(@"C:\Users\robro\OneDrive\Área de Trabalho\Curso Alura\C#");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Houve algum problema: {ex.Message}");
    }
}

