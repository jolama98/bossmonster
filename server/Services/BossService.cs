

namespace bossmonster.Services;

public class BossService
{

    private readonly BossRepository _bossRepository;

    public BossService(BossRepository bossRepository)
    {
        _bossRepository = bossRepository;
    }

    internal List<Boss> GetAllBosses()
    {
        return _bossRepository.GetAllBosses();
    }

    public Boss GetBossesById(int bossId)
    {
        Boss boss = _bossRepository.GetBossesById(bossId);
        if (boss == null)
        {
            throw new Exception($"No Boss found with the Id of {bossId}");
        }
        return boss;
    }
}
