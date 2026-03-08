using System.Text.Json.Serialization;

namespace ConsumerPokeApi.Models
{
    public class Pokemon
{
    [JsonPropertyName("id")]
    public int Id{get; set;}
    [JsonPropertyName("name")]
    public string Name{get; set;}
    [JsonPropertyName("weight")]
    public int Weight{get; set;}
    [JsonPropertyName("height")]
    public int Height{get; set;}
}
    
}