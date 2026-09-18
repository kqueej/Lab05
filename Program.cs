// Задание А
// int month = int.Parse(Console.ReadLine()!);

// string season = month switch
// {
//     12 or 1 or 2 => "Winter",
//     3 or 4 or 5 => "Spring",
//     6 or 7 or 8 => "Summer",
//     9 or 10 or 11 => "Autumn",
//     _ => "Wrong month"
// };
// Console.WriteLine(season);

// Задание Б
// int age = int.Parse(Console.ReadLine()!);
// string category = age switch
// {
//     < 0 => "Error",
//     >= 0 and <= 6 => "Child",
//     >= 7 and <= 17 => "Teen",
//     >= 18 and <= 64 => "Adult",
//     >= 65 => "Pensioner"
// };

// Console.WriteLine(category);

// Вариант 9
// int hour = int.Parse(Console.ReadLine()!);

// string tariff = hour switch
// {
//     >= 0 and <= 5 => "Night tariff",
//     >= 6 and <= 9 => "Morning tariff",
//     >= 10 and <= 17 => "Day tariff",
//     >= 18 and <= 23 => "Evening tariff",
//     _ => "Invalid hour"
// };

// Console.WriteLine(tariff);

// Вариант 10
// int age = int.Parse(Console.ReadLine()!);
// Console.Write($"Do u have ticket? 0/1: ");
// string ticket = Console.ReadLine();
// bool ticketT = (ticket == "1");

// switch (age)
// {
//     case < 18:
//         Console.WriteLine("Age is not suitable");
//         break;
//     case >= 18 when ticketT:
//         Console.WriteLine("Entry allowed");
//         break;
//     case >= 18:
//             Console.WriteLine("No ticket");
//             break;
// }

// Дополнительное задание №1
// int number = 42;
// string result = number switch
// {
//    < 0 => "Negative",
//    >= 0 and <= 9 => "Single digit",
//    >= 10 and >= 99 => "Double digit",
//    _ => "Triple and more digit"
// };


// Изменненная программа 
// int number = 42;
// string result = number switch
// {
//     1 or 2 or 3 => "Small number",
//     < 0 => "Negative",
//     >= 0 and <= 9 => "Sigle digit",
//     >= 10 and <= 99 => "Double digit",
//     _ => "Triple and more digit"
// };

// Console.WriteLine(result);