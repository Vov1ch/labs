public class Saturn : Planet, IRequireSamples
{
    public Saturn()
    {
        Name = "Saturn";
    }

    public bool CheckSamples(int samples)
    {
        return samples >= 15; // Пример: требуется 15 образцов
    }

    public override string Check(Student student)
    {
        if (CheckSamples(student.Samples))
        {
            return $"{student.Name} готов лететь на {Name}.";
        }
        else
        {
            return $"{student.Name} не готов лететь на {Name}.";
        }
    }
}
