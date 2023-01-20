import Calculator.Calculator;
import Decorators.*;

public class Program {
    public static void main(String[] args) {
        var calculator = new Calculator();
        var stopWatchCalculator = new StopWatchDecorator(calculator);
        var loggingCalculator = new LoggingDecorator(stopWatchCalculator);

        loggingCalculator.calculate();
    }
}
