namespace Observer
{
    using System.Collections.Generic;

    public sealed class WeatherData : WeatherAPI
    {
        private readonly List<IView> _observer = new();

        public void Attach(IView view) => _observer.Add(view);

        public void Detach(IView view) => _observer.Remove(view);

        protected override void MeasurementChanged()
        {
            var temperature = GetTemperature();
            var humidity = GetHumidity();
            var windSpeed = GetWindSpeed();
            var rainProbability = GetRainProbability();

            foreach (var observer in _observer)
                observer.Update(temperature, humidity, windSpeed, rainProbability);
        }
    }
}
