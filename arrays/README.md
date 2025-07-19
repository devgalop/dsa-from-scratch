# Arrays

Los *arrays* son estructuras de datos lineales que almacenan sus elementos de manera continua en un espacio de memoria.

Esta colección **solo** permite almacenar el mismo tipo de variable en todos los espacios de memoria reservados.

## Terminología básica dentro de los arrays

- **Array Index**: Este identifica la posición en la que está ubicado cada elemento.
- **Array Element**: Son las variables almacenadas dentro de un array.
- **Array Length**: El tamaño de un array indica la cantidad de elementos que están almacenados dentro de este.

## Representación dentro de la memoria

Todos los elementos de un array están almacenados dentro de locaciones continuas en la memoria. Al momento de inicializar un array, se reserva el espacio en memoria.

![array-representation](resources/array-representation.png)

*Imagen referencia tomada de [Geek for Geeks](https://www.geeksforgeeks.org/dsa/introduction-to-arrays-data-structure-and-algorithm-tutorials/)*

## Tipos de arrays

Esta estructura de datos se clasifica en dos categorias: *En base a su tamaño* o *En base a sus dimensiones*

- **Clasificación en base a su tamaño**: En esta clasificación, los arrays se pueden dividir entre *tamaño fijo* o *tamaño dinámico*

- **Clasificación en base a sus dimensiones**: Los arrays pueden dividirse en : *Una dimensión (1D)*, *Dos dimensiones / Matriz (2D)* ,*Multi-dimensional (nD)*

## Clasificación en base a su tamaño
- **Tamaño fijo**: Este tipo de array se caracteriza porque una vez creado, no puede ser modificado el tamaño. 

Si se asigna un espacio muy grande y no se utiliza en su totalidad, se está desperdiciando memoria. Mientras que si se declara un espacio muy pequeño, no habrá espacio suficente para almacenar los elementos.

A continuación se muestra como se crea un array de tamaño fijo utilizando **C#**.

```cs
int[] numbers = new int[5];

int[] ages = {10, 5, 22, 31};
```

- **Tamaño dinámico**: En este caso, el array tiene un tamaño variable. Este tipo de array permite que los usuarios añadan o eliminen elementos según su necesidad.

```cs
ArrayList myList = new ArrayList();
```

## Clasificación según sus dimensiones

- **Arrays de una dimensión (1D)**: Los arrays de una sola dimensión se pueden exponer como una fila, donde sus elementos están almacenados uno tras otro.

- **Arrays de dos dimensiones (2D)**: Estos arrays son conocidos como matrices, son considerados un array de otro array y se compone de filas y columnas.

- **Arrays multidimensionales (nD)**: Los arrays multidimensionales son arrays que se componen de más arrays, es decir, un array tridimensional se compone de un array que contiene un arrays de dos dimensiones.

## Operaciones en Array

- **Array Traversal**: Esta operación hace referencia al proceso que consiste en acceder se manera secuencial a cada uno de los elementos dentro del array. Esta operación recorre todo el array de inicio a fin o en ocasiones, de fin al inicio, utilizando un loop.

- **Insercion en array**: Se refiere al proceso de adicionar un nuevo elemento en una posición especifica mientras se mantiene el orden existente.

- **Eliminacion en array**: Este proceso hace referencia a remover un elemento de una posición especifica del array mientras se mantiene el orden de los elementos. **NOTA:** Eliminar elementos de un array no es una operación eficiente debido a que se debe mover los elementos que estaban después del objeto eliminado para cerrar la brecha.

- **Busqueda en array**: La operación de busqueda se refiere al proceso de encontrar el indice en el cual se encuentra un elemento especifico. El objetivo es determinar si existe ese elemento y el indice en el que está ubicado. 

Existen dos tipos de busquedas
  - **Busqueda linear**: Es el algoritmo más simple, consiste en ir elemento a elemento y comparandolo para ver si cumple la condición, cuando lo encuentre, retorna el indice.
  - **Busqueda binaria**: Esta es la busqueda más eficiente dentro de arrays ordenados ya sea de manera ascendente o descendente. Consiste en dividir la busqueda en mitades. El primer paso es encontrar la mitad del array, si el valor buscado es igual al del medio se retorna el indice. Si el valor buscado es menor al valor del medio, se realiza la busqueda solo en la mitad izquierda. Si el valor buscado es mayor, se realiza la busqueda en la mitad derecha. Este proceso se repite hasta encontrar el valor o no hayan más valores para comparar.

Si desea conocer más sobre este tema, por favor dirijase a la fuente [Geek for Geeks](https://www.geeksforgeeks.org/dsa/array-data-structure-guide/)