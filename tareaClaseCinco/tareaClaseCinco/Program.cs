var respuesta = "S";

while (respuesta.ToUpper() == "S")
{
    // 1) Borra la pantalla
    Console.Clear();
    // 2) Pedir el nombre de una persona
    Console.WriteLine("Hola, Ingrese su nombre:");
    // Leemos el nombre del usuario
    string nombre = Console.ReadLine();
    // 3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
    Console.Write("Hola " + nombre);
    Console.WriteLine(". Quiere continuar? (S/N)");
    respuesta = Console.ReadLine();

    if (respuesta.ToUpper() == "N")
    {
        Console.WriteLine("Programa finalizado correctamente");
    }
    else
    {
        Console.WriteLine("Opcion no valida");
    }

}