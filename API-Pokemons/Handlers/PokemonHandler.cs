using System;
using API_Pokemons.Model;

namespace API_Pokemons.Handlers
{
    public class PokemonHandler
    {
        public PokemonHandler()
        {
        }

		/*
         * 
         * faz o request pro pokeapi passando os parametros recebidos (se nao tiver 18 limit)
		2.1) com o retorno ele faz um map para ter as urls dos pokesmons
		2.2) monta o seguinte objeto de retorno
		{
			id, // na propria url
			name, //name.language.name === 'en',
			welcomeDescription, // pokemonSpecieData.flavor_text_entries[pokemonFlavorTextIndex].flavor_text
			image, //https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/${id}.png
			genera, //genera.language.name === 'en',
			pokedexNumber, //
			baseExperience,
			types: {
				name,
				url
			},
			stats: {
				baseStat
				name
				url
			},
			height,
			weight,
			abilities: {
				name,
				url
			},
			genderRate,
			eggGroups {
				name,
				url
			}
		}
	3) retornar payload personalizado
		*/

        public static Pokemon ListPokemons(int limit, int offset)
        {
            return new Pokemon();
        }
    }
}
