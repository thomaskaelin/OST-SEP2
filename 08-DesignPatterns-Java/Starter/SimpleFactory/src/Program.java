public class Program {
    public static void main(String[] args) {
        var game = new Game();

        for (var i = 1; i <= 5; i++)
        {
            System.out.println("Playing game #" + i);
            game.play();
        }
    }
}
