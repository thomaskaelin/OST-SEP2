public class WeatherData extends WeatherAPI {
    private final IView _view1, _view2, _view3;

    public WeatherData() {
        _view1 = new ConsoleView(1);
        _view2 = new ConsoleView(2);
        _view3 = new ConsoleView(3);
    }

    @Override
    protected  void measurementChanged() {
        var temperature = getTemperature();
        var humidity = getHumidity();
        var windSpeed = getWindSpeed();

        _view1.update(temperature, humidity, windSpeed);
        _view2.update(temperature, humidity, windSpeed);
        _view3.update(temperature, humidity, windSpeed);
    }
}