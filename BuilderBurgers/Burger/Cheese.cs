namespace BuilderBurgers.Burger;

public class Cheese : IIngredient
{
    public required string Kind { get; init; }
    public string Name => "Cheese";
    public string Unit => "gr";
    public required decimal Count { get; init; }

    public override string ToString()
    {
        return $"{Kind} cheese, {Count}{Unit}";
    }
}