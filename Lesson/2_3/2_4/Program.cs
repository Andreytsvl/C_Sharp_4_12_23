void ThirdNum(int num)
{
    if (num<100)
    {
        Console.WriteLine("There is no third digit");
        return;
    }
    while (num>999)
        num/=10;
    Console.WriteLine (num%10);    
    {
        
    }
}

int a = int.Parse(Console.ReadLine()!);
ThirdNum(a);