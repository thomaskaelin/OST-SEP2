public final class RubberDuck extends Duck {
    @Override
    public void quack() {
        System.out.println("Squeak squeak!");
    }

    @Override
    public void display() {
        System.out.println("All yellow, made from rubber.");
    }

    @Override
    public  void fly() {
        System.out.println("Can not fly, not real.");
    }
}