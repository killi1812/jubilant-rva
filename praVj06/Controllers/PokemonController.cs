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
        [HttpGet(Name = "getPokemon")]
        public IActionResult Get()
        {
            return Ok(pokemonService.GetPokemons());
        }

        [HttpGet(Name = "getPokemonByID")]
        public IActionResult Get(int id)
        {
            return Ok(pokemonService.GetPokemon(id));
        }
    }
}