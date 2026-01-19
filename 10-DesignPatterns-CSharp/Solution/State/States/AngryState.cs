namespace State.States
{
    internal sealed class AngryState : PartnerStateBase
    {
        public AngryState(Partner partner)
            : base(partner)
        {
        }

        public override void Talk()
        {
            Print("Go away, I am angry!");
        }

        public override void Kiss()
        {
            Print("Okay, I forgive you.");
            SetState(new NeutralState(Partner));
        }

        public override void Insult()
        {
            Print("You shall burn in hell!");
            SetState(new SuperAngryState(Partner));
        }
    }
}
