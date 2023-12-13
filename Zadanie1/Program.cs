// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].



// Задаём одномерный массив из 10 целых чисел от 1 до 100.


int[] numbers = GenerateRandomArray(10, 1, 100);

Console.WriteLine("Одномерный массив из 10 целых чисел от 1 до 100:");
PrintArray(numbers);

int count = CountNumbersInRange(numbers, 20, 90);

Console.WriteLine($"Количество элементов в диапазоне [20, 90]: {count}");
    
// Метод для генерации случайного массива заданной длины и диапазона значений.

static int[] GenerateRandomArray(int length, int minValue, int maxValue)

    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }

        return array;
    }

// Метод для вывода массива на экран.

static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }

// Метод для подсчета количества элементов в массиве, значения которых лежат в заданном диапазоне.

static int CountNumbersInRange(int[] array, int min, int max)
    {
        int count = 0;

        foreach (int number in array)
        {
            if (number >= min && number <= max)
            {
                count++;
            }
        }

        return count;
    }