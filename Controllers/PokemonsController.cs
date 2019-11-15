using Microsoft.AspNetCore.Mvc;
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
  }
}