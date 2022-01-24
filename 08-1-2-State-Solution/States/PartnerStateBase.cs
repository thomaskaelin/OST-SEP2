namespace State.States
{
    using System;

    internal abstract class PartnerStateBase : IPartnerState
    {
        protected PartnerStateBase(Partner partner)
        {
            Partner = partner;
        }

        public abstract void Talk();

        public abstract void Kiss();

        public abstract void Insult();

        protected Partner Partner { get; }

        protected void Print(string message) => Console.WriteLine(message);

        protected void SetState(IPartnerState newState) => Partner.State = newState;
    }
}
