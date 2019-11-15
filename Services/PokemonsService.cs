using pokedexvue.Repositories;

namespace pokedexvue.Services
{
  public class PokemonsService
  {
    private readonly PokemonsRepository _repo;
    public PokemonsService(PokemonsRepository repo)
    {
      _repo = repo;
    }
  }
}