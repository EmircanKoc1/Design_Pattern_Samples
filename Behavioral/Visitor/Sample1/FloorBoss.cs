namespace Behavioral.Visitor.Sample1;

public class FloorBoss : CharacterBase
{
    public override double Health { get; set; } = 4000;
    public override double MaxHealth => 4000;
    public override double ImprovementFactor { get; set; } = 10;
    public override int Durability { get; set; } = 50;

}

