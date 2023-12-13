// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.



// Создаём случайный массив из 10 целых чисел от 1 до 100.

int[] numbers = GenerateRandomArray(10, 1, 100);

Console.WriteLine("Массив:");
PrintArray(numbers);

// Вызываем метод, который подсчитывает количество четных чисел в массиве.

int countEvenNumbers = CountEvenNumbers(numbers);

Console.WriteLine($"Количество четных чисел в массиве: {countEvenNumbers}");

// Метод для создания случайного массива заданной длины и диапазона значений.

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

// Метод для подсчета количества четных чисел в массиве.

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (int number in array)
        {
// Проверяем, является ли текущее число четным.

            if (number % 2 == 0)
            {
// Если число четное, увеличиваем счетчик.

                count++;
            }
        }

// Возвращаем окончательный результат.

        return count;
    }



/* foreach - инструкция языка C#, предназначенная для удобного перебора 
элементов в коллекции (в данном случае, в массиве). 
Она автоматически обеспечивает итерацию по всем элементам 
коллекции без явного использования индексов.

В данном случае, foreach используется для перебора элементов массива array, 
и на каждой итерации значение текущего элемента присваивается переменной number. 
Затем это значение выводится на экран с помощью Console.Write($"{number} ");.

В методе CountEvenNumbers также используется foreach для проверки 
каждого элемента массива на четность и увеличения счетчика count, если число четное.

foreach упрощает процесс перебора элементов массива и обеспечивает более чистый и читаемый код. */