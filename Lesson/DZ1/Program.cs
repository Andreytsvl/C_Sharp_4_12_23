Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 7 == 0 && number % 23 == 0)
        {
            Console.WriteLine("Число является кратным как 7, так и 23.");
        }
        else
        {
            Console.WriteLine("Число не является кратным как 7, так и 23.");
        }
        
        Console.ReadLine();

