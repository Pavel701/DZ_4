﻿//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵), 2, 4 -> 16

    // Console.Write("Введите число A: ");
    // int a = int.Parse(Console.ReadLine());

    // Console.Write("Введите число B: ");
    // int b = int.Parse(Console.ReadLine());

    // int result = 1;

    // for (int i = 1; i <= b; i++) {
    //   result *= a;
    // }

    // Console.WriteLine($"{a}^{b} = {result}");
  
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11


    // Console.Write("Введите число: ");
    // int number = int.Parse(Console.ReadLine());

    // int sum = 0;

    // while (number > 0) {
    //   int digit = number % 10;
    //   sum += digit;
    //   number /= 10;
    // }

    // Console.WriteLine($"Сумма цифр числа: {sum}");
  

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

    int[] numbers = new int[8] { 2, 5, 7, 1, 8, 4, 6, 3 };

    Console.WriteLine("Элементы массива:");

    for (int i = 0; i < numbers.Length; i++) {
      Console.Write($"{numbers[i]} ");
    }

    Console.WriteLine();


