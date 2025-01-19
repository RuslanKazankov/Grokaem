namespace Grokaem.Algorithms;

internal static class DivideAndConquer
{
    public static void TestQuickSort()
    {
        int[] array = [1,6,4,3,2,4,6,4,6,4,2,5,7,5,4,23,63,63,654,2435,324,56,34];
        array.Select(n => $"{n} ").ToList().ForEach(Console.Write);
        Console.WriteLine("\nQuickSort:");
        int[] sortedArray = QuickSort(array);
        sortedArray.Select(n => $"{n} ").ToList().ForEach(Console.Write);
    }
    
    public static int[] QuickSort(int[] array, int length = -1)
    {
        if (length == -1)
        {
            length = array.Length;
        }

        if (length == 0)
        {
            return [];
        }

        if (length == 1)
        {
            return [array[0]];
        }

        if (length == 2)
        {
            if (array[0] <= array[1])
            {
                return [array[0], array[1]];
            }

            return [array[1], array[0]];
        }

        int support = array[0];
        int[] lessSupport = new int[length];
        int[] moreSupport = new int[length];
        int l = 0, m = 0;
        for (int i = 1; i < length; i++)
        {
            if (array[i] >= support)
            {
                moreSupport[m] = array[i];
                m++;
            }
            else
            {
                lessSupport[l] = array[i];
                l++;
            }
        }

        return [.. QuickSort(lessSupport, l), support, .. QuickSort(moreSupport, m)];
    }
    
    public static void TestBinarySearch()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        array.Select(n => $"{n} ").ToList().ForEach(Console.Write);
        Console.WriteLine("\nSearch 4");
        Console.WriteLine("Index: " + BinarySearch(array, 4));
    }
    
    public static int BinarySearch(int[] array, int value, int left = 0, int right = -1)
    {
        if (right == -1)
        {
            right = array.Length - 1;
        }

        int mid = (left + right) / 2;
        if (array[mid] == value)
        {
            return mid;
        }
        
        if (left > right)
        {
            return -1;
        }

        if (array[mid] < value)
        {
            return BinarySearch(array, value, mid + 1, right);
        }

        return BinarySearch(array, value, left, mid - 1);
    }
    
    public static void TestMax()
    {
        int[] array = { 1, 2, 3, 15, 5, 6, 7, 8, 9, 10 };
        array.Select(n => $"{n} ").ToList().ForEach(Console.Write);
        Console.WriteLine($"\nMax of array: {Max(array.ToList())}");
        Console.WriteLine($"\nExpected max of array: {array.Max()}");
    }
    
    public static int Max(List<int> list, int length = -1)
    {
        if (length == -1)
        {
            length = list.Count;
        }
        
        if (length == 0)
        {
            return int.MinValue;
        }

        if (length == 1)
        {
            return list[0];
        }

        int leftMax = Max(list, length - 1);
        if (list[length - 1] > leftMax)
        {
            return list[length - 1];
        }

        return leftMax;


    }
    
    public static void TestSum()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        array.Select(n => $"{n} ").ToList().ForEach(Console.Write);
        Console.WriteLine($"\nSum of array: {Sum(array)}");
        Console.WriteLine($"\nExpected sum of array: {array.Sum()}");
    }
    
    public static int Sum(int[] array, int length = -1)
    {
        if (length == -1)
        {
            length = array.Length;
        }

        if (length == 0)
        {
            return 0;
        }

        if (length == 1)
        {
            return array[0];
        }

        return Sum(array, length - 1) + array[length - 1];
    }
}