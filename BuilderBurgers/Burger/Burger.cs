using System.Text;

namespace BuilderBurgers.Burger;

public class Burger
{
    public string? Name { get; set; }
    public required List<IIngredient> Ingredients { get; set; }
    public decimal? Priсe { get; set; }
    public decimal? Satiety { get; set; }
    public string? Restaraunt { get; set; }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        if (Restaraunt is not null)
        {
            stringBuilder.Append($"{Restaraunt}'s ");
        }
        
        stringBuilder.Append(Name ?? "burger");
        if (Priсe is not null)
        {
            stringBuilder.Append($" for ${Priсe}");
        }
        
        stringBuilder.Append("\n\nIngredients:\n");

        foreach (var ingredient in Ingredients)
        {
            stringBuilder.Append($"{ingredient.ToString()};\n");
        }

        if (Satiety is not null)
        {
            stringBuilder.Append($"\nSatiety: {Satiety}kkal");
        }

        return stringBuilder.ToString();
    }
}