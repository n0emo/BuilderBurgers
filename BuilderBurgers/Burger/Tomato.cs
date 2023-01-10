namespace BuilderBurgers.Burger;

public class Tomato : IIngredient
{
    public string Name => "Tomato";
    public string Unit => "pc";
    public required decimal Count { get; init; }

    public override string ToString()
    {
        return $"Tomato, {Count}{Unit}";
    }
}