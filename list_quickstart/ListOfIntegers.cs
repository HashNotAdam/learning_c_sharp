using System;
using System.Collections.Generic;

class ListOfIntegers
{
    private List<int> fibonacciNumbers = new List<int> {1, 1};

    public void Call()
    {
        PopulateFibonacciNumbers();
        WriteFibonacciNumbers();
    }

    private void PopulateFibonacciNumbers()
    {
        while (fibonacciNumbers.Count < 20)
        {
            var nextNumber = NextFibonacciNumber();
            fibonacciNumbers.Add(nextNumber);
        }
    }

    private int NextFibonacciNumber()
    {
        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
        return previous + previous2;
    }

    private void WriteFibonacciNumbers()
    {
        foreach(var item in fibonacciNumbers)
        {
            Console.WriteLine(item);
        }
    }
}
