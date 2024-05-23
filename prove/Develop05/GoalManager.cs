public class GoalManager
{
    private List<Goal> goals;
    private int totalScore;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.Name == goalName)
            {
                goal.RecordEvent();
                totalScore += goal.Points;
                if (goal is ChecklistGoal checklistGoal && checklistGoal.IsCompleted)
                {
                    totalScore += checklistGoal.BonusPoints;
                }
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }
    }

    public int TotalScore => totalScore;
}
