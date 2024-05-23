public class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        manager.AddGoal(new SimpleGoal("Run a marathon", 1000));
        manager.AddGoal(new EternalGoal("Read scriptures", 100));
        manager.AddGoal(new ChecklistGoal("Attend temple", 50, 10, 500));

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. View Score");
            Console.WriteLine("4. Add Goal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    manager.DisplayGoals();
                    break;
                case "2":
                    Console.Write("Enter goal name: ");
                    string goalName = Console.ReadLine();
                    manager.RecordEvent(goalName);
                    break;
                case "3":
                    Console.WriteLine($"Total Score: {manager.TotalScore}");
                    break;
                case "4":
                    // Implement logic to add new goals
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

