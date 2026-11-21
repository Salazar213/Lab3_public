namespace Lab3.Core;


public sealed class Dice
{
    private static Dice? instance;

    private Random random = new();
    private Dice()
    {
    }
    public static Dice Instance => instance ??= new Dice();
    public void Reseed(int seed)
    {
        random = new Random(seed);
    }
    public int NextSeed()
    {
        return random.Next(1_000_000);
    }
    public int Roll(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    public bool Chance(double probability)
    {
        return random.NextDouble() < probability;
    }
    public T Pick<T>(IReadOnlyList<T> options)
    {
        return options[random.Next(options.Count)];
    }
}
