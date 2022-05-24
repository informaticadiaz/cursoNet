Console.Write("Ingrese la cantidad de Columnas: ");
// Determina las Columnas
int cantidadColumnas = int.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("Ingrese la cantidad de Filas: ");
// Determina las Filas
int cantidadFilas = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("==============================================");

// Tipo[,] nombre = new tipo[cantidadFilas, cantidadColumnas]
int[,] numeros = new int[cantidadFilas, cantidadColumnas];
//Cantidad de filas
int lengthFilas = numeros.GetUpperBound(0) + 1;
//Cantidad de columnas
int lengthColumnas = numeros.GetUpperBound(1) + 1;

//Recorremos columnas y le asignamos un valor
for (int columna = 0; columna < lengthColumnas; columna++)
{
    Console.WriteLine();

    Console.WriteLine($"Valor de la columna {columna + 1}: ");

    // Recorremos filas y le asignamos un valor
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"Valor de la fila {fila + 1}: ");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("=======================================");

// Recorremos las columnas y las mostramos en pantalla
for (int columna = 0; columna < lengthColumnas; columna++)
{

    Console.WriteLine();
    Console.WriteLine($"Valor de la Columna: {columna + 1}: ");

    // Recorremos filas y las mostramos en pantalla
    for (int fila = 0; fila < lengthFilas; fila++)
    {
        Console.Write($"Valor de la Fila: {fila + 1}: ");
        Console.WriteLine(numeros[fila, columna]);

    }
}

Console.WriteLine();
Console.WriteLine("=======================================");


double[] promedios = new double[cantidadColumnas];
for (int columna = 0; columna < lengthColumnas; columna++)
{
    int suma = 0;
    // Recorremos filas y las mostramos en pantalla
    for (int fila = 0; fila < lengthFilas; fila++) 
    {
        suma = suma + numeros[fila, columna];
    }
    double average = suma / cantidadFilas;
    promedios[columna] = average;
}

;
for (int posicion = 0; posicion < promedios.Length; posicion++)
{
    Console.WriteLine("Los promedios de la columna son: ");
    Console.WriteLine(promedios[posicion]);
}
Console.ReadKey();