// Задача 4
// Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе 
// массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.


// Вводим натуральное число от 1 до 100000

        Console.Write("Введите натуральное число от 1 до 100000: ");
        int number = int.Parse(Console.ReadLine());

        // Создаем массив для хранения цифр числа
        int[] digits = ExtractDigits(number);

        // Выводим массив на экран
        Console.WriteLine("Массив цифр числа:");
        foreach (int digit in digits)
        {
            Console.Write(digit + " ");
        }

        Console.ReadLine();

    // Метод для извлечения цифр числа и создания массива
    static int[] ExtractDigits(int number)
    {
        // Определяем количество цифр в числе
        int count = CountDigits(number);

        // Создаем массив нужного размера
        int[] digits = new int[count];

        // Извлекаем цифры и записываем их в массив
        for (int i = 0; i < count; i++)
        {
            digits[i] = number % 10; // Получаем последнюю цифру числа
            number /= 10; // Убираем последнюю цифру из числа
        }

        // Переворачиваем массив, чтобы старший разряд был на 0-м индексе
        Array.Reverse(digits);

        return digits;
    }

    // Метод для подсчета количества цифр в числе
    static int CountDigits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }