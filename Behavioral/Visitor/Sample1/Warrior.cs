namespace Behavioral.Visitor.Sample1;

public class Warrior : CharacterBase
{
    public override double Health { get; set; } = 1000;
    public override double MaxHealth => 1000;
    public override double ImprovementFactor { get; set; } = 3;
    public override int Durability { get; set; } = 10;
}

