public class HealthPotion
{
    public int healAmount = 10;
    public void Consume(player) 
    {
        player.Heal(healAmount);
    }
}


public class CollectibleDot
{
    public int pointValue = 10;

    public void Collect(player) 
    {
        player.AddScore(pointValue);
    }
}