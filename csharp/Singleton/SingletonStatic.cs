namespace Singleton
{
    public class SingletonStatic
    {
        public static readonly SingletonStatic Instance;

        static SingletonStatic()
        {
            Instance = new SingletonStatic();
        }

        private SingletonStatic()
        {
        }
    }
}