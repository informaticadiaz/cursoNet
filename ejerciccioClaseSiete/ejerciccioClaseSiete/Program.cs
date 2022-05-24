int[] numeros = new int[10];
Console.WriteLine("por favor ingrese 10 numeros");


for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"por favor ingrse el numero: {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());
}

int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    //suma += numeros[i];
    suma = suma + numeros[i];
}

int mayor = numeros[0];
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] > mayor)
        mayor = numeros[i];
}

int menor = numeros[0];
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] < menor)
        menor = numeros[i];
}

var promedio = suma / (numeros.Length);

// alternativa con numero decimal sacada de https://docs.microsoft.com/es-es/
// decimal promedio = ((decimal)suma / (decimal)numeros.Length);

Console.WriteLine("=========================================");
Console.WriteLine("los valores ingresados son: ");

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}



Console.WriteLine("=========================================");

Console.WriteLine($"La suma de todos los numeros es; {suma}");


Console.WriteLine("=========================================");

Console.WriteLine($"El numero mayor es; {mayor}");


Console.WriteLine("=========================================");

Console.WriteLine($"El numero menor es; {menor}");


Console.WriteLine("=========================================");

Console.WriteLine($"El promedio de los numeros es; {promedio}");