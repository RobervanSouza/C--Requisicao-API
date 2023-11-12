

using System.Text.Json.Serialization;

namespace C__Requisicao_API.Modelos;

internal class Musicas
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]

    public string? Genero{ get; set; }

    public void ExibirDetalhesMusicas()
    {
        Console.WriteLine($" Nome : {Nome}");
        Console.WriteLine($" Artista : {Artista}");
        Console.WriteLine($" Duração em Segundos : {Duracao /1000}");
        Console.WriteLine($" Genero:  {Genero}");
    }
}
