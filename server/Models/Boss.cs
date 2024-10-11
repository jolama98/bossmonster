namespace bossmonster.Models;

public class Boss : RepoItem<int>
{
    public string Name { get; set; }
    public string Img { get; set; }
    public int Damage { get; set; }
    public int Health { get; set; }
    public string CreatorId { get; set; }
    public Profile Creator { get; set; }

}
