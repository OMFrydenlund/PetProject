// Add/take care of animal prompt (Press 1 or 2)
// If 1st, 3 conseq question where user writes desired animal attributes
// If 2nd, write line asking user to pick a listed animal
// Lines that ask the user questions relevant to an executed task
// Read user input converted to animal attributes
//Start with pick animal, then pick care choice!!!! NB
using PetProject;
Game.AnimalPen.Add(new Animal("Bob", "Bobcat", 43));
// decay timer for happiness
var DecayTimer = new Timer(Game.HappinessDecay(), null, 0, 10000);
Game.Run();

