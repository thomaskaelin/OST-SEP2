namespace Observer
{
    public interface IView
    {
        public void Update(float temperature, float humidity, float windSpeed);
    }
}
