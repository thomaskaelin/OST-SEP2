namespace State.States
{
    internal sealed class HappyState : PartnerStateBase
    {
        public HappyState(Partner partner)
            : base(partner)
        {
        }

        public override void Talk()
        {
            Print("I am so happy!");
        }

        public override void Kiss()
        {
            Print("Thanks! <3 <3");
        }

        public override void Insult()
        {
            Print("Why would you say something like that? :-(");
            SetState(new AngryState(Partner));
        }
    }
}
