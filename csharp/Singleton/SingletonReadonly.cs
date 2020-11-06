namespace Singleton
{
    public class SingletonReadonly
    {
        private static readonly SingletonReadonly Instance = new SingletonReadonly();

        private SingletonReadonly()
        {
        }
        
        
    }
}