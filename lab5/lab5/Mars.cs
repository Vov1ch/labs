

public class Mars : Planet, IRequireSamples, IRequireSurvivalTest
{
    public Mars()
    {
        Name = "Mars";
    }

    public bool CheckSamples(int samples)
    {
        return samples >= 10; // Пример: требуется 10 образцов
    }

    public bool CheckSurvivalTest(int score)
    {
        return score >= 70; // Пример: требуется 70 баллов
    }

    public override string Check(Student student)
    {
        if (CheckSamples(student.Samples) && CheckSurvivalTest(student.SurvivalTestScore))
        {
            return $"{student.Name} готов к лететь на {Name}.";
        }
        else
        {
            return $"{student.Name} не готов лететь на {Name}.";
        }
    }
}
