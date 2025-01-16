namespace Structural.Decorator.Sample1;

//Concrete Component
public class Coffee : ICoffee
{
    public float GetCost()
        => 11.2F;

    public string GetDescription()
        => "Espresso";

}

