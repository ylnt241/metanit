using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

// ПРАКТИКА 1.1 (УСЛОВНЫЕ КОНСТРУКЦИИ).


// Упражнение 1
// Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа.
// А программа сранивает два введенных числа и выводит на консоль результат сравнения (два числа равны, первое число больше второго или первое число меньше второго).

// class Program
// {
//     public static (decimal firstNumber, decimal secondNumber) GetInput()
//     {
//         try
//         {
//             decimal firstNumber = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
//             decimal secondNumber = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
//             return (firstNumber, secondNumber);
//         }
//         catch
//         {
//             Console.WriteLine("something went wrong..");
//             throw new Exception();
//         }
//     }
//     public static void Main()
//     {
//         var (firstNumber, secondNumber) = GetInput();
//         if (firstNumber == secondNumber)
//             Console.WriteLine($"{firstNumber} = {secondNumber}");
//         else if (firstNumber > secondNumber)
//             Console.WriteLine($"{firstNumber} > {secondNumber}");
//         else if (firstNumber < secondNumber)
//             Console.WriteLine($"{firstNumber} < {secondNumber}");
//         else
//             Console.WriteLine("Something went wrong...");
//     }
// }


// Задание 2.
// Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10". Иначе программа выводит сообщение "Неизвестное число".

// class Program
// {
//     public static decimal GetInput()
//     {
//         try
//         {
//             decimal firstNumber = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
//             return (firstNumber);
//         }
//         catch
//         {
//             Console.WriteLine("something went wrong..");
//             throw new Exception();
//         }
//     }
//     public static void Main()
//     {
//         var firstNumber = GetInput();
//         if (firstNumber > 5 && firstNumber < 10)
//             Console.WriteLine("Число больше 5 и меньше 10");
//         else
//             Console.WriteLine("Неизвестное число");
//     }
// }

// Задание 3
// Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10". Иначе программа выводит сообщение "Неизвестное число".

// class Program
// {
//     public static decimal GetInput()
//     {
//         try
//         {
//             decimal firstNumber = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
//             return (firstNumber);
//         }
//         catch
//         {
//             Console.WriteLine("something went wrong..");
//             throw new Exception();
//         }
//     }
//     public static void Main()
//     {
//         var firstNumber = GetInput();
//         if (firstNumber == 5 || firstNumber == 10)
//             Console.WriteLine("Число либо равно 5, либо равно 10");
//         else
//             Console.WriteLine("Неизвестное число");
//     }
// }

// Упражнение 4
// В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. Напишите консольную программу, в которую пользователь вводит сумму вклада. Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.

// Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())
// class Program
// {
//     public static decimal GetInput()
//     {
//         try
//         {
//             decimal firstNumber = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
//             return (firstNumber);
//         }
//         catch
//         {
//             Console.WriteLine("something went wrong..");
//             throw new Exception();
//         }
//     }
//     public static void Main()
//     {
//         var firstNumber = GetInput();
//         if (firstNumber < 100)
//             firstNumber += firstNumber * 5 / 100;
//         else if (firstNumber <= 200)
//             firstNumber += firstNumber * 7 / 100;
//         else
//             firstNumber += firstNumber * 10 / 100;
//         Console.WriteLine(firstNumber);
//     }
// }


// Упражнение 5
// Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.
// class Program
// {
//     public static decimal GetInput()
//     {
//         try
//         {
//             decimal firstNumber = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
//             return (firstNumber);
//         }
//         catch
//         {
//             Console.WriteLine("something went wrong..");
//             throw new Exception();
//         }
//     }
//     public static void Main()
//     {
//         var firstNumber = GetInput();
//         double percent;
//         if (firstNumber < 100)
//             percent = 0.05;
//         else if (firstNumber <= 200)
//             percent = 0.07;
//         else
//             percent = 0.1;
//         decimal sum = firstNumber + (firstNumber * (decimal)percent) + 15;
//         Console.WriteLine(sum);
//     }
// }

// Упражнение 6
// Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение". Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2. Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.

// Для определения операции по введенному номеру используйте конструкцию switch...case.

// Если введенное пользователем число не соответствует никакой операции (например, число 120), то выведите пользователю сообщение о том, что операция неопределена.


// class Program
// {
//     public static sbyte GetInput()
//     {
//         try
//         {
//             sbyte inputedNumber = Convert.ToSByte(Console.ReadLine(), CultureInfo.InvariantCulture);
//             return (inputedNumber);
//         }
//         catch
//         {
//             Console.WriteLine("Invalid Input!");
//             return GetInput();
//         }
//     }
//     public static void Main()
//     {
//         do
//         {
//             Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
//             sbyte caseNumber = GetInput();
//             if (caseNumber == 1 || caseNumber == 2 || caseNumber == 3)
//             {
//                 string? operation = "";
//                 switch (caseNumber)
//                 {
//                     case 1:
//                         operation = "Сложение";
//                         break;
//                     case 2:
//                         operation = "Вычитание";
//                         break;
//                     case 3:
//                         operation = "Умножение";
//                         break;
//                 }
//                 Console.WriteLine($"Вы выбрали {operation}");
//                 break;
//             }
//             else
//                 Console.WriteLine("Invalid input!");
//         } while (true);
//     }
// }

// Упражнение 7

// Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа, и в зависимости от номера операции с введенными числами выполняются определенные действия (например, при вводе числа 3 числа умножаются). Результа операции выводиться на консоль.

// class Program
// {
//     public static (sbyte choosenOperation, decimal firstNumber, decimal secondNumber) GetInput()
//     {
//         try
//         {
//             Console.Write("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
//             sbyte choosenOperation = Convert.ToSByte(Console.ReadLine(), CultureInfo.InvariantCulture);
//             Console.Write("Введите первое число");
//             decimal firstNumber = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
//             Console.Write("Введите второе число");
//             decimal secondNumber = Convert.ToDecimal(Console.ReadLine(), CultureInfo.InvariantCulture);
//             return (choosenOperation, firstNumber, secondNumber);
//         }
//         catch
//         {
//             Console.WriteLine("Invalid Input!");
//             return GetInput();
//         }
//     }
//     public static void Main()
//     {
//         do
//         {
//             var (caseNumber, firstNumber, secondNumber) = GetInput();
//             if (caseNumber == 1 || caseNumber == 2 || caseNumber == 3)
//             {
//                 decimal outputNumber = 0.0M;
//                 switch (caseNumber)
//                 {
//                     case 1:
//                         outputNumber = firstNumber + secondNumber;
//                         break;
//                     case 2:
//                         outputNumber = firstNumber - secondNumber;
//                         break;
//                     case 3:
//                         outputNumber = firstNumber * secondNumber;
//                         break;
//                 }
//                 Console.WriteLine($"Результат {outputNumber}");
//                 break;
//             }
//             else
//                 Console.WriteLine("Invalid input!");
//         } while (true);
//     }
// }
