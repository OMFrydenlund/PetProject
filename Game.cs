namespace PetProject;

public class Game
{

    public static List<Animal> animalPen = new List<Animal>();
    public static void ShowAddAminalPrompt()
    {
        string nameQuestion = "What will you call it?";
        string typeQuestion = "What kind of animal is it?";
        string ageQuestion = "How old is your animal?";

        Console.Write(nameQuestion);
        var name = Console.ReadLine();

        Console.Write(typeQuestion);
        var type = Console.ReadLine();

        Console.Write(ageQuestion);
        var age = Convert.ToInt32(Console.ReadLine());

        var animal = new Animal(name, type, age);
        animalPen.Add(animal);
    }
    public static void ShowAnimalCarePrompt() 
    {
        
    }
}