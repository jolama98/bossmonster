namespace bossmonster.Services;

public class HeroService
{
    private readonly HerosRepository _herosRepository;
    public HeroService(HerosRepository herosRepository)
    {
        _heroRepository = heroRepository;
    }

    internal List<Hero> GetAllHeros()
    {
        return _heroRepository.GetAllHeroes();
    }


}