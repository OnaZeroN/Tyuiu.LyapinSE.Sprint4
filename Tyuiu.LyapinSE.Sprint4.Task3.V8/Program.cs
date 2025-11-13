using Tyuiu.LyapinSE.Sprint4.Task3.V8.Lib;

DataService ds = new();

Console.Title = "Спринт #4 | Выполнил: Ляпин С. Е. | ИИПб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Ляпин Степан Евгеньевич | ИИПб-25-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* статическими значениями в диапазоне от 2 до 8.                          *");
Console.WriteLine("* Найдите минимальный элемент в четвертом столбце массива.                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] matrix =
{
    { 4, 8, 3, 4, 8 },
    { 5, 3, 5, 7, 8 },
    { 3, 7, 2, 7, 7 },
    { 5, 2, 4, 6, 4 },
    { 4, 4, 6, 7, 2 }
};

Console.WriteLine("Массив: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Минимальный элемент в четвертом столбце массива: " + ds.Calculate(matrix));

Console.ReadKey();