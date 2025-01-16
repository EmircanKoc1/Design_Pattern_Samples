namespace Structural.Decorator.Sample1;

//Concrete Decorator
public class CoffeeMilkDecorator : CoffeeDecorator
{
    public CoffeeMilkDecorator(ICoffee coffee) : base(coffee)
    {
    }


    public override string GetDescription()
        => base.GetDescription() + " + Milk => Flat White";

    public override float GetCost()
        => base.GetCost() + 3.22F;

}

