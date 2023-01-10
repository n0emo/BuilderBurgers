namespace BuilderBurgers.Burger;

public interface IIngredient
{
    public string Name { get; }
    public string Unit { get; }
    public decimal Count { get; init; }

    public string ToString();
}