namespace GildedRose
{
    using System.Collections.Generic;
    using UpdateStrategies;

    public class GildedRose
    {
        private readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            _items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in _items)
            {
                var strategy = UpdateStrategyFactory.Create(item);
                strategy.Update();
            }
        }
    }
}
