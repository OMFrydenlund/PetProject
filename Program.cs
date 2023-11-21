// Add/take care of animal prompt (Press 1 or 2)

using PetProject;
Game.animalPen.Add(new Animal("Bob", "Bobcat", 43));
Console.WriteLine("Add/take care of animal (Press 1 or 2)");
var input = Convert.ToInt32(Console.ReadLine());
switch (input)
{
    case 1:
        Console.WriteLine("Add animal");
        Game.ShowAddAminalPrompt();
        break;
    case 2:
        Console.WriteLine("How would you like to take care of PLACEHOLDER?");
        Game.ShowAnimalCarePrompt();
        break;
}
Console.WriteLine(input);
// If 1st, 3 conseq question where user writes desired animal attributes

// If 2nd, write line asking user to pick a listed animal

// Lines that ask the user questions relevant to an executed task
// Read user input converted to animal attributes

//Start with pick animal, then pick care choice!!!! NB
