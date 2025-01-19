namespace Grokaem.Algorithms;

internal static class SortOfSelect
{
    public static int[] GetExample()
    {
        int[] array = new int[100];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(-1000, 1000);
        }
        return array;
    }
    
    private static int FindSmallest(int[] array)
    {
        int smallest = array[0];
        int indexSmallest = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < smallest)
            {
                smallest = array[i];
                indexSmallest = i;
            }
        }
        return indexSmallest;
    }

    public static void Sort(int[] array)
    {
        int[] newArray = new int[array.Length];
        
        for (int i = 0; i < array.Length; i++)
        {
            int indexSmallest = FindSmallest(array);
            newArray[i] = array[indexSmallest];
            array[indexSmallest] = int.MaxValue;
        }

        newArray.CopyTo(array, 0);
    }
}