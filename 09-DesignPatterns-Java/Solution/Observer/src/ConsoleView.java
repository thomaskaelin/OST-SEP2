public class ConsoleView implements IView {
    private final int _id;

    public ConsoleView(int id) {
        _id = id;
    }

    public void update(float temperature, float humidity, float windSpeed, float rainProbability) {
        System.out.println("View #" + _id + " | Temperature: " + temperature + " C° | Humidity: " + humidity + " % | Windspeed: " + windSpeed + " m/s | Rain Probability: " + rainProbability + "%");
    }
}