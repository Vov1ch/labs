public class Uranus : Planet
{
    public Uranus()
    {
        Name = "Uranus";
    }

    public override string Check(Student student)
    {
        return $"Mиссия на {Name} невозможна.";
    }
}
