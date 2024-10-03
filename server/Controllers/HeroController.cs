namespace bossmonster.Controllers;

[ApiController]
[Route("api/[controller]")]

public class HerosController : ControllerBase
{

    private readonly Auth0Provider _auth0Provider;
    private readonly HeroService _heroService;
    public HerosController(HerosService herosService, Auth0Provider auth0Provider)
    {
        _heroService = heroService;
        _auth0Provider = auth0Provider;
    }
    [HttpGet]
    public ActionResult<List<Hero>> GetAllHero()
    {
        try
        {
            List<Hero> heros = _herosService.GetAllHeros();
            return Ok(heros);

        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }

}