using BuilderBurgers.BurgerBuilder;

BurgerBuilder burgerBuilder = new BurgerBuilder("McDonald");

BurgerBuilderDirector burgerBuilderDirector = new BurgerBuilderDirector(burgerBuilder, "McDonald");

var burger = burgerBuilderDirector.BuildBigTasty();

Console.WriteLine();
Console.WriteLine(burger.ToString());