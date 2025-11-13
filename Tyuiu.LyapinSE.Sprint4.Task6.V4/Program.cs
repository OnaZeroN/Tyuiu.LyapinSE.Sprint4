using Tyuiu.LyapinSE.Sprint4.Task6.V4.Lib;

DataService ds = new();

Console.Title = "Спринт #4 | Выполнил: Ляпин С. Е. | ИИПб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Класс Array                                                       *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Ляпин Степан Евгеньевич | ИИПб-25-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан строковый массив данных [\"Москва\", \"Санкт Петербург\", \"Самара\"      *");
Console.WriteLine("* \"Новосибирск\", \"Екатеринбург\", \"Нижний Новгород\", \"Казахстан\"],         *");
Console.WriteLine("* используя класс Array, выведите элементы массива,                       *");
Console.WriteLine("* длина которых меньше 7 символов.                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string[] array = ["Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара"];


Console.WriteLine("Исходный массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Элементы массива, длина которых меньше 7 символов: ");

string[] res = ds.Calculate(array);

for (int i = 0; i < res.Length; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();
