import java.util.Random;
import java.util.Timer;
import java.util.TimerTask;

public abstract class WeatherAPI {
    protected WeatherAPI() {
        createTimer();
    }

    protected abstract void measurementChanged();

    protected float getTemperature() {
        return _currentTemperature;
    };

    protected float getHumidity() {
        return _currentHumidity;
    }

    protected float getWindSpeed() {
        return _currentWindSpeed;
    }

    protected float getRainProbability() {
        return _currentRainProbability;
    }

    public void start() {
        createTimer();
    }

    //region Private Implementation

    private final Random _random = new Random();
    private Timer _timer;
    private float _currentTemperature = 18.0f;
    private float _currentHumidity = 30.0f;
    private float _currentWindSpeed = 5.0f;
    private float _currentRainProbability = 10.0f;

    private void createTimer()
    {
        _timer = new Timer();
        _timer.schedule(new TimerTask() {
            @Override
            public void run() {
                _currentTemperature = getUpdatedValue(_currentTemperature, -20, 40);
                _currentHumidity = getUpdatedValue(_currentHumidity, 0, 100);
                _currentWindSpeed = getUpdatedValue(_currentWindSpeed, 0, 80);
                _currentRainProbability = getUpdatedValue(_currentRainProbability, 0, 100);

                measurementChanged();
            }
        }, 1000, 1000);
    }

    private float getUpdatedValue(float currentValue, int lowerBoundary, int upperBoundary)
    {
        var random = _random.nextBoolean();
        var modification = random ? +1 : -1;
        var updatedValue = currentValue + modification;

        if (updatedValue < lowerBoundary)
            updatedValue = lowerBoundary;

        if (updatedValue > upperBoundary)
            updatedValue = upperBoundary;

        return updatedValue;
    }

    //endregion
}
