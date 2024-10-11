namespace bossmonster.Controllers;

[ApiController]
[Route("api/[controller]")]

public class BossController : ControllerBase
{
    private readonly Auth0Provider _auth0Provider;
    private readonly BossService _bossService;

    public BossController(Auth0Provider auth0Provider, BossService bossService)
    {
        _auth0Provider = auth0Provider;
        _bossService = bossService;
    }
    [HttpGet]
    public ActionResult<List<Boss>> GetAllBosses()
    {
        try
        {
            List<Boss> bosses = _bossService.GetAllBosses();
            return Ok(bosses);
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }

    [HttpGet("{bossId}")]
    public ActionResult<Boss> GetBossesById(int bossId)
    {
        try 
        {
        Boss boss = _bossService.GetBossesById(bossId);
        return Ok(boss);
        }
        catch (Exception exception)
        {
          return BadRequest(exception.Message);
        }
    }

}
