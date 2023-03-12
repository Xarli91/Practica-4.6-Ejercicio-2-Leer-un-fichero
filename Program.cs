using System;
using System.IO;

class Program_Ficheros
{
    static void Main(string[] args)
    {
        // Abre el archivo de texto para leer
        StreamReader file = File.OpenText("tecleado.txt");

        string linea;
        int contador = 0;

        // Lee las tres primeras líneas del archivo
        while ((linea = file.ReadLine()) != null && contador < 3)
        {
            Console.WriteLine(linea);
            contador++;
        }

        // Cierra el archivo
        file.Close();

        Console.WriteLine("Programa finalizado.");
        Console.ReadLine();
    }
}