namespace Behavioral.Memento.Sample2;

public class CharacterState
{
    public CharacterState(CharacterType characterType, int health, int attackPower, double experiencePoints)
    {
        CharacterType = characterType;
        Health = health;
        AttackPower = attackPower;
        ExperiencePoints = experiencePoints;
    }

    public CharacterType CharacterType { get; }
    public int Health { get; }
    public int AttackPower { get; }
    public double ExperiencePoints { get; }
}
