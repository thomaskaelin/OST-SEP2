package Ducks;

import Fly.NoneFlyStrategy;
import Quack.RoboticQuackStrategy;

public class DecoyDuck extends Duck {
    public DecoyDuck() {
        super(new RoboticQuackStrategy(), new NoneFlyStrategy());
    }

    @Override
    public void display() {
        System.out.println("Looks like mallard duck, but made from metal.");
    }
}
