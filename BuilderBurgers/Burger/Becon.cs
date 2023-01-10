namespace BuilderBurgers.Burger;

public class Becon : IIngredient
{
    public string Name => "Becon";
    public string Unit => "gr";
    public required decimal Count { get; init; }

    public override string ToString()
    {
        return $"Fresh becon! {Count}{Unit}";
    }
}