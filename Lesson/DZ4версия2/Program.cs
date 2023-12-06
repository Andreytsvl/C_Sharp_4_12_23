// Напишите программу, которая на вход принимает натуральное число N,
//а на выходе показывает его цифры через запятую.
 Console.WriteLine("Введите натуральное число:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Цифры числа {0} через запятую: ", n);

        string digits = string.Empty;

        while (n > 0)
        {
            int digit = n % 10;
            digits = digit + "," + digits;
            n /= 10;
        }

        digits = digits.TrimEnd(',');

        Console.WriteLine(digits);

        Console.ReadLine();
