package States;

public final class SuperAngryState extends PartnerStateBase {
    private int _kissCounter;

    public SuperAngryState(Partner.Partner partner) {
        super(partner);
    }

    @Override
    public void talk() {
        _kissCounter = 0;
        print("... I will never talk to you again!");
    }

    @Override
    public void kiss() {
        _kissCounter++;

        if (_kissCounter < 5) {
            print("...");
            return;
        }

        print("Okay, I forgive you.");
        setState(new NeutralState(_partner));
    }

    @Override
    public void insult() {
        _kissCounter = 0;
        print("You shall burn in hell.");
    }
}
