/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

string GetNumber()
{
    while(true)
    {
        string enteredValue = Console.ReadLine();
        if(int.TryParse(enteredValue, out int number))
            return enteredValue;
        else
            Console.WriteLine("Ошибка! Ведите число!");
    }   
}


int SummDigits(string number, bool method)
{
    if (method)
    {
    // Первый метод решения
    int lenghtOfNumber = number.Length;
    int result = 0;
    for (int i = 0; i < lenghtOfNumber; i++) 
        result += Convert.ToInt32(number[i]- '0');
    return result;
    }
    else
    {
    // Второй метод решения
        int summ = 0;
        int intNumber = int.Parse(number);
        while(intNumber > 0)
        {
            summ += intNumber % 10;
            intNumber /=  10;
        }
        return summ;
    }
}


Console.WriteLine("Для вычисления суммы цифр в числе");
Console.Write("Введите число X=");
string number = GetNumber();
Console.Write("Введите метод (способ) решения задачи 0 или 1 = ");
bool method = Convert.ToBoolean(Convert.ToByte(GetNumber()));

System.Console.WriteLine($"Результат = {SummDigits(number, method)}");
Console.ReadKey();