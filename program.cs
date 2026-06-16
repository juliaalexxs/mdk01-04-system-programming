using System;
using System.Threading.Tasks;
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        int arr= 100000;
        int[] numbers = new int[arr];
            Random rnd = new Random();
        for (int i = 0; i<arr; i++)
        {
            numbers[i] = rnd.Next(1, 101);
        }


        
    }
}
