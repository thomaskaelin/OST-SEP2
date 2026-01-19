namespace GildedRose.UpdateStrategies
{
    internal abstract class UpdateStrategy
    {
        protected UpdateStrategy(Item item)
        {
            _item = item;
        }

        internal abstract void Update();

        #region Internals (for inheriting classes)

        private const int MinQuality = 0;
        private const int MaxQuality = 50;
        private readonly Item _item;

        protected bool IsExpired() => _item.SellIn < 0;

        protected int GetDaysBeforeExpiring() => _item.SellIn;

        protected void DecreaseSellInByOne() => _item.SellIn -= 1;

        protected void IncreaseQualityBy(int increase)
        {
            _item.Quality += increase;

            if (_item.Quality > MaxQuality)
                _item.Quality = MaxQuality;
        }

        protected void DecreaseQualityBy(int decrease)
        {
            _item.Quality -= decrease;

            if (_item.Quality < MinQuality)
                ResetQuality();
        }

        protected void ResetQuality() => _item.Quality = MinQuality;

        #endregion
    }
}