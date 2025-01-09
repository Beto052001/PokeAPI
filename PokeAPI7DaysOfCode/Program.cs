using PokeAPI7DaysOfCode.BLL;

bool rodando = true;
while (rodando)
{
    Console.WriteLine("====================================================");
    Console.WriteLine("Bem vindo ao PokeAPI !");
    Console.WriteLine("====================================================");
    Console.WriteLine("Selecione a opção desejada:");
    Console.WriteLine("====================================================");
    Console.WriteLine("1 - Visualizar pokemons disponiveis");
    Console.WriteLine("2 - Sair");
    Console.WriteLine("====================================================");
    ConsoleKeyInfo opcaoEscolhida = Console.ReadKey();

    switch (opcaoEscolhida.KeyChar)
    {
	    case '1':
            PokemonManager pokemonManager = new();
            pokemonManager.GetPokemonsAsync();
            break;
        case '2':
            rodando = false;
            break;
	    default:
		    break;
    }

    Console.Clear();
}