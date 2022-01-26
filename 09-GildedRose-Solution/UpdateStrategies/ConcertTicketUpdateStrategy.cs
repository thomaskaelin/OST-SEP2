namespace GildedRose.UpdateStrategies
{
    internal sealed class ConcertTicketUpdateStrategy : UpdateStrategy
    {
        internal ConcertTicketUpdateStrategy(Item item) : base(item)
        {
        }

        internal override void Update()
        {
            DecreaseSellInByOne();
            
            switch (GetDaysBeforeExpiring())
            {
                case int days when days < 0:
                    ResetQuality();
                    break;

                case int days when days <= 5:
                    IncreaseQualityBy(3);
                    break;

                case int days when days > 5 && days <= 10:
                    IncreaseQualityBy(2);
                    break;

                default:
                    IncreaseQualityBy(1);
                    break;
            }
        }
    }
}