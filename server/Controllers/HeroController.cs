namespace bossmonster.Controllers;

[ApiController]
[Route("api/[controller]")]

public class HeroesController : ControllerBase
{

    private readonly Auth0Provider _auth0Provider;
    private readonly HeroesService _heroesService;
    public HeroesController(HeroesService heroesService, Auth0Provider auth0Provider)
    {
        _heroesService = heroesService;
        _auth0Provider = auth0Provider;
    }
    [HttpGet]
    public ActionResult<List<Hero>> GetAllHero()
    {
        try
        {
            List<Hero> heros = _heroesService.GetAllHeros();
            return Ok(heros);

        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }

}