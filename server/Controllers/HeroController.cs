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

    [HttpGet("{heroId}")]
    public ActionResult<Hero> GetHerosById(int heroId)
    {
        try
        {
            // Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
            Hero hero = _heroesService.GetHerosById(heroId);
            return Ok(hero);
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }


    [Authorize]
    [HttpDelete("{heroId}")]
    public async Task<ActionResult<string>> DestroyHero(int heroId)
    {
        try
        {
            Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
            string message = _heroesService.DestroyHero(heroId, userInfo.Id);
            return Ok(message);
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }

    [Authorize]
    [HttpPost]
    public async Task<ActionResult<Hero>> CreateHero([FromBody] Hero heroData)
    {
        try
        {
            Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
            heroData.CreatorId = userInfo.Id;
            Hero hero = _heroesService.CreateHero(heroData);
            return Ok(hero);
        }
        catch (Exception exception)
        {
          return BadRequest(exception.Message);
        }
    }

}