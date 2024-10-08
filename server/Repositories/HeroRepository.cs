


namespace bossmonster.Repositories;
public class HeroesRepository
{
    private readonly IDbConnection _db;

    public HeroesRepository(IDbConnection db)
    {
        _db = db;
    }

    internal Hero CreateHero(Hero heroData)
    {
        string sql = @"
        INSERT INTO
        heroes( name, img, type, damage, health, creatorId)
        VALUES( @name, @img, @type, @damage, @health, @creatorId);

        SELECT
        heroes.*,
        accounts.*
        FROM heroes
        JOIN accounts ON accounts.id = heroes.creatorId
        WHERE heroes.id = LAST_INSERT_ID();";
        Hero hero = _db.Query<Hero, Profile, Hero>(sql, JoinCreator, heroData).FirstOrDefault();
        return hero;

    }

    internal void DestroyHero(int heroId)
    {
        string sql = "DELETE FROM heroes WHERE id = @heroId LIMIT 1";

        int rowsAffected = _db.Execute(sql, new { heroId });

        if (rowsAffected == 0) throw new Exception("DELETE FAILED");
        if (rowsAffected > 1) throw new Exception("DELETE WAS OVER POWERED!!!!!!!");

    }

    internal List<Hero> GetAllHeroes()
    {
        string sql = "SELECT * FROM heroes;";
        return _db.Query<Hero>(sql).ToList();
    }

    internal Hero GetHerosById(int heroId)
    {
        string sql = @"
        SELECT
        heroes.*,
        accounts.*
        FROM heroes
        JOIN accounts ON accounts.id = heroes.creatorId
        WHERE heroes.id = @heroId;";

        Hero hero = _db.Query<Hero, Profile, Hero>(sql, (hero, account) =>
        {
            hero.Creator = account;
            return hero;
        }, new { heroId }).FirstOrDefault();
        return hero;
    }



    private Hero JoinCreator(Hero hero, Profile profile)
    {
        hero.Creator = profile;
        return hero;
    }
}
