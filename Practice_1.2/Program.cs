// Практика 1.2 Циклы
using System.Globalization;
using System.IO.Pipelines;

// Упражнение 1.
// За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
// class Program
// {
//     public static (decimal, sbyte) GetInput()
//     {
//         try
//         {
//             decimal sum = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
//             sbyte months = Convert.ToSByte(Console.ReadLine(), CultureInfo.InvariantCulture);
//             return (sum, months);
//         }
//         catch
//         {
//             Console.WriteLine("something went wrong..");
//             throw new Exception();
//         }
//     }
//     public static void Main()
//     {
//         var (sum, months) = GetInput();
//         for (int i = 1; i <= months; i++)
//         {
//             sum += sum * 0.07M;
//         }
//         Console.WriteLine(sum)
//     }
// }


// Упражнение 2
// Перепишите предыдущую программу, только вместо цикла for используйте цикл while.
// class Program
// {
//     public static (decimal, sbyte) GetInput()
//     {
//         try
//         {
//             decimal sum = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
//             sbyte months = Convert.ToSByte(Console.ReadLine(), CultureInfo.InvariantCulture);
//             return (sum, months);
//         }
//         catch
//         {
//             Console.WriteLine("something went wrong..");
//             throw new Exception();
//         }
//     }
//     public static void Main()
//     {
//         var (sum, months) = GetInput();
//         while (months > 0)
//         {
//             sum += sum * 0.07M;
//             months--;
//         }
//         Console.WriteLine(sum);
//     }
// }

// Упражнение 3
// Напишите программу, которая будет выводить таблицу умножения на экран
// sbyte firstNumber = 2;
// sbyte secondNumber = 1;
// while (firstNumber <= 9)
// {
//     if (secondNumber > 9)
//     {
//         firstNumber += 1;
//         secondNumber = 1;
//     }
//     if (firstNumber == 10)
//         break;
//     int resultOfTimes = firstNumber * secondNumber;
//     Console.WriteLine($"{firstNumber}x{secondNumber}={resultOfTimes}");
//     secondNumber++;
// }
// Console.WriteLine("error");
// Упражнение 4
// Напишите программу, в которую пользователь вводит два числа и выводит результат их умножения. При этом программа должны запрашивать у пользователя ввод чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10. Если введенные числа окажутся больше 10 или меньше 0, то программа должна вывести пользователю о том, что введенные числа недопустимы, и повторно запросить у пользователя ввод двух чисел. Если введенные числа принадлежат диапазону от 0 до 10, то программа выводит результат умножения.
class Program
{
    public static (sbyte, sbyte) GetInput()
    {
        do
        {
            try
            {
                Console.Write("Enter first digit!");
                sbyte firstNumber = Convert.ToSByte(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Enter second digit!");
                sbyte secondNumber = Convert.ToSByte(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (firstNumber >= 0 && firstNumber <= 10 && secondNumber >= 0 && secondNumber <= 10)
                    return (firstNumber, secondNumber);
                else
                    Console.WriteLine("Invalid input!");
            }
            catch
            {
                Console.WriteLine("Invalid Input!");
                continue;
            }
        } while (true);
    }
    public static void Main()
    {
        var (firstNumber, secondNumber) = GetInput();
        sbyte answer = (sbyte)(firstNumber * secondNumber);
        Console.WriteLine($"Answer is {answer}");
    }
}