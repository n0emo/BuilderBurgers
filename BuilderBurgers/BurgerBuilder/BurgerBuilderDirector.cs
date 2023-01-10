namespace BuilderBurgers.BurgerBuilder;

public class BurgerBuilderDirector
{
    private BurgerBuilder _burgerBuilder;

    public BurgerBuilderDirector(BurgerBuilder burgerBuilder, string restaraunt)
    {
        _burgerBuilder = new BurgerBuilder(restaraunt);
    }

    public Burger.Burger BuildBigTasty()
    {
        return _burgerBuilder
            .SetName("Big Tasty")
            .SetPrice(2.99m)
            .SetSatiety(812)
            .SetRestaraunt()
            .AddBun(1, "up")
            .AddMayo(50, 10)
            .AddLattuce(1)
            .AddTomato(3)
            .AddCheese(20, "Chedder")
            .AddPity(200, "pork")
            .AddCheese(40, "Chedder")
            .AddBun(1, "down")
            .GetBurger();
    }
}