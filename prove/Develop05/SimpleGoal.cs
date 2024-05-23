public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) {}

    public override void RecordEvent()
    {
        isCompleted = true;
    }

    public override string DisplayStatus()
    {
        return isCompleted ? $"[X] {Name}" : $"[ ] {Name}";
    }
}

