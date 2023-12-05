//Напишите программу, которая принимает на вход целое число из отрезка [10;99]
// выводит наибольшую цифру из числа
  Console.WriteLine("Введите число от 10 до 99:");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxDigit = 1;

        while (number > 0)
        {
            int digit = number % 10;
            if (digit > maxDigit)
            {
                maxDigit = digit;
            }

            number /= 10;
        }

        Console.WriteLine("Наибольшая цифра в числе: " + maxDigit);