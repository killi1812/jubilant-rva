using praVj06.Services;

namespace PokemonTest
{
    public class PokemonServiceTest
    {
        [Fact]
        public void GetPokemons_ShoudlrRetrunValidList()
        {
            //Arrange

            IPokemonService service = new PokemonService();

            //Act
            var list = service.GetPokemons();

            //Assert

            Assert.NotEqual(0,list.Count);
        }

        [Fact]
        public void GetPokemonByID_ShouldReturnCorrectPokemon()
        {
            //Arrange

            int id = 1;
            IPokemonService service = new PokemonService();

            //Act

            var pokemon = service.GetPokemon(1);

            //Assert
            Assert.Equal(id,pokemon.Id);
        }
    }
}