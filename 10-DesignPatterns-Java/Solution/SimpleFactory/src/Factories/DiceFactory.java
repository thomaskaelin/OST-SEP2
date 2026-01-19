package Factories;

import Dices.Dice;
import Dices.IDice;

public class DiceFactory implements IDiceFactory {
    @Override
    public IDice createDice(int pipsOnDice) {
        return new Dice(pipsOnDice);
    }
}
