using System.ComponentModel.Design;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {

        #region Q1 Print Nom btween 1 to Nom
        //int Number;
        //bool Flag;
        //Console.WriteLine("Enter the Number");
        //Flag = int.TryParse(Console.ReadLine(), out Number);
        //for (int i = 1; i <= Number; i++)
        //{
        //    Console.WriteLine(i);
        //}
        #endregion

        #region Q2 insert Nom then * table up to 12
        //int Number;
        //bool Flag;
        //Console.WriteLine("Enter the Number");
        //Flag = int.TryParse(Console.ReadLine(), out Number);
        //for (int i = 1; i <= 12; i++)
        //{
        //    Console.WriteLine($"{Number*i}");
        // }
        #endregion

        #region Q3 insert number then print all even numbers between 1 to this number
        //int Number;
        //bool Flag;
        //Console.WriteLine("Enter the Number");
        //Flag = int.TryParse(Console.ReadLine(), out Number);
        //for (int i = 2; i<= Number ; i +=2)
        //    {
        //       Console.WriteLine(i);
        //   }

        #endregion

        #region Q4 takes two integers then prints the power
        //Console.WriteLine("Enter the Base Number");
        //int BaseNumber = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the Base Power  Number");
        //int powerNumber = int.Parse(Console.ReadLine());
        //int result = 1;
        //for (int i = 0; i < powerNumber; i++)
        //{
        //    result *= BaseNumber;
        //}
        //Console.WriteLine($"Result: {result}");

        #endregion

        #region Q5 enter a string and print the REVERSE of it
        //Console.WriteLine("Enter the Word");
        //string Word = Console.ReadLine();
        //char[] charArray = Word.ToCharArray();
        //Array.Reverse(charArray);
        //string reversed = new string(charArray);
        //Console.WriteLine(reversed);

        #endregion

        #region Q6 find prime numbers within a range of numbers
        //int Number, Value = 0;
        //Console.WriteLine("Enter Number"); 
        //Number = int.Parse(Console.ReadLine());
        //for (int i = 1; i < Number; i++)
        //{
        //    for (int j = 1; j < Number; j++)
        //    {
        //          if (i % j == 0)
        //         {
        //            Value++;
        //        }
        //    }
        //    if (Value == 2)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Value = 0;
        //}

        #endregion

        #region Q7 convert a decimal number into binary without using an array
        //Console.WriteLine("Enter the  Number");
        //int Number = int.Parse(Console.ReadLine());
        //if (Number == 0)
        //{
        //    Console.WriteLine("0");
        //}
        //string Binary="";
        //while(Number> 0)
        //{
        //    Binary = (Number % 2) + Binary;
        //    Number /= 2;
        //}
        //Console.WriteLine(Binary);

        #endregion


        #region Q8 prints an identity matrix using for loop
        //Console.WriteLine("Enter size of Matrix");
        //int size =int.Parse(Console.ReadLine());
        //for (int i = 0; i < size; i++)
        //{
        //    for (int j = 0; j < size; j++)
        //    {
        //        if (i == j)
        //            Console.WriteLine("1");
        //        else Console.WriteLine("0");
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region Q9 Write C# program that Extract a substring from a given string.

        //Console.WriteLine("Enter the Syntic");
        //string Word = Console.ReadLine();
        //Console.WriteLine("Enter the index you want");
        //int Index_of_Word = int.Parse(Console.ReadLine());
        //if (Index_of_Word >= 0 && Index_of_Word < Word.Length)

        //    {
        //    string New_Word = Word.Substring(Index_of_Word);
        //    Console.WriteLine(New_Word);
        //}
        //else
        //{
        //    Console.WriteLine(" Invalid Start Postion");
        //}
        #endregion

        #region Q 10 Write C# program that take two string variables and print them as one variable 
        //Console.WriteLine("Enter the first word");
        //string First_Word =Console.ReadLine();
        //Console.WriteLine("Enter the Second word");
        //string Second_Word = Console.ReadLine();
        //string Full_Word =First_Word + Second_Word;
        //Console.WriteLine ( "The Full Word is " +Full_Word);

        #endregion

        #region Q11 It is The Same As Question 8
        //Console.WriteLine("Enter size of Matrix");
        //int size =int.Parse(Console.ReadLine());
        //for (int i = 0; i < size; i++)
        //{
        //    for (int j = 0; j < size; j++)
        //    {
        //        if (i == j)
        //            Console.WriteLine("1");
        //        else Console.WriteLine("0");
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region Q12 Write a program in C# Sharp to find the sum of all elements of the array.
        //Console.WriteLine("Enter the Number Of Array");
        //int Number = int.Parse(Console.ReadLine());
        //int[]array = new int[Number];
        //int Sum = 0;
        //Console.WriteLine("Enter Element Of Array");
        //for (int i = 0; i < Number; i++)
        //{
        //    Console.WriteLine($"Element{i+1}");
        //    array[i]=int.Parse(Console.ReadLine());
        //    Sum +=array[i];
        //    Console.WriteLine(Sum);
        //}    
        #endregion

        #region Q13  Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
        //Console.WriteLine("Enter the Size Of Array");
        //int Size = int.Parse(Console.ReadLine());
        //int[] array1 = new int[Size];
        //int[] array2 = new int[Size];
        //int[] Merge_Array = new int[Size *2];
        //Console.WriteLine("Enter the Element about Array1");
        //for (int i = 0; i < Size; i++)
        //{
        //    Console.Write($"Element {i + 1} ");
        //    array1[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("Enter the Element about Array2");
        //for (int i = 0; i < Size; i++)
        //{
        //    Console.Write($"Element {i + 1} ");
        //    array2[i] = int.Parse(Console.ReadLine());
        //}

        //   for(int i=0; i<Size; i++)
        //    {
        //        Merge_Array[i] = array1[i];
        //        Merge_Array[i+Size] =array2[i];
        //    }
        //   Array.Sort(Merge_Array);
        //    Console.WriteLine("Merage is");
        //foreach (int element in Merge_Array) {
        //    Console.WriteLine(element);

        //}

        #endregion

        #region Q14 Write a program in C# Sharp to count the frequency of each element of an array.
        //Console.WriteLine("Entr Size of Array");
        //int Size = int.Parse(Console.ReadLine());
        //int[] arr1 = new int[Size];
        //bool[] visited = new bool[Size];

        //Console.WriteLine("Enter the Element of Array");
        //for (int i = 0; i < Size; i++)
        //{
        //    Console.WriteLine($"Element {i + 1}");
        //    arr1[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("The Number of Array ");
        //Console.WriteLine(string.Join(", ", arr1));

        //Console.WriteLine("Number anf Frequency");
        //for (int i = 0; i < Size; i++)
        //{
        //    if (visited[i]) continue;
        //    int count = 1;
        //    for (int j = i + 1; j < Size; j++)
        //    {
        //        if (arr1[i] == arr1[j])
        //        {
        //            count++;
        //            visited[j] = true; 
        //        }
        //    }
        //    Console.WriteLine($"Number {arr1[i]} appears {count} ");
        //}


        #endregion


        #region Q15 Write a program in C# Sharp to find maximum and minimum element in an array
        //Console.WriteLine("Entr Size of Array");
        //int Size = int.Parse(Console.ReadLine());
        //int[] arr = new int[Size];

        //Console.WriteLine("Enter the Element of Array");
        //for (int i = 0; i < Size; i++)
        //{
        //    Console.WriteLine($"Element {i + 1}");
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
        //int Max = arr[0];
        //int Min = arr[0];
        //for (int i = 1; i < Size; i++)
        //{
        //   if (arr[i] > Max)
        //    {
        //        Max = arr[i];
        //    }
        //    if (arr[i] < Min)
        //    {
        //        Min = arr[i];
        //    }
        //}
        //Console.WriteLine($"Max Element in the Array Array{Max}");
        //Console.WriteLine($"Min Element in The Arrar Array{Min}");
        #endregion


        #region Q16 - Write a program in C# Sharp to find the second largest element in an array.
        //Console.WriteLine("Entr Size of Array");
        //int Size = int.Parse(Console.ReadLine());
        //int[] arr = new int[Size];

        //Console.WriteLine("Enter the Element of Array");
        //for (int i = 0; i < Size; i++)
        //{
        //    Console.WriteLine($"Element {i + 1}");
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
        //int Max = arr[0];
        //int Maxindex = 0;

        //for (int i = 1; i < Size; i++)
        //{
        //    if (arr[i] > Max)
        //    {
        //        Max = arr[i];
        //        Maxindex = i;
        //    }
        //}
        //arr[Maxindex] = -1;
        //int Second_Largest =arr[0];
        //for (int i = 1;i < Size; i++)
        //{
        //    if (arr[i] > Second_Largest)
        //    { 
        //        Second_Largest = arr[i];
        //    }
        //}
        //Console.WriteLine($"The Second Largest Elemnt{Second_Largest}");
        #endregion

        #region Q17 Consider an Array of Integer values with size N, having values
        //Console.WriteLine("Entr Size of Array");
        //int Size = int.Parse(Console.ReadLine());
        //int[] arr = new int[Size];

        //Console.WriteLine("Enter the Element of Array");
        //for (int i = 0; i < Size; i++)
        //{
        //    Console.WriteLine($"Element {i + 1}");
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
        //Dictionary<int,int>FirstIndex = new Dictionary<int,int>();
        //int MaxDistanse = 0;
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    if (!FirstIndex.ContainsKey(arr[i]))
        //    {
        //        FirstIndex[arr[i]] = i;

        //    }
        //    else
        //    {
        //        int Distanse = i - FirstIndex[arr[i]];
        //        MaxDistanse = Distanse;
        //    }
        //}
        //Console.WriteLine($"The Largest Detanse{MaxDistanse}");

        #endregion

        #region Q18 create two multidimensional arrays of same size
        //Console.WriteLine("Entr The NUmber of Rows");
        //int Rows = int.Parse(Console.ReadLine());
        //Console.WriteLine("Entr The NUmber of Coulmns");
        //int Coulmns = int.Parse(Console.ReadLine());

        //int[,] arr1 = new int[Rows,Coulmns];
        //int[,] arr2 = new int[Rows, Coulmns];

        //Console.WriteLine("Enter the Element of Array");
        //for (int i = 0; i < Rows; i++)
        //{
        //    for (int j = 0; j < Coulmns; j++)
        //    {
        //        Console.WriteLine($"Element[ {i},{j}]");
        //        arr1[i, j] = int.Parse(Console.ReadLine());
        //    }
        //}
        //for (int i = 0; i < Rows; i++)
        //{
        //    for (int j = 0; j < Coulmns; j++)
        //    {
        //        Console.WriteLine($"Element[ {i},{j}]");
        //        arr2[i, j] = int.Parse(Console.ReadLine());
        //    }
        //}
        //Console.WriteLine("Second Array");
        //for(int i = 0;i < Rows; i++)
        //{
        //    for(int j = 0;j < Coulmns; j++)
        //    {
        //        Console.WriteLine(arr2[i, j]);
        //    }
        //}
        #endregion

        #region Q19 Write a Program to Print One Dimensional Array in Reverse Order
        //Console.WriteLine("Entr Size of Array");
        //int Size = int.Parse(Console.ReadLine());
        //int[] arr = new int[Size];

        //Console.WriteLine("Enter the Element of Array");
        //for (int i = 0; i < Size; i++)
        //{
        //    Console.WriteLine($"Element {i + 1}");
        //    arr[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine(" Array in Reverse Order");
        //for (int i = Size-1;i >= 0;i--)
        //{
        //    Console.WriteLine(arr[i]);
        //}

            #endregion


        }
    }