namespace BuilderBurgers.Burger;

public class Mayo : IIngredient
{
    public required decimal FatPercent { get; set; }
    public string Name => "Mayo";
    public string Unit => "ml";
    public required decimal Count { get; init; }

    public override string ToString()
    {
        return $"Mayo {FatPercent}% fat, {Count}{Unit}";
    }
}