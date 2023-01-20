package Quack;

public final class HumanQuackStrategy implements IQuackStrategy  {
    public void quack() {
        System.out.println("Hi there, I am able to speak!");
    }
}