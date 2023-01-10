namespace BuilderBurgers.Burger;

public class Pity : IIngredient
{
    public required string Meat { get; init; }
    public string Name => "Pity";
    public string Unit => "gr";
    public required decimal Count { get; init; }

    public override string ToString()
    {
        return $"{Meat} pity, {Count}{Unit}";
    }
}