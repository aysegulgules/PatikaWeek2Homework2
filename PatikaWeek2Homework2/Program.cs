int i = 1;
//while uygulama 1
while(i<=10)
{
    Console.WriteLine($"{i}- Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}
Console.Write("\n--------------------------------\n ");


i= 1;
//while uygulama 2
Console.WriteLine("\n\n 1 ile 20 arasındaki sayılar\n");
while (i <= 20)
{
    
    Console.Write($"{i}  ");
    i++;
}
Console.Write("\n--------------------------------\n ");


i= 1;
//while uygulama 3
Console.WriteLine("\n\n 1 ile 20 arasındaki çift sayılar\n");
while(i<=20)
{
    if (i % 2 == 0)
        Console.Write($"{i}  ");
    i++;
}
Console.Write("\n--------------------------------\n ");


i= 50;
//while uygulama 4
Console.Write("\n\n 50 ile 150 arasındaki sayıların toplamı...:");
int sum = 0;
while (i<= 150)
{
    sum += i;
    i++;
}
Console.WriteLine($"{sum}");
Console.Write("\n--------------------------------\n ");

i = 1;
//while uygulama 5
Console.WriteLine("\n\n 1 ile 120 arasındaki tek ve çift sayıların toplamları\n");
int evenNumberSum = 0;
int oddNumberSum = 0;
while ( i <= 120)
{
    if (i % 2 == 0)
        evenNumberSum += i;
    else

        oddNumberSum += i;

    i++;
}
Console.WriteLine($"Tek sayıların toplamı...={oddNumberSum}");
Console.WriteLine($"Çift sayıların toplamı...={evenNumberSum}");


