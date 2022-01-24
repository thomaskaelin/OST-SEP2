namespace Observer
{
    using System;

    public sealed class ConsoleView : IView
    {
        private readonly int _id;

        public ConsoleView(int id)
        {
            _id = id;
        }

        public void Update(float temperature, float humidity, float windSpeed)
        {
            Console.WriteLine($"View #{_id} | Temperature: {temperature} C° | Humidity: {humidity} % | Windspeed: {windSpeed} m/s");
        }
    }
}
