namespace GildedRose.UpdateStrategies
{
    internal static class UpdateStrategyFactory
    {
        internal static UpdateStrategy Create(Item item)
        {
            switch (item.Name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    return new LegendaryUpdateStrategy(item);

                case "Aged Brie":
                    return new AgedBrieUpdateStrategy(item);

                case "Backstage passes to a TAFKAL80ETC concert":
                    return new ConcertTicketUpdateStrategy(item);
            }

            if (item.Name.StartsWith("Conjured"))
                return new ConjuredUpdateStrategy(item);

            return new NormalUpdateStrategy(item);
        }
    }
}