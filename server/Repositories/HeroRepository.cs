
namespace bossmonster.Repositories;
public class HerosRepository
{
    private readonly IDbConnection _db;

    public HerosRepository(IDbConnection db)
    {
        _db = db;
    }

    internal List<Hero> GetAllHeroes()
    {
        string sql = "SELECT * FROM heroes;";
        return _db.Query<Hero>(sql).ToList();
    }
}