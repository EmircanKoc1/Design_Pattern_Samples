namespace Behavioral.Visitor.Sample1;

public class Mage : CharacterBase
{
    public override double Health { get; set; } = 500;
    public override double MaxHealth => 500;
    public override double ImprovementFactor { get; set; } = 2;
    public override int Durability { get; set; } = 7;
}

