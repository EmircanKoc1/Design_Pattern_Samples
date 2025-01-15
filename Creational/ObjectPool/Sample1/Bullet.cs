namespace Creational.ObjectPool.Sample1
{
    public class Bullet
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public float Damage { get; set; }
        public string? MM { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            return $"Bullet details : " +
                $"Id: {Id} " +
                $"Damage : {Damage} " +
                $"MM: {MM} " +
                $"Weight {Weight}";

        }

    }
}
