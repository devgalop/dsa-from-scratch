# Ejercicio: Imprimir valores alternados

Dado un array *arr[]*, evaluar si está ordenado de manera ascendente o no. Los elementos iguales están permitidos y son considerados consecutivos.

## Ejemplos:

```cs
 int[] arr = [10,20,30,50]
 //Dado el array, se evaluan que todos los elementos están en orden ASC. Retorna True

 int[] arr = [15,6,25,3]
 //Dado el array, se evaluan que los elementos NO están en orden ASC. Retorna False
```

# Planteamiento de solución

Para dar solución a este problema se plantean las siguientes opciones:

- **Solución iterativa derecha a izquierda O(n)**: Mediante un ciclo se valida de derecha a izquiera cada uno de los elementos. Debe cumplir la condición que el valor leído de la izquierda no debe ser mayor al valor leído de la derecha, en caso contrario el array no está ordenado.

- **Solución recursiva O(n)**: La función recursiva valida si los dos primeros elementos del array están en orden y de manera recursiva valida los demás.

- **Solución iterativa izquierda a derecha O(n)**:Mediante un ciclo se valida de izquierda a derecha cada uno de los elementos. Debe cumplir la condición que el valor leído de la izquierda no debe ser mayor al valor leído de la derecha, en caso contrario el array no está ordenado.

Si desea conocer más sobre este problema, dirijase a la fuente [Geek for Geeks](https://www.geeksforgeeks.org/dsa/program-check-array-sorted-not-iterative-recursive/)