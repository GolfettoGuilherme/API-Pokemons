using System.Threading.Tasks;
using API_Pokemons.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Pokemons.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        [Route("index/{limit?}/{offset?}")]
        public async Task<IActionResult> IndexAsync(int limit = 0, int offset = 0)
        {
            if (limit == 0)
            {
                limit = 18;
            }

            var result = await PokeAPIService.GetPokemonsAsync(limit: limit, offset: offset);

            return Ok(result);
        }

        [HttpGet]
        [Route("evolution/{id}")]
        public async Task<IActionResult> IndexAsync(int id = 0)
        {
            return Ok();
        }
    }
}
