package Ducks;

import Fly.IFlyStrategy;
import Quack.IQuackStrategy;

public abstract class Duck {
    private final IQuackStrategy _quackStrategy;
    private final IFlyStrategy _flyStrategy;

    protected Duck(IQuackStrategy quackStrategy, IFlyStrategy flyStrategy)
    {
        _quackStrategy = quackStrategy;
        _flyStrategy = flyStrategy;
    }

    public void quack() {
        _quackStrategy.quack();
    }

    public void swim() {
        System.out.println("Swimming.");
    }

    public void fly() {
        _flyStrategy.fly();
    }

    public abstract void display();
}
