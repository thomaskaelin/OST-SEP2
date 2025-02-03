namespace GildedRose.UpdateStrategies
{
    internal sealed class ConjuredUpdateStrategy : UpdateStrategy
    {
        internal ConjuredUpdateStrategy(Item item) : base(item)
        {
        }

        internal override void Update()
        {
            DecreaseSellInByOne();

            var decrease = IsExpired() ? 4 : 2;
            DecreaseQualityBy(decrease);
        }
    }
}