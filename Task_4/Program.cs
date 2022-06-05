// Задача 4. Решение в группах задач
// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

int ValueSet(int n, int m)
{
    if (m == 0) return 1;
    return ValueSet(n, m - 1) * n;
}

Console.WriteLine(ValueSet(2, 3));