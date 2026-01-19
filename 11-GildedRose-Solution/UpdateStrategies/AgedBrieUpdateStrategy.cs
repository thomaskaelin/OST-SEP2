namespace GildedRose.UpdateStrategies
{
    internal sealed class AgedBrieUpdateStrategy : UpdateStrategy
    {
        internal AgedBrieUpdateStrategy(Item item) : base(item)
        {
        }

        internal override void Update()
        {
            DecreaseSellInByOne();

            var increase = IsExpired() ? 2 : 1;
            IncreaseQualityBy(increase);
        }
    }
}