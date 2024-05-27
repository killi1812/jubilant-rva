using praVj06.Dtos;

namespace praVj06.Services
{
    public interface IPokemonService
    {
        public PokemonDto GetPokemon(int id);
        public List<PokemonDto> GetPokemons();
    }
    public class PokemonService : IPokemonService
    {
        private static readonly List<PokemonDto> pokemons = new List<PokemonDto>(
            new PokemonDto[] {
                new PokemonDto
                {
                    Id = 1,
                    Name = "Arcanine",
                    Type = "Fire",
                    Level = 30,
                },
                new PokemonDto
                {
                    Id = 2,
                    Name = "Furret",
                    Type = "Normal",
                    Level = 4,
                },
                new PokemonDto
                {
                    Id = 3,
                    Name = "Growlith",
                    Type = "Fire",
                    Level = 15,
                },
            });

        public PokemonDto GetPokemon(int id)
        {
            return pokemons.FirstOrDefault(p => p.Id == id);
        }

        public List<PokemonDto> GetPokemons()
        {
            return pokemons;
        }
    }
}
