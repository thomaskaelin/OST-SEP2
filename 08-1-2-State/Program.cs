namespace State
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main(string[] args)
        {
            var partner = new Partner();

            partner.Talk();
            partner.Insult();
            partner.Kiss();
            partner.Kiss();
            partner.Talk();
            partner.Kiss();
            partner.Insult();
            partner.Insult();
        }
    }
}
