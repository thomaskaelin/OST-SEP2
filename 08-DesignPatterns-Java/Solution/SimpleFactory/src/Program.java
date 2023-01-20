import Factories.DiceFactory;
import Factories.LoadedDiceFactory;

public class Program {
    public static void main(String[] args) {
        var diceFactory = new DiceFactory();
        var loadedDiceFactory = new LoadedDiceFactory();

        var game = new Game(loadedDiceFactory);

        for (var i = 1; i <= 5; i++)
        {
            System.out.println("Playing game #" + i);
            game.play();
        }
    }
}
