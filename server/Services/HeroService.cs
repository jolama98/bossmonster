namespace bossmonstervuedotnet.Services;

public class HeroService
{
    private readonly HeroRepository _heroRepository;
    public HeroService(HeroRepository heroRepository)
    {
        _heroRepository = heroRepository;
    }

    internal List<Hero> GetAllHeros()
    {
        return _heroRepository.GetAllHeroes();
    }


}