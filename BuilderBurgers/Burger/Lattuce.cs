namespace BuilderBurgers.Burger;

public class Lattuce : IIngredient
{
    public string Name => "Lattuce";
    public string Unit => "pc";
    public required decimal Count { get; init; }

    public override string ToString()
    {
        return $"Lattuce, {Count}{Unit}";
    }
}