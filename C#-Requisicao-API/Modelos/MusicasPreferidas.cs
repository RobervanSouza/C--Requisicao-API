using System.Text.Json;

namespace C__Requisicao_API.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musicas> ListaMusicasFavoritas { get; set; }
    public MusicasPreferidas (string nome)
    {
        Nome = nome;
        ListaMusicasFavoritas = new List<Musicas>();
    }
    public void AdicionarMusicasFavoritas(Musicas musicas)
    {
        ListaMusicasFavoritas.Add(musicas);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as musicas favoritas -> {Nome} ");
        foreach (var musica in ListaMusicasFavoritas)
        {
            Console.WriteLine($" => {musica.Nome} do Artistas: {musica.Artista}");
        }
        Console.WriteLine();
    }
    public void GerarArquivoJson(string caminhoDaPasta)
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaMusicasFavoritas
        });

        // Combine o caminho da pasta com o nome do arquivo
        string nomeArquivo = Path.Combine(caminhoDaPasta, $"Musicas-favoritas-{Nome}.json");

        // Crie o arquivo no caminho completo
        File.WriteAllText(nomeArquivo, json);

        Console.WriteLine($"Arquivo Json criado com sucesso em: {nomeArquivo}");
    }

}
