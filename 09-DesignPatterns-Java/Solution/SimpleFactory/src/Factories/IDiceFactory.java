package Factories;

import Dices.IDice;

public interface IDiceFactory {
    IDice createDice(int pipsOnDice);
}
