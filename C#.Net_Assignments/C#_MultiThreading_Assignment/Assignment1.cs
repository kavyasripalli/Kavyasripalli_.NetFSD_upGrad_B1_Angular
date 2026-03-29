using System;
using System.Collections.Generic;
using System.Threading;

class Assignment1
{
    static int[] partialSums = new int[5];

    public static void Run()
    {
        List<int> numbers = new List<int>();
        for (int i = 1; i <= 50; i++)
            numbers.Add(i);

        Thread[] threads = new Thread[5];

        for (int i = 0; i < 5; i++)
        {
            int start = i * 10;
            int end = start + 10;

            int threadIndex = i;

            threads[i] = new Thread(() => Process(numbers, start, end, threadIndex));
            threads[i].Start();
        }

        foreach (var t in threads)
            t.Join();

        int finalSum = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Thread {i + 1} Sum: {partialSums[i]}");
            finalSum += partialSums[i];
        }

        Console.WriteLine("Final Sum: " + finalSum);
    }

    static void Process(List<int> numbers, int start, int end, int index)
    {
        int sum = 0;

        for (int i = start; i < end; i++)
        {
            Console.Write(numbers[i] + " ");
            sum += numbers[i];
        }

        Console.WriteLine();
        partialSums[index] = sum;
    }
}