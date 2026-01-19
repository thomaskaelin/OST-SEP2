package States;

public abstract class PartnerStateBase implements IPartnerState {
    protected Partner.Partner _partner;

    protected PartnerStateBase(Partner.Partner partner) {
        _partner = partner;
    }

    public abstract void talk();

    public abstract void kiss();

    public abstract void insult();

    protected void print(String message) {
        System.out.println(message);
    }

    protected void setState(IPartnerState newState) {
        _partner.setState(newState);
    }
}
