// Задача 3. 
// Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр. Использовать рекурсию.

int ValueSet(int num)
{
    if (num == 0) return 0;
    return ValueSet(num / 10) + num % 10;

}

Console.Write(ValueSet(1234));
Console.WriteLine();