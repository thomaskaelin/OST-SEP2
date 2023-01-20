package Ducks;

import Fly.RealFlyStrategy;
import Quack.DuckQuackStrategy;

public class MallardDuck extends Duck {
    public MallardDuck() {
        super(new DuckQuackStrategy(), new RealFlyStrategy());
    }

    @Override
    public void display() {
        System.out.println("Green head, gray-brown body.");
    }
}
