
//  Условие: на входе массив строк, на выходе новый массив на основе исходного,
//  в котором длина элементов меньше либо равна 3-м символам."

System.Console.Write("Ввод массива через запятую: ");
System.Console.WriteLine();
string[] array = Console.ReadLine()!.Split(","); // ввод пользователем массива строк
string[] newArray = array.Where(a => (a.Length <= 3 && a != string.Empty)).ToArray(); // новый массив строк с выборкой элементов из изначального массива
System.Console.WriteLine();