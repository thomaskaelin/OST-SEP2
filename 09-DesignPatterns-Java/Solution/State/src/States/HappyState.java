package States;

public final class HappyState extends PartnerStateBase {

    public HappyState(Partner.Partner partner) {
        super(partner);
    }

    @Override
    public void talk() {
        print("I am so happy!");
    }

    @Override
    public void kiss() {
        print("Thanks! <3 <3");
    }

    @Override
    public void insult() {
        print("Why would you say something like that? :-(");
        setState(new AngryState(_partner));
    }
}
