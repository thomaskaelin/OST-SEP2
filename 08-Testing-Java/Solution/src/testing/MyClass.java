package testing;

public class MyClass {
    private final ILogger logger;

    public MyClass(ILogger logger) {
        this.logger = logger;
    }

    public void doLoop() {
        logger.log("Before loop");

        for (int i = 1; i <= 3; i++) {
            logger.log("In loop: " + i);
        }

        logger.log("After loop");
    }
}
