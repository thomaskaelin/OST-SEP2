public class DebugView implements IView {
    private final int _id;

    public DebugView(int id)
    {
        _id = id;
    }

    @Override
    public void update(float temperature, float humidity, float windSpeed, float rainProbability) {
        // AFAIK there is no Debug-PrintStream in Java. But I am not an expert in Java... :-)
        System.out.println("DEBUG | View #" + _id + " | Temperature: " + temperature + " C° | Humidity: " + humidity + " % | Windspeed: " + windSpeed + " m/s | Rain Probability: " + rainProbability + "%");
    }
}
