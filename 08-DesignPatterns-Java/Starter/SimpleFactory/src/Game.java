public final class Game
{
    private static int PipsOnDice = 6;

    public void play()
    {
        var dice = new Dice(PipsOnDice);

        var roll1 = dice.roll();
        var roll2 = dice.roll();
        var sum = roll1 + roll2;
        var hasWon = sum == 2 * PipsOnDice;
        var message = hasWon ? "You win!" : "You loose!";

        print(message);
    }

    private static void print(String message) {
        System.out.println(message);
    }
}
