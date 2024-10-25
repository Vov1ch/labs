﻿using System.Collections.Generic;
using static Student;
List<Student> list = new List<Student>();

Student student1 = new Student
{
    Name = "Макс",
    CourseNumber = 3,
    Achievement = 100,
    ProgrammingLanguage = MyEnum.Python,
};
list.Add(student1);

Student student2 = new Student
{
    Name = "Александр",
    CourseNumber = 2,
    Achievement = 85,
    ProgrammingLanguage = MyEnum.C,
};
list.Add(student2);
Student student3 = new Student
{
    Name = "Роман",
    CourseNumber = 3,
    Achievement = 90,
    ProgrammingLanguage = MyEnum.Dart,
};
list.Add(student3);
Student student4 = new Student
{
    Name = "Теодор",
    CourseNumber = 4,
    Achievement = 70,
    ProgrammingLanguage = MyEnum.JavaScript,
};
list.Add(student4);
Student student5 = new Student
{
    Name = "Петя",
    CourseNumber = 5,
    Achievement = 83,
    ProgrammingLanguage = MyEnum.Java,
};
list.Add(student5);
Student student6 = new Student
{
    Name = "Вася",
    CourseNumber = 2,
    Achievement = 95,
    ProgrammingLanguage = MyEnum.Python,
};
list.Add(student6);
Student student7 = new Student
{
    Name = "Григорий",
    CourseNumber = 3,
    Achievement = 100,
    ProgrammingLanguage = MyEnum.Dart,
};
list.Add(student7);
Student student8 = new Student
{
    Name = "Арсений",
    CourseNumber = 1,
    Achievement = 45,
    ProgrammingLanguage = MyEnum.C,
};
list.Add(student8);
Student student9 = new Student
{
    Name = "Алик",
    CourseNumber = 4,
    Achievement = 88,
    ProgrammingLanguage = MyEnum.JavaScript,
};
list.Add(student9);
Student student10 = new Student
{
    Name = "Степан",
    CourseNumber = 5,
    Achievement = 91,
    ProgrammingLanguage = MyEnum.Java,
};
list.Add(student10);

List<Department> list2 = new List<Department>();

GameDevelopment game = new GameDevelopment
{
    Title = "Games",
    Trainees = new List<Student>(),
    NumberOfPositions = 5,
    

};
list2.Add(game);
DataScience data = new DataScience
{
    Title = "Data",
    Trainees = new List<Student>(),
    NumberOfPositions = 3,
};
list2.Add(data);
MobileApplicationDevelopment app = new MobileApplicationDevelopment
{
    Title="Mobile",
    Trainees = new List<Student>(),
    NumberOfPositions = 4,
};
list2.Add(app);


game.TraineeDistribution(list);
data.TraineeDistribution(list);
app.TraineeDistribution(list);

foreach (var item in list2)
{
    Console.WriteLine(item.Title);
    foreach(var i in item.Trainees)
    {
        Console.WriteLine("Name: "+ i.Name);
        Console.WriteLine("Course: "+ i.CourseNumber);
        Console.WriteLine("Achiev: "+ i.Achievement);
        Console.WriteLine("Language: "+ i.ProgrammingLanguage);
        Console.WriteLine();
    }
}

Console.WriteLine("Остались:");
foreach (var item in list)
{

    Console.WriteLine("Name: "+item.Name);
    Console.WriteLine("Course: "+item.CourseNumber);
    Console.WriteLine("Achiev: "+item.Achievement);
    Console.WriteLine("Language: "+item.ProgrammingLanguage);
    Console.WriteLine();

}