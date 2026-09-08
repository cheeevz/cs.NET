public class Player
{
    Random rand = new Random();

    public int RollDie()
    {
        return rand.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        return rand.NextDouble() * 99.9;
    }
}
