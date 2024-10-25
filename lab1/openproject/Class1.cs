public class FitnessProgram
{
    public string Name
    {
        get
        {
            return _name;

        }
        set
        {
            if (string.IsNullOrEmpty(_name))
            {
                _name = value;
            }
        }
    }
    private string _name;

    public string ExercisePlan
    {
        get
        {
            return _plan;
        }

    }
    private string _plan;

    public int CaloriesBurned
    {
        get
        {
            return _cal;
        }
    }
    private int _cal;

    public int TotalExcesises
    {
        get
        {
            return _total;
        }
    }
    private int _total;

    public int DailyTargetCalories
    {
        get
        {
            return _target;
        }
    }
    private int _target;

    public string FithessLevel
    {
        get
        {
            if (CaloriesBurned > 1000)
            {
                _level = "Активный";
            }
            else if (CaloriesBurned > 2000)
            {
                _level = "Спортсмен";
            }
            else if (CaloriesBurned <= 1000)
            {
                _level = "Новичок";
            }
            return _level;
        }
    }
    private string _level;

    public void CompleteExercise(int Calories)
    {
        _cal += Calories;
        _total += 1;
    }
    public void ChangeExercisePlan(string NewPlan)
    {
        _plan = NewPlan;
    }
    public void SetDailyTargetCalories(int target)
    {
        _target = target;
    }
    public static string Motivation()
    {
        Random rnd = new Random();
        int x = rnd.Next(0,2);
        string a = "Good";
        string b = "Great";
        string c = "Nice";
        string f = "Super";
        if (x == 0)
        {
            return a;
        }
        if (x == 1)
        {
            return b;
        }
        if (x == 2)
        {
            return c;
        }
        return f;
    }
}
