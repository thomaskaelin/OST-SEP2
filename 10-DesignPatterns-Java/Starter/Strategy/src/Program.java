import java.util.ArrayList;

public class Program {
    public static void main(String[] args) {
        var ducks = new ArrayList<Duck>();
        ducks.add(new MallardDuck());
        ducks.add(new RedheadDuck());
        ducks.add(new RubberDuck());
        ducks.add(new DecoyDuck());

        for(var duck : ducks)
            interactWithDuck(duck);
    }

    private static void interactWithDuck(Duck duck)
    {
        duck.display();
        duck.quack();
        duck.swim();
        duck.fly();
        System.out.println("-----------------");
    }
}
