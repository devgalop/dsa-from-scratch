
int[] arr = [14, 18, 2, 4, 6, 5, 1];

//Solución 1: Usando ciclos anidados para comparar los valores O(n^2)
List<int> result1 = FindLeaders1(arr);
PrintResult(result1);
Console.WriteLine("------------------------------------------------");
//Solución 2: Usando un sufijo maximo O(n)
List<int> result2 = FindLeaders2(arr);
PrintResult(result2);


static List<int> FindLeaders1(int[] arr)
{
    List<int> result = [];
    int arraySize = arr.Length;
    for (int idx = 0; idx < arraySize; idx++)
    {
        int auxIdx;

        for (auxIdx = idx + 1; auxIdx < arraySize; auxIdx++)
        {
            if (arr[idx] < arr[auxIdx]) break;
        }

        if (auxIdx == arraySize)
        {
            result.Add(arr[idx]);
        }
    }

    return result;
}

static List<int> FindLeaders2(int[] arr)
{
    List<int> result = [];
    int length = arr.Length;
    int maxValue = arr[length - 1];
    result.Add(maxValue);

    for (int idx = length - 2; idx >= 0; idx--)
    {
        if (arr[idx] > maxValue)
        {
            maxValue = arr[idx];
            result.Add(maxValue);
        }
    }
    result.Reverse();
    return result;
}

static void PrintResult(List<int> result)
{
    foreach (int leader in result)
    {
        Console.WriteLine(leader);
    }
}