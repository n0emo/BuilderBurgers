namespace BuilderBurgers.Burger;

public class Picke : IIngredient
{
    public string Name => "Picle";
    public string Unit => "pc";
    public required decimal Count { get; init; }

    public override string ToString()
    {
        return $"Pickle, {Count}{Unit}";
    }
}