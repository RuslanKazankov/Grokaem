using Grokaem.Algorithms;

namespace Grokaem;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Grokaem algorithms!");

        TestSortOfSelect();
        //TestSimpleBinarySearch();
        //TestBinarySearch();
    }

    private static void TestSortOfSelect()
    {
        Console.WriteLine("Testing sort of select");
        int[] array = SortOfSelect.GetExample();
        Console.WriteLine("Test array:");
        array.Select(n => $"{n} ").ToList().ForEach(Console.Write);
        SortOfSelect.Sort(array);
        Console.WriteLine("\nSorted array:");
        array.Select(n => $"{n} ").ToList().ForEach(Console.Write);
    }

    private static void TestSimpleBinarySearch()
    {
        int value = 3;
        Console.WriteLine($"BinarySearch: {value}");
        int[] simpleExapmle = BinarySearch.GetSimpleExample();
        simpleExapmle.Select(n => $"{n} ").ToList().ForEach(Console.Write);
        Console.WriteLine();
        Console.WriteLine("Index:" + BinarySearch.Search(simpleExapmle, value));
    }

    private static void TestBinarySearch()
    {
        int[] hardExample = BinarySearch.GetExample();
        hardExample.Select(n => $"{n} ").ToList().ForEach(Console.Write);
        Console.WriteLine();
        for (int i = 0; i < 10; i++)
        {
            int value = 42 + i;
            Console.WriteLine($"Search: {value}");
            int index = BinarySearch.Search(hardExample, value);
            Console.WriteLine($"Index: {index}");
        }
    }
}