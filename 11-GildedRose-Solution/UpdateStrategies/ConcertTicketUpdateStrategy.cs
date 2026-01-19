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
                case < 0:
                    ResetQuality();
                    break;

                case <= 5:
                    IncreaseQualityBy(3);
                    break;

                case > 5 and <= 10:
                    IncreaseQualityBy(2);
                    break;

                default:
                    IncreaseQualityBy(1);
                    break;
            }
        }
    }
}