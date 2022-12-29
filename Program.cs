// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

void cube (int N)
{
    for(int i = 1; i < N + 1; i = i + 1)
    {
        int temp = i*i*i;
        if (i < N)
        {Console.Write($"{temp},");}
        else
        {Console.Write($"{temp}");}
    }
}

cube(N);