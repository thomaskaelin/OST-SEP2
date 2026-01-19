package Calculator;

public final class Calculator implements ICalculator {
    public void calculate() {
        // Simulate a long-running operation by letting the thread sleep for some time
        try {
            Thread.sleep(2000);
        } catch (Exception e) {}

        System.out.println("Calculation completed");
    }
}
