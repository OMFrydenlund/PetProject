﻿// Add/take care of animal prompt (Press 1 or 2)
// If 1st, 3 conseq question where user writes desired animal attributes
// If 2nd, write line asking user to pick a listed animal
// Lines that ask the user questions relevant to an executed task
// Read user input converted to animal attributes
//Start with pick animal, then pick care choice!!!! NB

using PetProject;

class Program
{
    static void Main()
    {
        // create a new thread
        Thread t = new Thread(IntervalTimer);
 
        // start the thread
        t.Start();
        Game.AnimalPen.Add(new Animal("Bob", "Bobcat", 43));
        Game.Run();
    }
    
    static void IntervalTimer()
    {
        while (true)
        {
            foreach (var animal in Game.AnimalPen)
            {
                animal.LessHappy();
            }
            Thread.Sleep(3000);
        }
    }
}