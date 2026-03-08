using static System.Console;
using System.Text.Json;
using ConsumerPokeApi.Models;

WriteLine("Digite o nome de um pokemon: ");
string nome = ReadLine();

string url = $"https://pokeapi.co/api/v2/pokemon/{nome}";
WriteLine($"Consultando o pokemon: {nome}........");

try
{
    using var client = new HttpClient();
    var response = await client.GetAsync(url);
    response.EnsureSuccessStatusCode();

    var content = await response.Content.ReadAsStringAsync();
    var pokemon = JsonSerializer.Deserialize<Pokemon>(content);

    if (pokemon != null)
    {
        WriteLine($"ID: {pokemon.Id}");
        WriteLine($"Altura: {pokemon.Height}");
        WriteLine($"Nome: {pokemon.Name}");
        WriteLine($"Peso: {pokemon.Weight}");
    }
    else
    {
        WriteLine("Pokemon não encontrado :c");
    }

}
catch (Exception ex)
{
    WriteLine($"Erro ao consultar o Perfil: {ex.Message}");
}
