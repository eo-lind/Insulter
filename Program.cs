// Step 7: Call the method
List<Insult> insults = GetInsults();


// Step 4 - VARIABLES: Get three random integers between 0 and 7 and assign to variables
int randomInt1 = new Random().Next(0, 7);
int randomInt2 = new Random().Next(0, 7);
int randomInt3 = new Random().Next(0, 7);

// Step 5 - METHOD: Regnerate random integer variables as long as any of the three are duplicates of each other
do
{
    randomInt1 = new Random().Next(0, 7);
    randomInt2 = new Random().Next(0, 7);
    randomInt3 = new Random().Next(0, 7);
} while ((randomInt1 == randomInt2) || (randomInt2 == randomInt3) || (randomInt1 == randomInt3));

// Step 6 - METHOD: Print the three strings
    Console.WriteLine($"{insults[randomInt1].InsultText}");
    Console.WriteLine($"{insults[randomInt2].InsultText}");
    Console.WriteLine($"{insults[randomInt3].InsultText}");

// Step 2: Create a method to return a list (insults)
List<Insult> GetInsults()
{
    // Step 3: Create a list of objects (new Insult)
    List<Insult> insults = new List<Insult>
    {
    new Insult
    {
        InsultText = "You look like what morning breath smells like."
    },
    new Insult
    {
        InsultText = "If you tried to give me CPR, I would probably throw myself back under water."
    },
    new Insult
    {
        InsultText = "I am not a fan of you."
    },
    new Insult
    {
        InsultText = "You think you're so special...and you are. The fact of your existence is nearly impossible to believe."
    },
    new Insult
    {
        InsultText = "I'd rather walk than be on the same plane as you."
    },
    new Insult
    {
        InsultText = "If I were given a million dollars to hang out with you, I would. But then I'd have to spend half of it on therapy."
    },
    new Insult
    {
        InsultText = "Do you have to be so...like that?"
    }
    };
    return (insults);
};

// Step 1: Create a class (Insult)
public class Insult
{
    public string InsultText { get; set; }
}