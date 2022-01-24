namespace Observer
{
    using System;
    using System.Threading.Tasks;
    using System.Timers;

    /// <summary>
    /// This class simulates the API of your supplier. You are *not* allowed to modify it.
    /// </summary>
    public abstract class WeatherAPI
    {
        protected WeatherAPI()
        {
            CreateTimer();
        }

        protected abstract void MeasurementChanged();

        protected float GetTemperature() => _currentTemperature;

        protected float GetHumidity() => _currentHumidity;

        protected float GetWindSpeed() => _currentWindSpeed;

        protected float GetRainProbability() => _currentRainProbability;

        public Task StartAsync()
        {
            _tcs = new TaskCompletionSource();
            _timer.Enabled = true;
            return _tcs.Task;
        }

        #region Private Implementation

        private readonly Random _random = new();
        private TaskCompletionSource _tcs;
        private Timer _timer;
        private float _currentTemperature = 18.0f;
        private float _currentHumidity = 30.0f;
        private float _currentWindSpeed = 5.0f;
        private float _currentRainProbability = 10.0f;

        private void CreateTimer()
        {
            _timer = new Timer
            {
                Interval = TimeSpan.FromSeconds(1).TotalMilliseconds,
                AutoReset = true
            };

            _timer.Elapsed += DoOnTimerElapsed;
        }

        private void DoOnTimerElapsed(object sender, ElapsedEventArgs eventArgs)
        {
            _currentTemperature = GetUpdatedValue(_currentTemperature, -20, 40);
            _currentHumidity = GetUpdatedValue(_currentHumidity, 0, 100);
            _currentWindSpeed = GetUpdatedValue(_currentWindSpeed, 0, 80);
            _currentRainProbability = GetUpdatedValue(_currentRainProbability, 0, 100);

            MeasurementChanged();
        }

        private float GetUpdatedValue(float currentValue, int lowerBoundary, int upperBoundary)
        {
            var random = _random.Next(0, 2);
            var increase = random % 2 == 1;
            var modification = increase ? +1 : -1;
            var updatedValue = currentValue + modification;

            if (updatedValue < lowerBoundary)
                updatedValue = lowerBoundary;

            if (updatedValue > upperBoundary)
                updatedValue = upperBoundary;

            return updatedValue;
        }

        #endregion
    }
}
