using C__Requisicao_API.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musicas>> (resposta)!;
        musicas[0].ExibirDetalhesMusicas();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Houve algum problema: {ex.Message}");
    }
}

