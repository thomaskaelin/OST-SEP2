package Dices;

import java.util.Random;

public final class Dice implements IDice
{
    private final int _maxPips;
    private final Random _random;

    public Dice(int maxPips)
    {
        _maxPips = maxPips;
        _random = new Random();
    }

    @Override
    public int roll()
    {
        var roll = _random.nextInt(_maxPips + 1) + 1;

        return roll;
    }
}

