using System;

// bool, byte, sbyte, short, char, int, float, double, long, decimal
// string? input = Console.ReadLine();
//
// if (input != null)
// {
//     var result = double.Parse(input);
//     
//     Console.WriteLine(result * 2);
// }


// Arrays
// int[] arr = { 10, 20, 30 };
// int[] arr1 = new int[3] { 10, 20, 30 };
// int[] arr2 = new int[6];
// int[] arr3 = [10, 20, 30]; // NET 8 only
//
//
// // var random = new Random();
//
// for (int i = 0; i < arr2.Length; i++)
// {
//     //arr2[i] = random.Next(10, 99);
//     arr2[i] = Random.Shared.Next(10, 99);
// }

// Multidimensional Arrays

// int[,] mdArr = new int[4,5]
// { 
//   // 0   1   2   3   4
//     {10, 20, 30, 40, 50}, // 0
//     {11, 24, 38, 44, 59}, // 1
//     {12, 25, 37, 43, 52}, // 2
//     {13, 26, 36, 42, 51}, // 3
// };
//
//
// // Console.WriteLine(mdArr[1, 1]);
// Console.WriteLine($"Length = {mdArr.Length}");
// Console.WriteLine($"Rank = {mdArr.Rank}");
//
// for (int i = 0; i <= mdArr.GetUpperBound(0); i++)
// {
//     Console.Write("{ ");
//     for (int j = 0; j <= mdArr.GetUpperBound(1); j++)
//     {
//         Console.Write($"{mdArr[i, j]} ");
//     }
//
//     Console.WriteLine("}");
// }

// Jagged Arrays
// int[][] jagged = new int[3][];
//
// jagged[0] = new int[4];
// jagged[1] = new int[3];
// jagged[2] = new int[2];
//
// for (int i = 0; i < jagged.Length; i++)
// {
//     for (int j = 0; j < jagged[i].Length; j++)
//     {
//         jagged[i][j] = Random.Shared.Next();
//     }
// }
//
// for (int i = 0; i < jagged.Length; i++)
// {
//     Console.Write("{ ");
//     for (int j = 0; j < jagged[i].Length; j++)
//     {
//         Console.Write($"{jagged[i][j]} ");
//     }
//     Console.WriteLine("}");
// }


// Lists
// List<int> values = new List<int>();
//
// values.Add(10);
// values.Add(20);
// values.Add(30);
//
// foreach (var value in values)
// {
//     Console.WriteLine(value);
// }

// int?[]? arr = new int?[] { null, 42, null, 13 };
//
// Console.WriteLine(arr[0]);
//
// Console.ReadLine();


// null conditional
// string? text = null;

// var result = text?.ToUpper(); // null conditional

// if (text != null)
// {
//     var result = text.ToUpper();
// }


// null coalescenting operator

// string? fathersName = null;
//
// var res = fathersName ?? "Fathers name not specified";


// string text = "Hello C++";
//
// var result = text.Replace("C++", "C#");
//
// Console.WriteLine(result[^2..]);

string?[] values = new string[3];

Console.WriteLine(values[0] == null);
Console.WriteLine(values[1] == null);
Console.WriteLine(values[2] == null);

string val = default;
int? intValue = default;

Console.WriteLine($"val = {val}");
Console.WriteLine($"intValue = {intValue}");


char c = Convert.ToChar(65);

Console.WriteLine(c);






Console.ReadLine();