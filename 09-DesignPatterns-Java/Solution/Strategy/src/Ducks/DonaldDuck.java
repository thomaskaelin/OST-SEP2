package Ducks;

import Fly.NoneFlyStrategy;
import Quack.HumanQuackStrategy;

public class DonaldDuck extends Duck {
    public DonaldDuck() {
        super(new HumanQuackStrategy(), new NoneFlyStrategy());
    }

    @Override
    public void display() {
        System.out.println("Looks like taken from a comic book.");
    }
}
