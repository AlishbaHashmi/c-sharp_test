// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Give Array = [1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38]

//int[] Array = new int[14];
//Array[0] = 1;
//Array[1] = 3;
//Array[2] = 42;
//Array[3] = 20;
//Array[4] = 97;
//Array[5] = 65;
//Array[6] = 88;
//Array[7] = 43;
//Array[8] = 64;
//Array[9] = 20;
//Array[10] = 12;
//Array[11] = 48;
//Array[12] = 24;
//Array[13] = 38;


//Q1
//Find the sum of all the integers in the array.

//int sum = 0;
//for(int i=0; i< Array.Length; i++)
//{
//    sum += Array[i];
//}

//Console.WriteLine($"The sum of Array is : {sum}");



//Q2
//Find the maximum and minimum values in the array.

//var max = Array.Max();
//Console.WriteLine($"The maximum value in the array is : {max}");

//var min = Array.Min();
//Console.WriteLine($"The minimum value in the array is : {min}");



//Q3
//Count the number of even and odd integers in the array.

//int evenCount = 0;
//int oddCount = 0;

//foreach (var count in Array)
//{
//    if (count % 2 == 0)
//    {
//        evenCount++;
//    }
//    else
//    {
//        oddCount++;
//    }
//}

//Console.WriteLine($"Count of even numbers in the array are : {evenCount} ");
//Console.WriteLine($"Count of odd numbers in the array are :  {oddCount} " );



//Q4
//Calculate the average of all the integers in the array.

//var avg = Array.Average();
//Console.WriteLine($" The average of all integers in the array is : {avg} ");



//Q5
//Check if a specific integer is present in the array.

//int specific_integer = 65;
//bool isPresent = false;

//for (int i = 0; i <Array.Length; i++)
//{
//    if (Array[i] == specific_integer)
//    {
//        isPresent = true;
//        break;
//    }
//}

//if (isPresent)
//{
//    Console.WriteLine($"The {specific_integer} integer is present in the array.");
//}
//else
//{
//    Console.WriteLine($"The {specific_integer} integer is not present in the array.");
//}




//Q6
//Create a program that finds the sum of all elements in a two-dimensional array (matrix).

//int[,] matrix = new int[3, 3]
//{
//    {1,2,3},
//    {4,5,6},
//    {7,8,9}
//};
//int sum = 0;
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        sum += matrix[i, j];
//    }
//}

//Console.WriteLine($"The sum of all elements in a two-dimensional array (matrix) is : {sum}");




//Q7
//Write a function to calculate the area of a rectangle the length of the rectangle is 20cm and the width is 12cm.

//int length = 20;
//int width = 12;
//int area = length * width;

//Console.WriteLine($"The area of a rectangle is : {area}");




