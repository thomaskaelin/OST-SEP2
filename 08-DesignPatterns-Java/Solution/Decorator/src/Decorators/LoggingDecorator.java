package Decorators;

import Calculator.ICalculator;

public final class LoggingDecorator implements ICalculator {
    private final ICalculator _decoratedCalculator;

    public LoggingDecorator(ICalculator decoratedCalculator) {
        _decoratedCalculator = decoratedCalculator;
    }

    @Override
    public void calculate() {
        System.out.println(getClass().getName() + ": Before calling the decorated object");
        _decoratedCalculator.calculate();
        System.out.println(getClass().getName() + ": After calling the decorated object");
    }
}
