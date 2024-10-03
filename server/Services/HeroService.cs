namespace bossmonster.Services;

public class HeroesService
{
    private readonly HeroesRepository _heroesRepository;
    public HeroesService(HeroesRepository heroesRepository)
    {
        _heroesRepository = heroesRepository;
    }

    internal List<Hero> GetAllHeros()
    {
        return _heroesRepository.GetAllHeroes();
    }


}