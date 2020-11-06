namespace Singleton
{
    public class Singleton
    {
        private Singleton()
        {
        }

        private static Singleton _instance;

        public static Singleton Instance
        {
            get { return _instance ??= new Singleton(); }
        }
    }
}