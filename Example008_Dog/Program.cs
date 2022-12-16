int cont = 0;
int S1 = 0, t = 0;
int D = 0;

Console.Clear();
Console.WriteLine("Задача : Сколько раз пробежит Собака между друзьями которые идут друг другу на встречу с разной скоростью");
Console.WriteLine();
Console.WriteLine("Для начала введите данные: ");
Console.WriteLine();

Console.Write("Введите Имя собаки, ");
string AS = Console.ReadLine();

Console.Write("Введите растояние между друзьями, ");
int S = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите скорость первого друга, ");
int V1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите скорость второго друга, ");
int V2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите скорость собаки, ");
int V3 = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine($"Скорость одного {V1}, другого {V2}, а собаки {V3} ");
Console.WriteLine($"Растояние между друзьми {S} ");
Console.WriteLine();

while(S > 20)
{
    if(D == 0)
    {
        t = S / (V1 + V3);
        S1 = V1 * t;
        D = 1;
    }
    if(D == 1)
    {
        t = S / (V2 + V3);
        S1 = V2 * t;
        D = 0;
    }

     S = S - S1;
     cont++;

}
Console.WriteLine();
Console.Write("Собака по кличке ");
Console.Write(AS);
Console.Write(" пробежала раз = ");
Console.WriteLine(cont);
