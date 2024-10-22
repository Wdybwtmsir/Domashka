try
{
    Console.WriteLine("ВНИМАНИЕ!УЗРИТЕ!ТАБЛИЦА ПЕРЕВОДА ДЮЙМОВ В САНТИМЕТРЫ!!!!!!");
    const double t=2.54;
    for (int i = 1; i <= 20; i++) 
    {
        double c = i * t;
        Console.WriteLine($"{i}\t{c:F2}");
    }    
}
catch
{
    Console.WriteLine("Введите правильные значения!");
}