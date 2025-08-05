
int[] arr = [10, 20, 20, 40, 50];

//Solución 1: Recorriendo los valores de derecha a izquierda para validar si hay algun valor mayor O(n)
bool result1 = IsAscendingOrdered1(arr);
Console.WriteLine(result1);
Console.WriteLine("------------------------------------------------");

//Solucion 2: Comparando los valores de manera recursiva O(n)
bool result2 = IsAscendingOrdered2(arr, arr.Length);
Console.WriteLine(result2);
Console.WriteLine("------------------------------------------------");

//Solucion 3: Iterando los valores de izquierda a derecha O(n)
bool result3 = IsAscendingOrdered3(arr);
Console.WriteLine(result3);
Console.WriteLine("------------------------------------------------");

static bool IsAscendingOrdered1(int[] arr)
{
    int length = arr.Length;
    int maxValue = arr[length - 1];
    for (int idx = length - 2; idx >= 0; idx--)
    {
        if (arr[idx] > maxValue) return false;
        maxValue = arr[idx];
    }
    return true;
}

static bool IsAscendingOrdered2(int[] arr, int position)
{
    if (position == 1 || position == 0) {
            return true;
        }

    return arr[position - 1] >= arr[position - 2]
        && IsAscendingOrdered2(arr, position - 1);
}

static bool IsAscendingOrdered3(int[] arr)
{
    int length = arr.Length;
    for (int idx = 1; idx < length - 1; idx++)
    {
        if (arr[idx - 1] > arr[idx]) return false;    
    }
    return true;
}