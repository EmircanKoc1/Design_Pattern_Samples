namespace Behavioral.Visitor.Sample1;

public class HealthVisitor : IVisitor
{
    public void Visit(ICharacter character)
    {
        var calculatedHealthScore = character.ImprovementFactor * 30;
        var totalCurrentHealth = character.Health + calculatedHealthScore;

        if (character.MaxHealth < totalCurrentHealth)
            character.Health = character.MaxHealth;
        else
            character.Health = totalCurrentHealth;

    }
}

