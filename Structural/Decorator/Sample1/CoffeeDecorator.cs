namespace Structural.Decorator.Sample1;

//Decorator
public class CoffeeDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    public CoffeeDecorator(ICoffee coffee)
        => _coffee = coffee;

    public virtual float GetCost()
        => _coffee.GetCost();

    public virtual string GetDescription()
        => _coffee.GetDescription();
}

