package Decorators;

import Calculator.ICalculator;

import java.time.Duration;
import java.time.Instant;

public final class StopWatchDecorator implements ICalculator {
    private final ICalculator _decoratedCalculator;

    public StopWatchDecorator(ICalculator decoratedCalculator) {
        _decoratedCalculator = decoratedCalculator;
    }

    @Override
    public void calculate() {
        var starts = Instant.now();
        _decoratedCalculator.calculate();
        var ends = Instant.now();
        System.out.println(getClass().getName() + ": The decorated operation took " + Duration.between(starts, ends));
    }
}
