
namespace PetProject;

public class Game
{

    public static List<Animal> AnimalPen = new List<Animal>();
    
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("Add/take care of animal (Press 1 or 2) ");
        var input = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine("Add animal");
                ShowAddAnimalPrompt();
                break;
            case 2:
                ShowAnimalCarePrompt();
                break;
        }
    }
    public static void ShowAddAnimalPrompt()
    {
        string nameQuestion = "What will you call it? ";
        string typeQuestion = "What kind of animal is it? ";
        string ageQuestion = "How old is your animal? ";
        
        Console.Clear();

        Console.Write(nameQuestion);
        var name = Console.ReadLine();

        Console.Write(typeQuestion);
        var type = Console.ReadLine();

        Console.Write(ageQuestion);
        var age = Convert.ToInt32(Console.ReadLine());

        var animal = new Animal(name, type, age);
        AnimalPen.Add(animal);
        Run();
    }
    public static void ShowAnimalCarePrompt()
    {
        Console.Clear();
        for (int index = 0; index < AnimalPen.Count; index++)
        {
            var animal = AnimalPen[index];
            Console.WriteLine($"({index}) {animal.Name} - Type: {animal.Type} - Age: {animal.Age} - Happiness: {animal.HappinessMeter}");
        }
        Console.WriteLine("Which animal would you like to take care of? ");
        var selectedIndex = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        var selectedAnimal = AnimalPen[selectedIndex];
        Console.WriteLine($"How would you like to take care of {selectedAnimal.Name} the {selectedAnimal.Type}? ");
        Console.WriteLine($"(1) Feed {selectedAnimal.Name}? ");
        Console.WriteLine($"(2) Snuggle with {selectedAnimal.Name}? ");
        Console.WriteLine($"(3) Take {selectedAnimal.Name} out to poop? ");
        var selectedAction = Convert.ToInt32(Console.ReadLine());
        switch (selectedAction)
        {
            case 1:
                selectedAnimal.Feed();
                break;
            case 2:
                selectedAnimal.Snuggle();
                break;
            case 3:
                selectedAnimal.Poop();
                break;
        }

        Console.Write("Press enter to continue... ");
        Console.ReadLine();
        Run();
    }
}