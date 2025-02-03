namespace State.States
{
    internal sealed class NeutralState : PartnerStateBase
    {
        public NeutralState(Partner partner)
            : base(partner)
        {
        }

        public override void Talk()
        {
            Print("Hello!");
        }

        public override void Kiss()
        {
            Print("Thanks! :-)");
            SetState(new HappyState(Partner));
        }

        public override void Insult()
        {
            Print("Are you f***ing kidding me?!");
            SetState(new AngryState(Partner));
        }
    }
}
