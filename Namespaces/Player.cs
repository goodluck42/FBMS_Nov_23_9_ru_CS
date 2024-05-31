namespace Namespaces;

public class Player
{
    public Player()
    {
        var service = new GameService();
    }
    public int Hp { get; set; }
    public int Stamina { get; set; }
}