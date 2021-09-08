using System;
using System.Net.Http;
using System.Threading.Tasks;
using API_Pokemons.Model;
using Newtonsoft.Json;

namespace API_Pokemons.Service
{
    public class PokeAPIService
    {
        public PokeAPIService()
        {

        }

        public static async Task<PokeAPIResponse> GetPokemonsAsync(int limit, int offset)
        {
            HttpClient client = new HttpClient();

            var result = await client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon?limit={limit}&offset={offset}");

            PokeAPIResponse response = JsonConvert.DeserializeObject<PokeAPIResponse>(result);

            return response;
        }
    }
}
