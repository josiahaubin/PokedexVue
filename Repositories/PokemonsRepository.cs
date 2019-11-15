using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using pokedexvue.Models;

namespace pokedexvue.Repositories
{
  public class PokemonsRepository
  {
    private readonly IDbConnection _db;
    public PokemonsRepository(IDbConnection db)
    {
      _db = db;
    }
    public IEnumerable<Pokemon> Get()
    {
      string sql = "SELECT * FROM pokemon";
      return _db.Query<Pokemon>(sql);
    }

    public int Create(Pokemon newPokemon)
    {
      string sql = @"
        INSERT INTO pokemon
        (name, height, weight, img)
        VALUES
        (@Name, @Height, @Weight, @Img);
        SELECT LAST_INSERT_ID();
      ";
      return _db.ExecuteScalar<int>(sql, newPokemon);
    }
  }
}