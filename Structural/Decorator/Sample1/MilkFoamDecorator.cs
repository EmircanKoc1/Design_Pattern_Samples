namespace Structural.Decorator.Sample1;
//Concrete Decorator
public class CoffeeMilkFoamDecorator : CoffeeDecorator
{
    public CoffeeMilkFoamDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
       => base.GetDescription() + " + Milk Foam => Macchiato";

    public override float GetCost()
        => base.GetCost() + 2F;
}

