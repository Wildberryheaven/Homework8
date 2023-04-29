// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Clear();
// int[,] CreateRandom2dArray() {
    
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void Show2dArray(int[,] array) {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] ElementsDown(int[,] array) {
//     int[,] newArray = new int[array.GetLength(0),array.GetLength(1)];
//     for (int i = 0, k = 0; i < array.GetLength(0); i++, k++)
//     {
//         for (int l = 0; l < newArray.GetLength(1); l++)
//         {
//             int maxNum = array[i,l];
//             int buffer = array[i,l];
//             int jindex = 0;
//             for (int j = l; j < array.GetLength(1); j++)
//             {
//             if(array[i,j] > maxNum) {
//                 maxNum = array[i,j];
//                 jindex = j;
//             }   

//             }
//             newArray[k, l] = maxNum;
//             array[i,l] = maxNum;
//             array[i,jindex] = buffer;
            
//         }
        
//     }
//     return newArray;
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// Console.WriteLine();
// Show2dArray(ElementsDown(myArray));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// void Show2dArray(int[,] array) {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Show1dArray(int[] array) {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
// Console.Clear();
// int[,] CreateRandom2dArray() {
    
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// int[] SumOfElements(int[,] array) {
//     int[] newArray = new int[array.GetLength(0)];
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < array.GetLength(1); k++)
//             {
//                 sum = sum + array[j,k];
//             }
//             newArray[i] = sum;
//             i++;
//         }
//     }
//     return newArray;
// }

// void NumOfRow(int[] array) {
//     int min = array[0];
//     int line = 1;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < min) {
//             min = array[i];
//             line = i + 1;
//         }
//     }
//     Console.Write($"Номер строки с наименьшей суммой элементов: {line} - я строка");
// }

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// Console.WriteLine();
// Show1dArray(SumOfElements(myArray));
// Console.WriteLine();
// NumOfRow(SumOfElements(myArray));

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Clear();
// int[,] CreateRandom2dArray() {
//     Console.WriteLine("Данные для матрицы");
//     Console.Write("Input a quantity of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a quantity of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
    
//     return array;
// }

// void Show2dArray(int[,] array) {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void MatrixComposition(int[,] array1, int[,] array2) {
//     int[,] newArray = new int[array2.GetLength(0), array2.GetLength(1)];
//     if(array1.GetLength(1) != array2.GetLength(0)) {
//         Console.WriteLine("Перемножение данных матриц невозможно. Кол-во столбцов первой матрицы не равно кол-ву строк второй");
//     } else {
//         for (int i = 0; i < array2.GetLength(0); i++)
//         {
//             for (int j = 0; j < array2.GetLength(1); j++)
//             {
//                 int sum = 0;
//                 for (int k = 0, l = 0; k < array1.GetLength(1); k++, l++)
//                 {
//                     sum = sum + array1[i,k]*array2[l,j];
//                 }
//                 newArray[i,j] = sum;
//             }
//         }
//         for (int i = 0; i < newArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < newArray.GetLength(1); j++)
//             {
//                 Console.Write(newArray[i,j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// int[,] myArray1 = CreateRandom2dArray();
// int[,] myArray2 = CreateRandom2dArray();
// Show2dArray(myArray1);
// Console.WriteLine();
// Show2dArray(myArray2);
// Console.WriteLine();
// MatrixComposition(myArray1, myArray2);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.Clear();

// int[] RandomNums() {
//     int[] numbers = new int[27];
//     for (int i = 0; i < 27; i++)
//     {
//         numbers[i] = new Random().Next(10,100);
//         int checkNumber = numbers[i];
//         for (int j = 0; j < numbers.Length; j++)
//         {
//             while(checkNumber == numbers[j] && j != i) checkNumber = new Random().Next(10,100);   
//         }
//         numbers[i] = checkNumber;
//     }
//     return numbers;
// }
// void PrintRandomNums(int[] array) {
//     for (int i = 0; i < 27; i++)
//     {
//     Console.Write(array[i] + " ");
//     }
// }

// void Print3dArray(int[,,] array) {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write(array[i,j,k]);
//                 Console.Write("(" + $"{i}" + "," + $"{j}" + "," + $"{k}" + ")");
//                 Console.Write(" "); 
//             }
//             Console.WriteLine();
//         }
//     }
// }

// int[,,] Create3dArray(int[] array) {
//     int[,,] arr = new int[3,3,3];
//     for (int i = 0; i < 3; i++)
//     {
//         int l = 0;
//         for (int j = 0; j < 3; j++)
//         {
//             for (int k = 0; k < 3; k++)
//             {
//                 arr[i,j,k] = array[l];
//                 l++;
//             }
//         }
//     }
//     return arr;
// }

// int[] newArray1 = RandomNums();
// int index = newArray1.Length;
// PrintRandomNums(newArray1);
// Console.WriteLine();
// int[,,] ThreeDimArray = Create3dArray(newArray1);
// Print3dArray(ThreeDimArray);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.Clear();

// int[,] SpiralMatrix(int[] iindex, int[] jindex) {
//     int[,] newMatrix = new int[4,4];
//     int start = 1;
//     for (int i = 0; i < 16; i++)
//     {
//         newMatrix[iindex[i],jindex[i]] = start;
//         start++;
//     }
//     return newMatrix;
// }
// void PrintSpiralMatrix(int[,] array) {
//     for (int i = 0; i < 4; i++)
//     {
//         for (int j = 0; j < 4; j++)
//         {
//             Console.Write($"{array[i,j]}" + " ");
//             if(array[i,j] < 10) Console.Write(" ");
//         }
//         Console.WriteLine();
//     }
// }

// int[] iindex = {0,0,0,0,1,2,3,3,3,3,2,1,1,1,2,2};
// int[] jindex = {0,1,2,3,3,3,3,2,1,0,0,0,1,2,2,1}; 
// PrintSpiralMatrix(SpiralMatrix(iindex,jindex));