import java.util.ArrayList;
import java.util.List;

public class WeatherData extends WeatherAPI {
    private final List<IView> _observer = new ArrayList<>();

    public void Attach(IView view) {
        _observer.add(view);
    }

    public void Detach(IView view) {
        _observer.remove(view);
    }

    @Override
    protected void measurementChanged() {
        var temperature = getTemperature();
        var humidity = getHumidity();
        var windSpeed = getWindSpeed();
        var rainProbability = getRainProbability();

        for(var observer : _observer)
            observer.update(temperature, humidity, windSpeed, rainProbability);
    }
}