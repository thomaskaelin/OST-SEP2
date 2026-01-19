namespace Observer
{
    public sealed class WeatherData : WeatherAPI
    {
        private readonly IView _view1, _view2, _view3;

        public WeatherData()
        {
            _view1 = new ConsoleView(1);
            _view2 = new ConsoleView(2);
            _view3 = new ConsoleView(3);
        }

        protected override void MeasurementChanged()
        {
            var temperature = GetTemperature();
            var humidity = GetHumidity();
            var windSpeed = GetWindSpeed();

            _view1.Update(temperature, humidity, windSpeed);
            _view2.Update(temperature, humidity, windSpeed);
            _view3.Update(temperature, humidity, windSpeed);
        }
    }
}
