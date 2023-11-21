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
        foreach (var animal in animalPen) 
        {
            Console.WriteLine(animal.Name);
            Console.Write("Type: " + animal.Type);
            Console.Write("Age: " + animal.Age);
        }
        //Console.WriteLine("Which animal would you like to take care of?");
        //Console.ReadLine();
        //var index = Console.ReadLine();
        //Console.WriteLine("Feed placeholder?");
        //Console.WriteLine("Snuggle with placeholder?");
        //Console.WriteLine("Take placeholder out to poop?");
    }
}