public class Jupiter : Planet, IRequireSamples
{
    public Jupiter()
    {
        Name = "Jupiter";
    }

    public bool CheckSamples(int samples)
    {
        return samples >= 20; 
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

