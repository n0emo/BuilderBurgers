namespace BuilderBurgers.Burger;

public class Ketchup : IIngredient
{
    public string Name => "Ketchup";
    public string Unit => "ml";
    public required decimal Count { get; init; }

    public override string ToString()
    {
        return $"Ketchup, {Count}{Unit}";
    }
}