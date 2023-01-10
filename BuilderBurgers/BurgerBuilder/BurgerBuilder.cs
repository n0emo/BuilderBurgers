using BuilderBurgers.Burger;

namespace BuilderBurgers.BurgerBuilder;

public class BurgerBuilder : IBurgerBuilder
{
    private Burger.Burger _burger;
    private string _restaraunt;

    public BurgerBuilder(string restaraunt)
    {
        _restaraunt = restaraunt;
        _burger = new Burger.Burger
        {
            Ingredients = new List<IIngredient>()
        };
    }

    public IBurgerBuilder SetPrice(decimal price)
    {
        _burger.Priсe = price;
        return this;
    }

    public IBurgerBuilder SetSatiety(decimal satiety)
    {
        _burger.Satiety = satiety;
        return this;
    }

    public IBurgerBuilder SetRestaraunt()
    {
        _burger.Restaraunt = _restaraunt;
        return this;
    }

    public IBurgerBuilder SetName(string name)
    {
        _burger.Name = name;
        return this;
    }


    public IBurgerBuilder AddBecon(decimal count)
    {
        _burger.Ingredients.Add(new Becon
        {
            Count = count
        });
        return this;
    }

    public IBurgerBuilder AddBun(decimal count, string position)
    {
        _burger.Ingredients.Add(new Bun
        {
            Count = count,
            Position = position
        });
        return this;
    }

    public IBurgerBuilder AddCheese(decimal count, string kind)
    {
        _burger.Ingredients.Add(new Cheese
        {
            Count = count,
            Kind = kind
        });
        return this;
    }

    public IBurgerBuilder AddKetchup(decimal count)
    {
        _burger.Ingredients.Add(new Ketchup
        {
            Count = count
        });
        return this;
    }

    public IBurgerBuilder AddLattuce(decimal count)
    {
        _burger.Ingredients.Add(new Lattuce
        {
            Count = count
        });
        return this;
    }

    public IBurgerBuilder AddMayo(decimal count, decimal fatpercent)
    {
        _burger.Ingredients.Add(new Mayo
        {
            Count = count,
            FatPercent = fatpercent
        });
        return this;
    }

    public IBurgerBuilder AddPickle(decimal count)
    {
        _burger.Ingredients.Add(new Picke
        {
            Count = count
        });
        return this;
    }

    public IBurgerBuilder AddPity(decimal count, string meat)
    {
        _burger.Ingredients.Add(new Pity
        {
            Count = count,
            Meat = meat
        });
        return this;
    }

    public IBurgerBuilder AddTomato(decimal count)
    {
        _burger.Ingredients.Add(new Tomato
        {
            Count = count
        });
        return this;
    }

    public Burger.Burger GetBurger()
    {
        var burger = _burger;
        _burger = new Burger.Burger
        {
            Ingredients = new List<IIngredient>()
        };
        return burger;
    }

    private static void Alert()
    {
        Console.WriteLine("Create new burger first");
    }
}