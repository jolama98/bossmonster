
namespace bossmonster.Services;

public class HeroesService
{
    private readonly HeroesRepository _heroesRepository;
    public HeroesService(HeroesRepository heroesRepository)
    {
        _heroesRepository = heroesRepository;
    }

    internal string DestroyHero(int heroId, string userId)
    {

        Hero hero = GetHerosById(heroId);
        if (hero.CreatorId != userId)
        {
            throw new Exception("YOU DID NOT CREATE THIS KEEP 'KEEP' AWAY");
        }
        _heroesRepository.DestroyHero(heroId);

        return "Hero was DELETED!";
    }



    internal List<Hero> GetAllHeros()
    {
        return _heroesRepository.GetAllHeroes();
    }

    public Hero GetHerosById(int heroId)
    {
        Hero hero = _heroesRepository.GetHerosById(heroId);
        if (hero == null)
        {
            throw new Exception($"No Hero found with the Id of {heroId}");
        }
        return hero;
    }

    internal Hero CreateHero(Hero heroData)
    {
        Hero hero = _heroesRepository.CreateHero(heroData);
        return hero;
    }
}