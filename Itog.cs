
//  Условие: на входе массив строк, на выходе новый массив на основе исходного,
//  в котором длина элементов меньше либо равна 3-м символам."

System.Console.Write("Ввод массива через запятую: ");
System.Console.WriteLine();
string[] array = Console.ReadLine()!.Split(","); 
string[] newArray = array.Where(a => (a.Length <= 3 && a != string.Empty)).ToArray(); 
System.Console.WriteLine();
System.Console.WriteLine("Новый массив: " + (newArray.Length > 0 ? String.Join(",", newArray) : "введены условия, не удовлетворяющие условиям задачи!")); 
System.Console.WriteLine("Для продолжения нажмите любую кнопку:");
System.Console.ReadKey();