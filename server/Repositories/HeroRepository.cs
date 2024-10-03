
namespace bossmonster.Repositories;
public class HeroesRepository
{
    private readonly IDbConnection _db;

    public HeroesRepository(IDbConnection db)
    {
        _db = db;
    }

    internal List<Hero> GetAllHeroes()
    {
        string sql = "SELECT * FROM heroes;";
        return _db.Query<Hero>(sql).ToList();
    }
}