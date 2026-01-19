public final class DecoyDuck extends Duck {
    @Override
    public void quack() {
        System.out.println("Robotic quack quack!");
    }

    @Override
    public void display() {
        System.out.println("Looks like mallard duck, but made from metal.");
    }

    @Override
    public  void fly() {
        System.out.println("Can not fly, not real.");
    }
}