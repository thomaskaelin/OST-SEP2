package testing;

public class MyClass {
    public void doLoop() {
        System.out.println("Before loop");

        for (int i = 1; i <= 3; i++) {
            System.out.println("In loop: " + i);
        }

        System.out.println("After loop");
    }
}
