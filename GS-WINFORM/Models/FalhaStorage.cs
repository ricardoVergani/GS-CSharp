using System.Collections.Generic;
using System.IO;
using System.Text.Json;



public static class FalhaStorage
{
    private static readonly string caminho = "falhas.json";

    // Carrega falhas que ja existem e as converte em JSON
    public static void SalvarFalha(FalhaEnergia falha)
    {
        List<FalhaEnergia> lista = CarregarFalhas();
        lista.Add(falha);
        string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(caminho, json);
    }

    // Recebe a lista e salva no arquivo
    public static void SalvarFalhas(List<FalhaEnergia> falhas)
    {
        string json = JsonSerializer.Serialize(falhas, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(caminho, json);
    }

    // Verifica a existencia do arquivo e le o seu conteudo
    public static List<FalhaEnergia> CarregarFalhas()
    {
        if (!File.Exists(caminho))
            return new List<FalhaEnergia>();

        string json = File.ReadAllText(caminho);
        return JsonSerializer.Deserialize<List<FalhaEnergia>>(json);
    }
}