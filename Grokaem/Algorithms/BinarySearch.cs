namespace Grokaem.Algorithms;

internal static class BinarySearch
{
    public static int[] GetExample()
    {
        int[] example = new int[100];
        example[0] = 1;
        for (int i = 1; i < example.Length; i++)
        {
            example[i] = example[i - 1] + Random.Shared.Next(1, 3);
        }

        return example;
    }
    
    public static int[] GetSimpleExample()
    {
        int[] example = new int[15];
        for (int i = 0; i < example.Length; i++)
        {
            example[i] = i;
        }

        return example;
    }

    public static int Search(int[] array, int value)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = (right + left) / 2;

            if (array[mid] == value)
            {
                return mid;
            }

            if (array[mid] > value)
            {
                right = mid - 1;
            }

            if (array[mid] < value)
            {
                left = mid + 1;
            }
        }
        
        return -1;
    }
}