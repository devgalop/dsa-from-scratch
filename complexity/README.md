# Analisis de los algoritmos

El análisis de los algoritmos es fundamental para evaluar el rendimiento de los algoritmos y programas.

La eficiencia de un algoritmo se mide en terminos de *tiempo* y *espacio* requerido según la entrada de datos.

## Asymptotic Analysis

Se trata de evaluar el rendimiento de un algoritmo en terminos de la entrada de los datos. Para realizar esta tarea, se necesita calcular el *orden de crecimiento* del *tiempo* o el *espacio* requerido por un algoritmo en referencia al tamaño de su entrada.

## Big-O Notation

La notación *Big-O* es una herramienta utilizada dentro de la ciencias de la computación para describir el *time complexity* o el *space complexity* que tiene cada algoritmo.

Esta herramienta nos permite describir el *orden de crecimiento* del tiempo y/o espacio requerido por un algoritmo según el tamaño de su entrada. Este se expresa como una función, no es un valor exacto.

*Big-O* nos permite comparar la eficiencia de algoritmos o estructuras de datos.

Cuando se mide el *orden de crecimiento* de un algoritmo, se suele utilizar el caso del *peor escenario* para obtener el limite más grande.

*Big-O* se suele denotar así **O(f(n))**, donde *f(n)* es la función que representa el numero de operaciones que un algoritmo debe ejecutar para resolver un problema de tamaño *n*.

### Las notaciones Big-O más comunes

**Linear Time Complexity O(n)**
Esta notación aplica para los algoritmos que crecen de manera lineal respecto a su entrada.

Un ejemplo de esto es: **Buscar un elemento dentro de un array**

```cs
public bool FindElement(int numbers[], int arr_size, int key)
{
    for(int actualPos = 0; actualPos < arr_size; actualPos++)
    {
        if(numbers[actualPos] == key) return true;
    }
    return false;
}
```

**Logarithmic Time Complexity O(log n)**
Este tipo de notación hace referencia a los algoritmos que en su tiempo de ejecución son proporcionales al logaritmo del tamaño de su entrada.

Un ejemplo de esto es **el algoritmo de busqueda binaria**

```cs
public int BinarySearch(int arr[], int l, int r, int x)
{
    if ( r >= l)
    {
        int mid = l + (r - 1) / 2;
        if ( arr[mid] == x ) return mid;
        if ( arr[mid] > x ) return BinarySearch(arr, l, mid - 1, x);
        return BinarySearch(arr, mid + 1, r, x);
    }
    return -1;
}
```

**Quadratic Time Complexity O(n^2)**
La notación cuadratica se aplica a los tiempos de ejecución de un algoritmo que su proporcion es la raiz cuadrada de la entrada de los datos.

Un ejemplo de esto es **el algoritmo de busqueda de burbuja**
```cs
public void BubbleSort(int arr[], int n)
{
    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                swap(&arr[j], &arr[j + 1]);
            }
        }
    }
}
```

**Cubic Time Complexity O(n^3)**
La notación cubica se aplica a los tiempos de ejecución de un algoritmo es proporcional al cubo de la entrada de los datos.

Un ejemplo de esto es **el algoritmo de multiplicacion de matrices**
```cs
public void Multiply(int mat1[][N], int mat2[][N], int res[][N])
{
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++) {
            res[i][j] = 0;
            for (int k = 0; k < N; k++)
                res[i][j] += mat1[i][k] * mat2[k][j];
        }
    }
}
```

**Exponential Time Complexity O(2^n)**
Esta notación hace referencia a los algoritmos que en su tiempo de ejecución se duplican con cada adición a la entrada de datos.

Un ejemplo de esto es **generar todos los subconjuntos de un conjunto**

```cs
public void GenerateSubsets(int arr[], int n)
{
    //El simbolo << es un operador entre bits y corre los bits a la izquierda
    for (int i = 0; i < (1 << n); i++)
    {
        for (int j = 0; j < n; j++)
        {
            //El condicional valida a nivel de bits si el bit en la posicion i está encendido
            if ((i & (1 << j)) != 0)
            {
                Console.Write(arr[j] + " ");
            }
        }
        Console.WriteLine();
    }
}
```
**Factorial Time Complexity O(n!)**
La notación factorial hace referencia a que el tiempo de ejecucion de un algoritmo crece según el factorial del tamaño de la entrada. Generalmente se ve en algoritmos que generan una permutación de un conjunto de datos.

Un ejemplo de esto es **generar una permutación de un array**
```cs
public void Permute(int arr[], int l, int r)
{
    //El simbolo << es un operador entre bits y corre los bits a la izquierda
    for (int i = 0; i < (1 << n); i++)
    {
        if (l == r)
        {
            for (int i = 0; i <= r; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = l; i <= r; i++)
            {
                Swap(ref array[l], ref array[i]);
                Permute(array, l + 1, r);
                Swap(ref array[l], ref array[i]); // backtrack
            }
        }
    }
}
```

El siguiente diagrama muestra las notaciones más comunes del **Big-O notation**

![big-o-plot](resources/big-o-plot.png)

*Imagen de referencia tomada de [FreeCodeCamp](https://www.freecodecamp.org/news/big-o-cheat-sheet-time-complexity-chart/)*

Si desea profundizar más sobre algún concepto, remitase a la fuente [Geek for Geeks](https://www.geeksforgeeks.org/dsa/analysis-of-algorithms/)