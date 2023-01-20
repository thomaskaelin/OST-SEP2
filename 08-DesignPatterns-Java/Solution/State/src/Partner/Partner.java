package Partner;

import States.IPartnerState;
import States.NeutralState;

public class Partner {
    private IPartnerState _state = new NeutralState(this);

    public void setState(IPartnerState state) {
        _state = state;
    }

    public void talk() {
        _state.talk();
    }

    public void kiss() {
        _state.kiss();
    }

    public void insult() {
        _state.insult();
    }
}
