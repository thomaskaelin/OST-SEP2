package States;

public final class AngryState extends PartnerStateBase {

    public AngryState(Partner.Partner partner) {
        super(partner);
    }

    @Override
    public void talk() {
        print("Go away, I am angry!");
    }

    @Override
    public void kiss() {
        print("Okay, I forgive you.");
        setState(new NeutralState(_partner));
    }

    @Override
    public void insult() {
        print("You shall burn in hell.");
        setState(new SuperAngryState(_partner));
    }
}
