namespace State
{
    using System;

    public class Partner
    {
        private PartnerState _state = PartnerState.Neutral;

        public void Talk()
        {
            switch (_state)
            {
                case PartnerState.Neutral:
                    Print("Hello!");
                    break;

                case PartnerState.Happy:
                    Print("I am so happy!");
                    break;

                case PartnerState.Angry:
                    Print("Go away, I am angry!");
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Kiss()
        {
            switch (_state)
            {
                case PartnerState.Neutral:
                    Print("Thanks! :-)");
                    SetState(PartnerState.Happy);
                    break;

                case PartnerState.Happy:
                    Print("Thanks! <3 <3");
                    break;

                case PartnerState.Angry:
                    Print("Okay, I forgive you.");
                    SetState(PartnerState.Neutral);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Insult()
        {
            switch (_state)
            {
                case PartnerState.Neutral:
                    Print("Are you f***ing kidding me?!");
                    SetState(PartnerState.Angry);
                    break;

                case PartnerState.Happy:
                    Print("Why would you say something like that? :-(");
                    SetState(PartnerState.Angry);
                    break;

                case PartnerState.Angry:
                    Print("You shall burn in hell!");
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void Print(string message) => Console.WriteLine(message);

        private void SetState(PartnerState newState) => _state = newState;
    }
}