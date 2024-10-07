namespace SuperheroHomework;

public class Superhero
{
    private static Superhero superman;
    private static Superhero batman;

    public string Name { get; private set; }

    private Superhero(string name) 
    {
        Name = name;
    }

    public static Superhero CreateSuperman() => superman ??= new Superhero("Супермен");

    public static Superhero CreateBatman() => batman ??= new Superhero("Бэтмен");
 }


