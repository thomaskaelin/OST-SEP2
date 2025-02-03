package Fly;

public final class NoneFlyStrategy implements IFlyStrategy {
    public void fly()  {
        System.out.println("Can not fly, not real.");
    }
}