/*
Напишите цикл, который принимает на вход два числа (A и B)
      и возводит число A в натуральную степень B.          
3, 5 -> 243 (3⁵)
2, 4 -> 16                */

int GetNumber()
{
    while(true)
    {
        string enteredValue = Console.ReadLine();
        if(int.TryParse(enteredValue, out int number))
            return number;
        else
            Console.WriteLine("Ошибка! Ведите число!");
    }   
}

int Degree(int intA, int intB)
{
    int result = intA;
    for (int i = 1; i < intB; i++)
        result *= intA; 
    return result;
}


Console.WriteLine("Для вычисления формулы A в степени B");
Console.Write("Введите число A=");
int intA = GetNumber();
Console.Write("Введите число B=");
int intB = GetNumber();

System.Console.WriteLine($"Рещультат = {Degree(intA, intB)}");
Console.ReadKey();