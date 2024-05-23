public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) 
        : base(name, points)
    {
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
        this.currentCount = 0;
    }

    public override void RecordEvent()
    {
        currentCount++;
        if (currentCount >= targetCount)
        {
            isCompleted = true;
        }
    }

    public override string DisplayStatus()
    {
        return isCompleted ? $"[X] {Name} - Completed {currentCount}/{targetCount} times" : $"[ ] {Name} - Completed {currentCount}/{targetCount} times";
    }

    public int BonusPoints => isCompleted ? bonusPoints : 0;
}
