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
        Console.WriteLine("ОБЫЧНЫЙ ЦИКЛ FOR:");
        Stopwatch a1 = Stopwatch.StartNew();
        long sumFor = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sumFor += numbers[i];
        }
        a1.Stop();
        Console.WriteLine("сумма - " + sumFor);
        Console.WriteLine("время - " + a1.ElapsedMilliseconds + " мс\n");
        
        Console.WriteLine("ЦИКЛ PARALLEL.FOR:");
        object locker = new object();
        Stopwatch a2 = Stopwatch.StartNew();
        long sumParallel = 0;
        
        Parallel.For(0, numbers.Length, i =>
        {
            lock (locker)
            {
                sumParallel += numbers[i];
            }
        });
        a2.Stop();
        Console.WriteLine("сумма - " + sumParallel);
        Console.WriteLine("время - " + a2.ElapsedMilliseconds + " мс");
        Console.ReadLine();
    }
}
