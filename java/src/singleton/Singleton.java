package singleton;

public class Singleton {
    private static Singleton instance;

    public static Singleton getSingleton() {
        if (instance == null) {
            instance = new Singleton();
        }

        return instance;
    }

    private Singleton() {
    }
}
