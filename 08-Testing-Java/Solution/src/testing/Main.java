package testing;

public class Main {
    public static void main(String[] args) {
        ConsoleLogger consoleLogger = new ConsoleLogger();
        MyClass myClass = new MyClass(consoleLogger);
        myClass.doLoop();
    }
}

