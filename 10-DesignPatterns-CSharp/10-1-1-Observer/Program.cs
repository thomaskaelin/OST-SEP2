namespace Observer
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            weatherData.StartAsync().Wait();
        }
    }
}
