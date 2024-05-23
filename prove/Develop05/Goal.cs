public abstract class Goal
{
    private string name;
    private int points;
    protected bool isCompleted;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
        this.isCompleted = false;
    }

    public string Name => name;
    public int Points => points;
    public bool IsCompleted => isCompleted;

    public abstract void RecordEvent();
    public abstract string DisplayStatus();
}
