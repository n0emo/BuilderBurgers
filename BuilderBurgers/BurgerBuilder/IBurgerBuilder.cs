namespace BuilderBurgers.BurgerBuilder;

public interface IBurgerBuilder
{
    public IBurgerBuilder SetPrice(decimal price);
    public IBurgerBuilder SetSatiety(decimal satiety);
    public IBurgerBuilder SetRestaraunt();
    public IBurgerBuilder SetName(string name);
    public IBurgerBuilder AddBecon(decimal count);
    public IBurgerBuilder AddBun(decimal count, string position);
    public IBurgerBuilder AddCheese(decimal count, string kind);
    public IBurgerBuilder AddKetchup(decimal count);
    public IBurgerBuilder AddLattuce(decimal count);
    public IBurgerBuilder AddMayo(decimal count, decimal fatpercent);
    public IBurgerBuilder AddPickle(decimal count);
    public IBurgerBuilder AddPity(decimal count, string meat);
    public IBurgerBuilder AddTomato(decimal count);

    public Burger.Burger GetBurger();
}