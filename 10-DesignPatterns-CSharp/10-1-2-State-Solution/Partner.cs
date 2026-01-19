namespace State
{
    using States;

    public class Partner
    {
        internal IPartnerState State { get; set; }

        public Partner()
        {
            State = new NeutralState(this);
        }

        public void Talk() => State.Talk();

        public void Kiss() => State.Kiss();

        public void Insult() => State.Insult();
    }
}