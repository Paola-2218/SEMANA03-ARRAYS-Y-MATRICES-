using System;

class Estudiante
{
    public int Id;
    public string Nombres = "";
    public string Apellidos = "";
    public string Direccion = "";
    public string[] Telefonos = new string[3];

    public void MostrarDatos()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nombres: " + Nombres);
        Console.WriteLine("Apellidos: " + Apellidos);
        Console.WriteLine("Dirección: " + Direccion);

        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine("Teléfono " + (i + 1) + ": " + Telefonos[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Estudiante est = new Estudiante();

        Console.Write("Ingrese ID: ");
        est.Id = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese nombres: ");
        est.Nombres = Console.ReadLine()!;

        Console.Write("Ingrese apellidos: ");
        est.Apellidos = Console.ReadLine()!;

        Console.Write("Ingrese dirección: ");
        est.Direccion = Console.ReadLine()!;

        for (int i = 0; i < est.Telefonos.Length; i++)
        {
            Console.Write("Ingrese teléfono " + (i + 1) + ": ");
            est.Telefonos[i] = Console.ReadLine()!;
        }

        Console.WriteLine("\n--- DATOS DEL ESTUDIANTE ---");
        est.MostrarDatos();
    }
}
