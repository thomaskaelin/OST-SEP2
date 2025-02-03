package Ducks;

import Fly.TurkeyFlyStrategy;
import Quack.TurkeyQuackStrategy;

public class TurkeyAdapter extends Duck {
    private final Turkeys.Turkey _turkey;

    public TurkeyAdapter(Turkeys.Turkey turkey) {
        super(new TurkeyQuackStrategy(turkey), new TurkeyFlyStrategy(turkey));
        _turkey = turkey;
    }

    @Override
    public void swim() {
        _turkey.swim();
    }

    @Override
    public void display() {
        System.out.println("I am a Turkey hiding at the Duck Pond.");
    }
}
