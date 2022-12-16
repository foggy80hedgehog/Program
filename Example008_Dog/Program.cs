int V1 = 5,  
    V2 = 7,  
    V3 = 12; 
int cont = 0;
int S = 900, S1 = 0, t = 0;
int D = 0;
Console.Clear();
Console.WriteLine("Задача : Сколько раз пробежит Собака между друзьями которые идут друг другу на встречу с разной скоростью");
Console.WriteLine();
Console.Write("Введите Имя собаки, ");
string AS = Console.ReadLine();



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
