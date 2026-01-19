namespace GildedRose.UpdateStrategies
{
    internal sealed class NormalUpdateStrategy : UpdateStrategy
    {
        internal NormalUpdateStrategy(Item item) : base(item)
        {
        }

        internal override void Update()
        {
            DecreaseSellInByOne();

            var decrease = IsExpired() ? 2 : 1;
            DecreaseQualityBy(decrease);
        }
    }
}