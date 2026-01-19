public class Partner {
    private PartnerState _state = PartnerState.NEUTRAL;

    public void talk() {
        switch (_state) {
            case NEUTRAL:
                print("Hello!");
                break;

            case HAPPY:
                print("I am so happy!");
                break;

            case ANGRY:
                print("Go away, I am angry!");
                break;

            default:
                throw new IllegalArgumentException();
        }
    }

    public void kiss() {
        switch (_state) {
            case NEUTRAL:
                print("Thanks! :-)");
                setState(PartnerState.HAPPY);
                break;

            case HAPPY:
                print("Thanks! <3 <3");
                break;

            case ANGRY:
                print("Okay, I forgive you.");
                setState(PartnerState.NEUTRAL);
                break;

            default:
                throw new IllegalArgumentException();
        }
    }

    public void insult() {
        switch (_state) {
            case NEUTRAL:
                print("Are you f***ing kidding me?!");
                setState(PartnerState.ANGRY);
                break;

            case HAPPY:
                print("Why would you say something like that? :-(");
                setState(PartnerState.ANGRY);
                break;

            case ANGRY:
                print("You shall burn in hell!");
                break;

            default:
                throw new IllegalArgumentException();
        }
    }

    private void print(String message) {
        System.out.println(message);
    }

    private void setState(PartnerState newState) {
        _state = newState;
    }
}
