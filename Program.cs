// Step 5: Call the method
List<Insult> insults = GetInsults();

// TODO Step 4: Iterate through the insults in the list and print each one to the console (will probably be changing this to do something different)
foreach (Insult oneInsult in insults)
{
    Console.WriteLine(oneInsult.InsultText);
}

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