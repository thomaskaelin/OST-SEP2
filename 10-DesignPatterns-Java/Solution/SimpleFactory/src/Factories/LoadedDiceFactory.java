package Factories;

import Dices.IDice;
import Dices.LoadedDice;

public class LoadedDiceFactory implements IDiceFactory {
    @Override
    public IDice createDice(int pipsOnDice) {
        return new LoadedDice(pipsOnDice);
    }
}
