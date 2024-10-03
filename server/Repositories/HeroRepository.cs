
namespace bossmonstervuedotnet.Repositories;
public class HeroRepository
{
    private readonly IDbConnection _db;

    public HeroRepository(IDbConnection db)
    {
        _db = db;
    }

    internal List<Hero> GetAllHeroes()
    {
        string sql = "SELECT * FROM heroes;";
        return _db.Query<Hero>(sql).ToList();
    }
}