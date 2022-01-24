namespace State.States
{
    internal sealed class SuperAngryState : PartnerStateBase
    {
        private int _kissCounter;

        public SuperAngryState(Partner partner)
            : base(partner)
        {
        }

        public override void Talk()
        {
            _kissCounter = 0;
            Print("... I will never talk to you again!");
        }

        public override void Kiss()
        {
            _kissCounter++;

            if (_kissCounter < 5)
            {
                Print("...");
                return;
            }

            Print("Okay, I forgive you.");
            SetState(new NeutralState(Partner));
        }

        public override void Insult()
        {
            _kissCounter = 0;

            Print("You shall burn in hell!");
        }
    }
}
