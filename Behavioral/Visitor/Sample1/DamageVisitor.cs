namespace Behavioral.Visitor.Sample1;

public class DamageVisitor : IVisitor
{
    public void Visit(ICharacter character)
    {
        var calculatedDamage = 200 - (character.Durability * 1.5D);

        var characterCurrentHealth = character.Health -= calculatedDamage;

        if (characterCurrentHealth < 0)
            character.Health = 0;
        else
            character.Health = characterCurrentHealth;
    }
}

