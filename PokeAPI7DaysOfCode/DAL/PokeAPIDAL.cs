using System.Net.Http;
using System.Text.Json;
using PokeAPI7DaysOfCode.Entities;

namespace PokeAPI7DaysOfCode.DAL
{
    public class PokeAPIDAL
    {
        public static async Task<List<Pokemon>> GetAllPokemons()
        {            
            // Instancia o HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Requisição Get
                    HttpResponseMessage response = await client.GetAsync("https://pokeapi.co/api/v2/pokemon/");

                    // Valida a resposta
                    if (response.IsSuccessStatusCode)
                    {
                        // Transforma o resultado em uma string
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Desserializando o JSON no objeto PokemonResponse
                        PokemonResponse pokemonResponse = JsonSerializer.Deserialize<PokemonResponse>(responseBody);

                        // Acessando a lista de Pokémons em "results"
                        List<Pokemon> pokemons = pokemonResponse.Results;

                        return pokemons;
                    }
                    else
                    {
                        Console.WriteLine($"Erro: {response.StatusCode}");
                        return new List<Pokemon>();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exceção: {ex.Message}");
                    return new List<Pokemon>();
                }
            }
        }
    }
}
