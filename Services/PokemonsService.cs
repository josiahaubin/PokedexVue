using System;
using System.Collections.Generic;
using pokedexvue.Models;
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

    public IEnumerable<Pokemon> Get()
    {
      return _repo.Get();
    }

    public Pokemon Post(Pokemon newPokemon)
    {
      int id = _repo.Create(newPokemon);
      newPokemon.Id = id;
      return newPokemon;
    }

    public string Delete(int id)
    {
      _repo.Delete(id);
      return "Successfully Removed";
    }
  }
}