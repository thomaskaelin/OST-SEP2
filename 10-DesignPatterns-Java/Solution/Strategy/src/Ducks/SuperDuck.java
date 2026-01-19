package Ducks;

import Fly.IFlyStrategy;
import Quack.IQuackStrategy;

public class SuperDuck extends Duck {
    private final String _appearance;

    public SuperDuck(IQuackStrategy quackStrategy, IFlyStrategy flyStrategy, String appearance) {
        super(quackStrategy, flyStrategy);
        _appearance = appearance;
    }

    @Override
    public void display() {
        System.out.println(_appearance);
    }
}
