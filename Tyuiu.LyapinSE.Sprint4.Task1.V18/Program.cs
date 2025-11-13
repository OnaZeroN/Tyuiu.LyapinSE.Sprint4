using Tyuiu.LyapinSE.Sprint4.Task1.V18.Lib;

DataService ds = new();

Console.Title = "Спринт #4 | Выполнил: Ляпин С. Е. | ИИПб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Ляпин Степан Евгеньевич | ИИПб-25-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов заполненный         *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 9 подсчитать сумму          *");
Console.WriteLine("* нечетных элементов массива.                                             *");
Console.WriteLine("* С клавиатуры: 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int len;
Console.WriteLine("Введите количество элементов масива: ");
len = Convert.ToInt32(Console.ReadLine());

int[] numsArray = new int[len];

for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine("Введите значение " + i + " элемента массива: ");
    numsArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine(numsArray[i] + "\t");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(numsArray));

Console.ReadKey();