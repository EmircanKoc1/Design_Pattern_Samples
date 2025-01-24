namespace Behavioral.Visitor.Sample1;

public interface ICharacter : IVisitable
{
    double Health { get; set; }
    double MaxHealth { get; }
    double ImprovementFactor { get; set; }
    int Durability { get; set; }
}

