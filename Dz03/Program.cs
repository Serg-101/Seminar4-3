/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
*/

void FillList(int[] list)
{
Random rnd = new Random();
for (int i = 0; i < list.Length; i++)
    list[i] = rnd.Next(1, 100);
}

void PrintList(int[] list)
{
    Console.Write($"[{list[0]}");
    for (int i = 1; i < list.Length; i++)
    {
        Console.Write($", {list[i]}");
    }
    Console.Write("]");
}


int arrayLenght = 8; //Размер массива
int[] list = new int[arrayLenght];
FillList(list);
PrintList(list);