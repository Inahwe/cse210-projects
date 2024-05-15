public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("You have a few seconds to think before you start listing...");

        ShowCountDown(5);

        Console.WriteLine("Start listing items now:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        _count = 0;

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }
}