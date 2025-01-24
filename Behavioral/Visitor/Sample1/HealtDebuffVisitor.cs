namespace Behavioral.Visitor.Sample1;

public class HealtDebuffVisitor : IVisitor
{
    public void Visit(ICharacter character)
    {
        if (character.ImprovementFactor > 0)
            character.ImprovementFactor -= 2;
    }
}

