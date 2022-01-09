using System;
// 3. С клавиатуры вводятся числа, пока не будет введен 0.
// Подсчитать сумму всех нечетных положительных чисел.

{
    int sum = 0;
    int num = 0;
 
    do
    {
        num = int.Parse(Console.ReadLine());
        if (num > 0 && num % 2 == 1)
            sum += num;
 
    } while (num != 0);
 
    Console.WriteLine("Сумма: " + sum);
}

