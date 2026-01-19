package Quack;

import Turkeys.Turkey;

public final class TurkeyQuackStrategy implements IQuackStrategy {
    private final Turkeys.Turkey _turkey;

    public TurkeyQuackStrategy(Turkey turkey) {
        _turkey = turkey;
    }

    @Override
    public void quack() {
        _turkey.gobble();
    }
}
