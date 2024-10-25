﻿public class Student
{
    public string Name { get; set; }
    public int CourseNumber { get; set; }
    public double Achievement { get; set; }
    public enum MyEnum
    {
        Python,
        Dart,
        Java,
        JavaScript,
        C
    }
    public MyEnum ProgrammingLanguage { get; set; }

}

class Traineeship
{
    public List<Student> Candidates { get; set; }
    public List<Department> Departments { get; set; }
}

public class Department
{
    public string Title { get; set; }
    public List<Student> Trainees { get; set; }=new List<Student>();
    public int NumberOfPositions { get; set; }
    public virtual void TraineeDistribution( List<Student> candidates)
    {

    }
}

class GameDevelopment : Department
{
    public override void TraineeDistribution(List<Student> candidates)
    {
        for (int i = 0; i < candidates.Count; i++)
        { 
            if (candidates[i].ProgrammingLanguage == Student.MyEnum.C && candidates[i].Achievement>=80 && candidates[i].CourseNumber >= 2)
            {
                Trainees.Add(candidates[i] );
            }
        }
        foreach (var student in Trainees) 
        {
            candidates.Remove(student);
        }
    }
}

class DataScience : Department
{
    public override void TraineeDistribution(List<Student> candidates)
    {
        for (int i = 0; i < candidates.Count; i++)
        {
            if (candidates[i].ProgrammingLanguage == Student.MyEnum.Python && candidates[i].Achievement >= 85 && candidates[i].CourseNumber >= 2)
            {
                Trainees.Add(candidates[i]);
            }
        }
        foreach (var student in Trainees)
        {
            candidates.Remove(student);
        }
    }

}

class MobileApplicationDevelopment : Department
{
    public override void TraineeDistribution(List<Student> candidates)
    {
        for (int i = 0; i < candidates.Count; i++)
        {
            if (candidates[i].ProgrammingLanguage == Student.MyEnum.Dart & candidates[i].Achievement >= 90 & candidates[i].CourseNumber >= 2)
            {
                Trainees.Add(candidates[i]);
            }
        }
        foreach(var student in Trainees)
        {
            candidates.Remove(student);
        }
    }

}