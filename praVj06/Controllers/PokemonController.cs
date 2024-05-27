using Microsoft.AspNetCore.Mvc;
using praVj06.Services;

namespace praVj06.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService pokemonService;
        public PokemonController(IPokemonService pokemonService)
        {
            this.pokemonService = pokemonService;
        }
        [HttpGet("[action]")]
        public IActionResult GetAllPokemons()
        {
            return Ok(pokemonService.GetPokemons());
        }

        [HttpGet("[action]")]
        public IActionResult GetPokemon(int id)
        {
            return Ok(pokemonService.GetPokemon(id));
        }
    }
}