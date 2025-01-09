using PokeAPI7DaysOfCode.DAL;
using PokeAPI7DaysOfCode.Entities;

namespace PokeAPI7DaysOfCode.BLL
{
    public class PokemonManager
    {
        public async Task GetPokemonsAsync()
        {
            // Faz a requisição na API via GET
            Task<List<Pokemon>> listaPokemons = PokeAPIDAL.GetAllPokemons();

            // Coloca todas as respostas em uma lista
            List<Pokemon> pokemons = await listaPokemons;

            // Mostra para o usuário os pokemons disponiveis
            foreach (var item in pokemons)
            {
                Console.WriteLine("==============================");
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Aperte qualquer tecla para retornar ao menu");
        }
    }
}
