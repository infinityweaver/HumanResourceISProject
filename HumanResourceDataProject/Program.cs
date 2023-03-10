// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] x = new int[] { 3, 54, 378, 85, 65, 678, 95, 87 };
int[] y = x[3..^1];
foreach(int i in y)
    Console.Write(i + " ");