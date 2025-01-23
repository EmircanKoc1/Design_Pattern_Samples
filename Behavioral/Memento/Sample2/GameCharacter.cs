namespace Behavioral.Memento.Sample2;

public class GameCharacter
{
    public CharacterType CharacterType { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public double ExperiencePoints { get; set; }

    public CharacterState Save()
    {
        return new CharacterState(CharacterType, Health, AttackPower, ExperiencePoints);
    }

    public void RestoreCharacter(CharacterState? characterState)
    {
        if (characterState is not null)
        {
            CharacterType = characterState.CharacterType;
            Health = characterState.Health;
            AttackPower = characterState.AttackPower;
            ExperiencePoints = characterState.ExperiencePoints;
        }
        else
            Console.WriteLine("The character state is null");

    }

    public override string ToString()
    {
        return $""" 
            Character Details
            character type :  {CharacterType}
            character health :  {Health}
            character attac kpower :  {AttackPower}
            character XP :  {ExperiencePoints}
            """;
    }
}
