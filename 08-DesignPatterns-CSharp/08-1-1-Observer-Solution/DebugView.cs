namespace Observer
{
    using System.Diagnostics;

    public sealed class DebugView : IView
    {
        private readonly int _id;

        public DebugView(int id)
        {
            _id = id;
        }

        public void Update(float temperature, float humidity, float windSpeed, float rainProbability)
        {
            Debug.WriteLine($"View #{_id} | Temperature: {temperature} C° | Humidity: {humidity} % | Windspeed: {windSpeed} m/s | Rain Probability: {rainProbability} %");
        }
    }
}
