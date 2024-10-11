



namespace bossmonster.Repositories;

public class BossRepository
{
    private readonly IDbConnection _db;

    public BossRepository(IDbConnection db)
    {
        _db = db;
    }

    internal List<Boss> GetAllBosses()
    {
        string sql = "SELECT * FROM boss;";
        return _db.Query<Boss>(sql).ToList();
    }

    public Boss GetBossesById(int bossId)
    {
        string sql = @"
        SELECT
        boss.*,
        accounts.*
        FROM boss
        JOIN accounts ON accounts.id = boss.creatorId
        WHERE boss.id = @bossId;";

        Boss boss = _db.Query<Boss, Profile, Boss>(sql, (boss, account) =>
        {
            boss.Creator = account;
            return boss;
        }, new {bossId}).FirstOrDefault();
        return boss;
    }
}
