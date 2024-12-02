public class Mercury : Planet, IRequireSurvivalTest
{
    public Mercury()
    {
        Name = "Mercury";
    }

    public bool CheckSurvivalTest(int score)
    {
        return score >= 90; // Пример: требуется 90 баллов
    }

    public override string Check(Student student)
    {
        if (CheckSurvivalTest(student.SurvivalTestScore))
        {
            return $"{student.Name} готов лететь на  {Name}.";
        }
        else
        {
            return $"{student.Name} не готов лететь на {Name}.";
        }
    }
}
