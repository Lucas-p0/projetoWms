using System.Text.Json.Serialization;

namespace projetoWms.Classes;

public class Estoque
{
    [JsonPropertyName("codigoProduto")]
    public int CodigoProduto { get; set; }


    [JsonPropertyName("nomeProduto")]
    public string? NomeProduto { get; set; }


    [JsonPropertyName("cubagemProduto")]
    public int CubagemProduto { get; set; }


    [JsonPropertyName("preco")]
    public int Preco { get; set; }


    [JsonPropertyName("quantidade")]
    public int Quantidade { get; set; }





}
