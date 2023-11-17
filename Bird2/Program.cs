namespace Bird2;
class Program
{
    static void Main()
    {
        Bird defaultBird = new Bird();
        Pigeon pigeon = new Pigeon();
        Eagle eagle = new Eagle();
        Crow crow = new Crow();

        Console.WriteLine("Generic bird says:");
        defaultBird.DefaultTalk();

        Console.WriteLine("\nPigeon says:");
        pigeon.PigeonTalk();

        Console.WriteLine("\nEagle says:");
        eagle.EagleTalk();

        Console.WriteLine("\nCrow says:");
        crow.CrowTalk();
    }
}