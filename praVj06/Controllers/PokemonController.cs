using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace praVj06.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        [HttpGet(Name = "getPokemon")]
        public IEnumerable<ActionResult> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet(Name = "getPokemonByID")]
        public IEnumerable<ActionResult> Get(int id)
        {
            throw new NotImplementedException();
        }

    }
}
