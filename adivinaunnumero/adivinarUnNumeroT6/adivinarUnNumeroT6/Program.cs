int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
var n = 0;
int numero = 0;     

while (numero != numeroSecreto)
{
    n++;
    Console.Write("Ingrese un numero e intente adivinar el numero secreto: ");
    numero = int.Parse(Console.ReadLine());

    if (numero > numeroSecreto)
    {
        Console.WriteLine("el número es muy grande, intente de nuevo.");
    }

    else if (numero < numeroSecreto)
    {
        Console.WriteLine("El número es muy chico intente de nuevo.");
    }

    else if (numero == numeroSecreto)
    {
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: " + numeroSecreto);
        Console.WriteLine("Lo has logrado en " + n + " intentos!!");
    }

} 
