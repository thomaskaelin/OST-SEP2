package Fly;

import Turkeys.Turkey;

public final class TurkeyFlyStrategy implements IFlyStrategy {
    private final Turkeys.Turkey _turkey;

    public TurkeyFlyStrategy(Turkey turkey) {
        _turkey = turkey;
    }

    @Override
    public void fly() {
            for (var i = 1; i <= 5; i++)
                _turkey.flutter();
    }
}
