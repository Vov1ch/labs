using System.Runtime.CompilerServices;
using System.Xml.Linq;

Console.WriteLine("Введите имя:");
FitnessProgram person = new FitnessProgram();
person.Name = Console.ReadLine();
bool tf = true;

while (tf)
{

    Console.WriteLine("Выбор действия");
    Console.WriteLine("1. Установить целевую норму калорий");
    Console.WriteLine("2. Задать новый план тренировок");
    Console.WriteLine("3. Дополнить палн тренировок");
    Console.WriteLine("4. Выполнить упражнение");
    Console.WriteLine("5. Вывести текущую информацию о уровне здоровья");
    Console.WriteLine("6. Вывести мотивационное письмо");
    Console.WriteLine("7. Закончить тренировки");
    int select = Convert.ToInt32(Console.ReadLine());
    switch (select)
    {
        case 1:
            {
                Console.WriteLine("Введите целевую норму калорий в день:");
                int tar = Convert.ToInt32(Console.ReadLine());
                person.SetDailyTargetCalories(tar);
                Console.WriteLine("Нажмите на любую клавишу");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        case 2:
            {
                Console.WriteLine("Введите план:");
                string plan = Console.ReadLine();
                person.ChangeExercisePlan(plan);
                Console.WriteLine("Нажмите на любую клавишу-");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        case 3:
            {
                Console.WriteLine("Дополните план:");
                string plan = person.ExercisePlan +","+ Console.ReadLine();
                person.ChangeExercisePlan(plan);
                Console.WriteLine("Нажмите на любую клавишу-");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        case 4:
            {
                Console.WriteLine("Сколько калорий сожгли за тренировку:");
                int calo = Convert.ToInt32(Console.ReadLine());
                person.CompleteExercise(calo);
                if (calo < person.DailyTargetCalories)
                {
                    Console.WriteLine("Вы сожгли мало каллорий");
                }
                Console.WriteLine("Нажмите на любую клавишу-");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        case 5:
            {
                Print();
                Console.WriteLine("Нажмите на любую клавишу-");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        case 6:
            {
                Console.WriteLine(FitnessProgram.Motivation());
                Console.WriteLine("Нажмите на любую клавишу-");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        case 7:
            {
                tf = false;
                Console.WriteLine("Конец тренировок");
                break;
            }

    }

}

void Print()
{
    Console.WriteLine($"Имя: {person.Name}");
    Console.WriteLine($"План тренировки: {person.ExercisePlan}");
    Console.WriteLine($"Сжег калорий: {person.CaloriesBurned}");
    Console.WriteLine($"Колличество тренировок: {person.TotalExcesises}");
    Console.WriteLine($"Дневная норма калорий: {person.DailyTargetCalories}");
    Console.WriteLine($"Уровень: {person.FithessLevel}");
}