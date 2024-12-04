using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целочисленные числа без пробела, через запятую:");
        string[] nums = Console.ReadLine().Split(',');
        int[] array = new int[nums.Length];
        int searchForZeros = 0;

        // Проверяем ввод и заполняем массив
        for (int i = 0; i < nums.Length; i++)
        {
            // Проверяем, является ли строка числом
            if (int.TryParse(nums[i], out array[i]) == false)
            {
                Console.WriteLine($"'{nums[i]}' не является допустимым целым числом.");
                return; // Выход из программы при ошибочном вводе
            }
        }

        // Перемещение ненулевых элементов
        int lastNonZeroIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                array[lastNonZeroIndex] = array[i];
                lastNonZeroIndex++;
            }
        }

        // Заполнение оставшихся мест нулями
        for (int i = lastNonZeroIndex; i < array.Length; i++)
        {
            array[i] = 0;
        }

        if (array.Length > 2)
        {
            // Вывод результата
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }else
        {
            Console.WriteLine("Неверный ввод, попробуйте снова");
        }
    }
}
