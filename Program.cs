

Console.WriteLine("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"Натуральные числа в промежутке {numberM} и {numberN} кратные трём = " );
Numberall(numberM, numberN);

void Numberall(int numberA, int numberN)
{
    
    if (numberA >= numberN) return;
    
    else if (numberA % 3 == 0)
    {
        Console.Write( numberA + "; " );
        
    }
    numberA++;
    Numberall (numberA, numberN);

}
