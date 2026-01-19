package States;

public final class NeutralState extends PartnerStateBase {

    public NeutralState(Partner.Partner partner) {
        super(partner);
    }

    @Override
    public void talk() {
        print("Hello!");
    }

    @Override
    public void kiss() {
        print("Thanks! :-)");
        setState(new HappyState(_partner));
    }

    @Override
    public void insult() {
        print("Are you f***ing kidding me?!");
        setState(new AngryState(_partner));
    }
}
