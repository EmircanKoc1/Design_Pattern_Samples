namespace Creational.ObjectPool.Sample1
{
    public class BulletPool
    {

        private readonly Bullet[] _bullets;
        private int currentIndex = 0;

        public BulletPool(int bulletCount)
        {

            _bullets = new Bullet[bulletCount];

            for (int i = 0; i < bulletCount; i++)
                _bullets[i] = new Bullet();

        }


        public Bullet? GetBullet()
        {
            if (currentIndex < _bullets.Length)
            {
                return _bullets[currentIndex++];
            }

            return null;
        }

        public void ReturnBullet(Bullet bullet)
        {
            if (currentIndex > 0)
            {
                _bullets[--currentIndex] = bullet;
            }
            else
            {
                Console.WriteLine("Bullet pool is already empty");
            }

        }


    }
}
