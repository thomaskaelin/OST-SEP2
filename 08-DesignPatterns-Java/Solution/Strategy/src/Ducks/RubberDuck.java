package Ducks;

import Fly.NoneFlyStrategy;
import Quack.SqueakQuackStrategy;

public class RubberDuck extends Duck {
    public RubberDuck() {
        super(new SqueakQuackStrategy(), new NoneFlyStrategy());
    }

    @Override
    public void display() {
        System.out.println("All yellow, made from rubber.");
    }
}
