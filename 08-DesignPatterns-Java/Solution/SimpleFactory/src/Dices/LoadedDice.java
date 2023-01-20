package Dices;

public class LoadedDice implements IDice {
    private final int _fixedRoll;

    public LoadedDice(int fixedRoll) {
        _fixedRoll = fixedRoll;
    }

    @Override
    public int roll() {
        return _fixedRoll;
    }
}
