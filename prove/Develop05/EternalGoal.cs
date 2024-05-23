public class EternalGoal : Goal
{
    private int timesCompleted;

    public EternalGoal(string name, int points) : base(name, points)
    {
        timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        timesCompleted++;
    }

    public override string DisplayStatus()
    {
        return $"[∞] {Name} - Completed {timesCompleted} times";
    }
}
