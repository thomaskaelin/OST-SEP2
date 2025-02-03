package Ducks;

import Fly.RealFlyStrategy;
import Quack.DuckQuackStrategy;

public class RedheadDuck extends Duck {
    public RedheadDuck() {
        super(new DuckQuackStrategy(), new RealFlyStrategy());
    }

    @Override
    public void display() {
        System.out.println("Red head, gray body.");
    }
}
