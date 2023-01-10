namespace BuilderBurgers.Burger;

public class Bun : IIngredient
{
    public required string Position { get; set; }
    public string Name => "Bun";
    public string Unit => "pc";
    public required decimal Count { get; init; }

    public override string ToString()
    {
        return $"{Position} bun, {Count}{Unit}";
    }
}