public class Program {
    public static void main(String[] args) {
        var weatherData = new WeatherData();

        weatherData.Attach(new ConsoleView(1));
        weatherData.Attach(new ConsoleView(2));
        weatherData.Attach(new ConsoleView(3));
        weatherData.Attach(new DebugView(1));

        weatherData.start();
    }
}
