namespace Singleton
{
    public class SingletonMultiThread
    {
        private SingletonMultiThread()
        {
        }

        private static volatile SingletonMultiThread _instance;
        private static object lockHelper = new object();

        public static SingletonMultiThread Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockHelper)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonMultiThread();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}