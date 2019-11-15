using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pokedexvue.Models;
using pokedexvue.Services;

namespace pokedexvue.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PokemonsController : ControllerBase
  {
    private readonly PokemonsService _ps;
    public PokemonsController(PokemonsService ps)
    {
      _ps = ps;
    }

    [HttpGet] //NOTE GET ALL POKEMON
    public ActionResult<IEnumerable<Pokemon>> Get()
    {
      try
      {
        return Ok(_ps.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}