
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int size = ReadInt("Enter array dimension: ");
// int [] numbers = new int[size];


// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int result = 0;


// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     {
//         result++;
//     }
// }


// if (result % 10 == 1)
// {
//     Console.WriteLine($"In array {result} even number");
// }
// if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
// {
//     Console.WriteLine($"In array {result} even numbers");
// }


// else

//     Console.WriteLine($"In array {result} even numbers");


// void FillArrayRandomNumbers(int [] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(99, 999);
//     }
// }



// void PrintArray(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }




// int ReadInt(string message)  
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// int size = ReadInt("Enter array dimension: ");
// int min = ReadInt("Enter arrays min number: ");
// int max = ReadInt("Enter arrays max number: ");
// int [] numbers = new int[size];



// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int result = 0;



// for (int i = 0; i < numbers.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         result += numbers[i];
//     }
// }
// Console.WriteLine($"summ elements odd position = {result}");




// void FillArrayRandomNumbers(int [] array) 
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
// }

// void PrintArray(int[] array)

// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }



// int ReadInt(string message)  
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int size = 15;
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);


// int max = numbers[0];
// int min = numbers[0];



// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
//     else if (numbers[i] < min)
//     {
//         min = numbers[i];
//     }
// }


// Console.WriteLine($"min number: {min}");
// Console.WriteLine($"min number: {max}");
// Console.WriteLine($"The difference between the maximum ahd minimum: {max-min}");



// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 555);
//     }
// }



// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
