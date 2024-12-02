
public class Student
{
    public string Name { get; set; }
    public int Samples { get; set; }
    public int SurvivalTestScore { get; set; }

    public Student(string name, int samples, int survivalTestScore)
    {
        Name = name;
        Samples = samples;
        SurvivalTestScore = survivalTestScore;
    }
}
