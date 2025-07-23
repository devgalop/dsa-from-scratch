# Ejercicio: Imprimir valores alternados

Dado un array de valores enteros *arr*, la tarea consiste en imprimir en la consola los valores del array alternando las posiciones. El inicio del array es el indice 0. 

## Ejemplos:

```cs
    //Dado el array arr
    int[] arr = [10,20,30,40,50,60]

    //Resultado esperado en consola
    10
    30
    50

    //Se imprime el arr[0], se salta el arr[1], se imprime el arr[2], se salta el arr[3]...
```

# Planteamiento de solución

Para solucionar este problema, existen dos posibles soluciones con una complejidad **O(n)**.

- **Aproximación iterativa**: En esta aproximación se recorren los elementos del array saltando el indice en cada iteración dos posiciones, es decir, en la primera iteración se inicia en la posición 0, cuando imprima el valor, se suma al indice del ciclo 2, de esta manera en la segunda iteración se imprime el indice *0 + 2 = 2*, para la siguiente iteración, se toma la posición actual y se añaden 2 posiciones más y así hasta llegar al final del array.

- **Aproximación recursiva**: En este caso, no se hará uso de un ciclo, sino que la misma función validará si el indice es menor a la cantidad de registros del array. Si esta condición se cumple, se imprime el valor en consola y se llama de manera recursiva, esta vez especificando que el indice elegido es la suma del indice actual más 2.

Si desea conocer más sobre este problema, dirijase a la fuente [Geek for Geeks](https://www.geeksforgeeks.org/dsa/print-alternate-elements-of-an-array/)