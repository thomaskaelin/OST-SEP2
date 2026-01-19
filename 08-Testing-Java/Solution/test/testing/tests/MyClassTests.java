package testing.tests;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;
import testing.MyClass;

class MyClassTests {

    private MyClass testee;
    private FakeLogger fakeLogger;

    @BeforeEach
    void init() {
        fakeLogger = new FakeLogger();
        testee = new MyClass(fakeLogger);
    }

    @Test
    void doLoop_LogsMessages() {
        testee.doLoop();

        Assertions.assertArrayEquals(new String[] {
                "Before loop",
                        "In loop: 1",
                        "In loop: 2",
                        "In loop: 3",
                        "After loop"},
                fakeLogger.getLoggedMessages());
    }
}
