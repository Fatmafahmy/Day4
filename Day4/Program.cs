using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Loop Statment 
        //for (int i = 1; i <= 10; i++)
        //{ 
        //    Console.WriteLine($"{i} T");
        //}
        #endregion

        #region For - Foreach
        // int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // For loop it works on the original loop
        //for (int i = 0; i < Numbers.Length; i++)
        //{
        //    // Numbers[i] += 10;
        //    if (Numbers[i] == 5)
        //    {
        //        //break; // To Stop Array
        //        continue; // print all Number but not 5
        //    }

        //    Console.WriteLine(Numbers[i] + 10);
        //}

        // Class Implinemt interface IEnummrable
        // For each loop it works on a copy loop
        //foreach (int Number in Numbers)
        //{
        //   // Numbers += 10; // Invalid
        //    Console.WriteLine(Number +10);
        //}
        #endregion

        #region While -Do While
        //int Number;
        //bool Flag;
        //do  
        //{
        //    Console.WriteLine("Enter Even Number");
        //     //Number = int.Parse(Console.ReadLine());
        //    Flag= int.TryParse(Console.ReadLine(), out Number); 
        //}
        //while (Number %2 == 1 || !Flag);

        //Console.WriteLine($"{Number} is Even");

        //int Number = 3;
        //bool Flag = false;
        //while (Number % 2 == 1 || !Flag) 
        //{
        //    Console.WriteLine("Enter Even Number");
        //     Flag= int.TryParse(Console.ReadLine(), out Number); 
        // }
        //Console.WriteLine($"{Number} is Even");

        #endregion

        #region  String
        //Class => Referance type
        //Immutable Data Tyoe[Value can not changed]
        //Array of Chars
        //A H M E D

        //string Name;

        //Name = new string("Ahmed");

        //Name = "Ahmed"; //Syntax sugar 

        //string Name01 = "Ahmed";
        //string Name02 = "Ahmed";

        //Console.WriteLine(Name01);
        //Console.WriteLine($"Name01 HC: {Name01.GetHashCode()}");
        //Console.WriteLine(Name02);
        //Console.WriteLine($"Name02 HC: {Name02.GetHashCode()}");


        //string Name01 = "Ahmed";
        //string Name02 = "Ali";

        //Console.WriteLine(Name01);
        //Console.WriteLine($"Name01 HC: {Name01.GetHashCode()}");
        //Console.WriteLine(Name02);
        //Console.WriteLine($"Name02 HC: {Name02.GetHashCode()}");

        //Name02 = Name01;

        //Console.WriteLine("********** Name02 = Name01********");
        //Console.WriteLine(Name01);
        //Console.WriteLine($"Name01 HC: {Name01.GetHashCode()}");
        //Console.WriteLine(Name02);
        //Console.WriteLine($"Name02 HC: {Name02.GetHashCode()}");

        //Name01= "Mostafa";

        //Console.WriteLine("**********  Name01= Mostafa********");
        //Console.WriteLine(Name01);
        //Console.WriteLine($"Name01 HC: {Name01.GetHashCode()}");
        //Console.WriteLine(Name02);
        //Console.WriteLine($"Name02 HC: {Name02.GetHashCode()}");

        //string Message = "Hello";
        //Console.WriteLine(Message);
        //Console.WriteLine(Message.GetHashCode());

        //Message += "Route ";
        //Console.WriteLine(Message);
        //Console.WriteLine(Message.GetHashCode());

        #endregion

        #region StringBuilder
        //StringBuilder Message;
        //Message = new StringBuilder("Hello");
        //Console.WriteLine(Message);
        //Console.WriteLine(Message.GetHashCode());
        //Message.Append("Route");
        //Console.WriteLine(Message);
        //Console.WriteLine(Message.GetHashCode());

        #endregion

        #region StringBuilder Methods
        //StringBuilder Message = new StringBuilder("Welcome");

        //Message.Append("To Route");
        //Message.AppendLine("Mostafa");
        //Message.Append("Hany");
        //Console.WriteLine(Message);

        //Message.Remove(0, 7);
        //Console.WriteLine(Message);

        //Message.Insert(0, "Hallo");
        //Console.WriteLine(Message);

        //Console.WriteLine();
        //int age = 10;
        //string Name = "Ali";
        //Message.AppendFormat("Name : {0} , Age : {1}" ,Name,age);

        //Message.AppendJoin("/", "Mostafa ", "Hany", "Mohamed", 2);
        //Console.WriteLine(Message);
        #endregion

        #region Array 1D
        //int[] Numbers = new int[3] {1, 2, 3};
        //int[] Numbers = new int[] { 1, 2, 3 };
        //int[] Numbers = { 1, 2, 3 };

        //Console.WriteLine(Numbers[0]);
        //Console.WriteLine(Numbers[1]);
        //int[] Numbers = new int[3];

        ////Numbers[0] = 1; 
        ////Numbers[1] = 2;
        ////Numbers[2] = 3;

        //for (int i = 0; i < Numbers.Length; i++) 
        //{
        //    //Numbers[i] = i + 1;
        //    Console.WriteLine($"Enter Element Number {i+1}");
        //    Numbers[i] =int .Parse( Console.ReadLine() );
        //}
        //Console.WriteLine("**********");
        //for (int i = 0; i < Numbers.Length; i++)
        //{
        //    Console.WriteLine(Numbers[i]);
        //}
        //Console.WriteLine(Numbers.Length);
        //Console.WriteLine(Numbers.Rank); //Print Dimantion about Array

        #endregion

        #region Array 2D
        // int[,] Marks = new int[3, 5];// { { 1,2,3,4,5},
        //                             //{ 10,20,30,40,50},
        //                             //{100,200,300,400,500 } }
        //                             //Console.WriteLine(Marks.Length);
        //                             //Console.WriteLine(Marks.Rank);
        //                             //Console.WriteLine(Marks.GetLength(0));
        //                             //Console.WriteLine(Marks.GetLength(1));

        //for (int i = 0; i < Marks.GetLength(0); i++)
        //{
        //    Console.WriteLine($"Enter Grade Student({i + 1}");
        //    for (int j = 0; j < Marks.GetLength(1);/* j++ */)
        //    {
        //        bool Flag;
        //        Console.WriteLine($"Enter Grade Subject({j + 1}");
        //        // Marks[i, j] = int.Parse(Console.ReadLine());
        //        Flag = int.TryParse(Console.ReadLine(), out Marks[i, j]);
        //        //if (Flag && Marks[i, j] >= 0)
        //        //{
        //        //    j++;
        //        //}

        //        j = Flag && Marks[i, j] >= 0 ? ++j : j; // We Cant use j++ because post fix we want to use pre fix
        //    }
        //}

        //for (int i = 0; i < Marks.GetLength(0); i++)
        //{
        //    Console.WriteLine($"Grade Student({i + 1}");
        //    for (int j = 0; j < Marks.GetLength(1); j++)
        //    {
        //        Console.WriteLine($"Grade Subject({j + 1}");
        //        Console.WriteLine(Marks[i, j]);
        //    }
        //}

        //Console.Clear();
        //for (int i = 0; i < Marks.Length; i++)
        //{
        //    Console.WriteLine(Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)]);
        //}


        #endregion

        #region Judged Array
        //int[][] Number = new int[3][];
        //Number[0] = new int[3] {1,2,3};
        // Number[1] = new int[2] {4,5};
        //Number[2] = new int[1] {6};

        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 2; j++)
        //    {
        //        Console.WriteLine(Number[i][j]);
        //    }
        //}

        #endregion

        #region Search About Array Method
        #region C# Array Operations and Methods
        //Baic OPeration
        //int[] numbers = { 10, 20, 30, 40, 50 };

        //Console.WriteLine(numbers[0]); // 10

        //// Updating elements
        //numbers[2] = 35;
        //Console.WriteLine(numbers[2]);
        #endregion

        #region Array Initialization find lengh
        //int[] numbers = new int[5]; // Creates an array of size 5
        //numbers[0] = 1;

        //// Initialize with values
        //int[] initializedArray = { 1, 2, 3, 4, 5 };

        //int length = numbers.Length; // Get the number of elements
        //Console.WriteLine($"Length: {length}");
        #endregion

        #region Search for an Element
        //int[] numbers = { 10, 20, 30, 40, 50 };


        //int index = Array.IndexOf(numbers, 30); // Returns 2
        //Console.WriteLine($"Index of 30: {index}");

        //// Check if an element exists
        //bool contains = numbers.Contains(40); // Returns true
        //Console.WriteLine($"Contains 40: {contains}");
        #endregion

        #region Advanced Operations [Sorting, Reverse,Copy Elements]
        //int[] numbers = { 50, 10, 40, 20, 30 };

        //Array.Sort(numbers);
        //Console.WriteLine(string.Join(", ", numbers)); // Output: 10, 20, 30, 40, 50

        //Array.Reverse(numbers);
        //Console.WriteLine(string.Join(", ", numbers)); // Output: 50, 40, 30, 20, 10

        //int[] source = { 1, 2, 3, 4, 5 };
        //int[] destination = new int[source.Length];

        //// Copy elements
        //Array.Copy(source, destination, source.Length);
        //Console.WriteLine(string.Join(", ", destination)); // Output: 1, 2, 3, 4, 5

        #endregion


        #region LINQ Operations on Arrays[ Filter Elements,Find Max, Min, and Sum,. Transform Elements]

        //int[] numbers = { 10, 20, 30, 40, 50 };
        //var filtered = numbers.Where(n => n > 20).ToArray();
        //Console.WriteLine(string.Join(", ", filtered)); // Output: 30, 40, 50
        ////
        //int max = numbers.Max(); // Maximum value
        //int min = numbers.Min(); // Minimum value
        //int sum = numbers.Sum(); // Sum of all elements

        //Console.WriteLine($"Max: {max}, Min: {min}, Sum: {sum}");
        ////
        //var squared = numbers.Select(n => n * n).ToArray();
        //Console.WriteLine(string.Join(", ", squared)); // Output: 100, 400, 900, 1600, 2500


        #endregion


        #region Cloning Arrays
        int[] original = { 1, 2, 3 };
        int[] cloned = (int[])original.Clone();

        cloned[0] = 10; // Modify cloned array
        Console.WriteLine(string.Join(", ", original)); // Output: 1, 2, 3
        Console.WriteLine(string.Join(", ", cloned));   // Output: 10, 2, 3

        #endregion

        #region  Jagged Arrays
        //int[][] jaggedArray = new int[3][];
        //jaggedArray[0] = new int[] { 1, 2 };
        //jaggedArray[1] = new int[] { 3, 4, 5 };
        //jaggedArray[2] = new int[] { 6 };

        //// Access elements
        //Console.WriteLine(jaggedArray[1][2]); // 5

        #endregion
        #endregion
    }
}