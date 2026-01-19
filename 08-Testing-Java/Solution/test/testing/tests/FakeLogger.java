package testing.tests;

import testing.ILogger;

import java.util.ArrayList;

public final class FakeLogger implements ILogger {
    private final ArrayList<String> loggedMessages = new ArrayList<>();

    @Override
    public void log(String message) {
        loggedMessages.add(message);
    }

    public String[] getLoggedMessages() {
        return loggedMessages.toArray(String[]::new);
    }
}
