
int[] arr = [10, 20, 30, 40, 50, 60]; 

//Solución 1: Forma iterativa
PrintAlternateIterative(arr);
Console.WriteLine("----------------------------------------");
//Solución 2: Forma recursiva
PrintAlternateRecursive(arr);


static void PrintAlternateIterative(int[] arr)
{
    for (int idx = 0; idx < arr.Length; idx += 2)
    {
        Console.WriteLine(arr[idx]);
    }
}

static void PrintAlternateRecursive(int[] arr, int idx = 0)
{
    if (idx < arr.Length)
    {
        Console.WriteLine(arr[idx]);
        PrintAlternateRecursive(arr, idx + 2);
    }
}