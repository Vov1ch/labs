public class Neptune : Planet
{
    public Neptune()
    {
        Name = "Neptune";
    }

    public override string Check(Student student)
    {
        return $"Миссия на {Name} невозможна.";
    }
}
