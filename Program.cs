// Задача 10
// int ExampleMethod(int num)
// {
//     int tens = num / 10;
//     int units = tens % 10;
//     return units;
// }

// int num = new Random().Next(100, 1000);
// System.Console.WriteLine(num);
// int resultNum = ExampleMethod(num);
// System.Console.WriteLine(resultNum);
// ================================================================

// задача 13

// сначала с интовой функцией решил но не до конца.
// int CheckMultiplicity(int num)
// {
//     if(num > 99 && num < 1000)
//     {
//         int result = num % 10;
//         return result;
//     }
//     else if (num > 999 && num < 10000)
//     {
//         int tens = num / 10;
//         int result = tens % 10;
//         return result;
//     }
//     else if(num > 9999)
//     {
//         int numbers = num / 100;
//         int result = numbers % 10;
//         return result;
//     }
//     else 
//     {
//         return num;
//     }
// }

// System.Console.WriteLine("enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{num} - > {CheckMultiplicity(num)}");

// теперь с войдом
// void CheckMultiplicity(int num)
// {
//     if(num > 99 && num < 1000)
//     {
//         int result = num % 10;
//         System.Console.WriteLine($"{num} -> {result}");
//     }
//     else if (num > 999 && num < 10000)
//     {
//         int tens = num / 10;
//         int result = tens % 10;
//         System.Console.WriteLine($"{num} -> {result}");
//     }
//     else if(num > 9999)
//     {
//         int numbers = num / 100;
//         int result = numbers % 10;
//         System.Console.WriteLine($"{num} -> {result}");
//     }
//     else 
//     {
//         System.Console.WriteLine($"{num} -> третьей цифры нет ");
//     }
// }

// System.Console.WriteLine("enter your number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// CheckMultiplicity(num);
// ================================================================
// Задача 15 не совсем понял, что это задача требует.
bool CheckDay(int num)
{
    if(num == 6 || num == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}
System.Console.WriteLine("enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{num} - > {CheckDay(num)}");