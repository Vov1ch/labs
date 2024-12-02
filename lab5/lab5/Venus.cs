
public class Venus : Planet, IHaveAngryResidents
{
    public Venus()
    {
        Name = "Venus";
    }

    public bool HasAngryResidents()
    {
        return true;
    }

    public override string Check(Student student)
    {
        return $"Миссия на {Name} невозможна";
    }
}


