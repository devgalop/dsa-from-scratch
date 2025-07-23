# Ejercicio: Encontrar lideres del array

Dado un array de enteros de tamaño n, encontrar todos los números que son lideres del array. Un lider es aquel elemento que es mayor o igual que todos los elementos situados a la derecha del array.

NOTA: El último número siempre es lider.

## Ejemplos:

```cs
    //Datos de entrada
    int[] arr = [14,18,2,4,6,5,1]

    //Lista de lideres
    [18,6,1]

    //El número 14 no es lider porque hay números a la derecha de este que son más grandes,
    //El número 18 es lider porque a su derecha no hay ningún otro número mayor.
    //El número 1 es lider porque no existen más numeros a su derecha.
```

# Planteamiento de solución



Si desea conocer más sobre este problema, dirijase a la fuente [Geek for Geeks](https://www.geeksforgeeks.org/dsa/leaders-in-an-array/)