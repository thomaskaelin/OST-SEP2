package testing.tests;

import static org.junit.jupiter.api.Assertions.fail;
import org.junit.jupiter.api.Test;
import testing.MyClass;

class MyClassTests {
    private final MyClass testee = new MyClass();

    @Test
    void doLoop_LogsMessages() {
        testee.doLoop();

        fail("Exercise 1: Verify all messages logged by MyClass.doLoop()");
    }

}
