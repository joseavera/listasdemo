using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<string> lista = new LinkedList<string>();

        // Inscribimos alumnos al final
        lista.AddLast("Ana");
        lista.AddLast("Luis");
        lista.AddLast("Sofía");

        // Un alumno se inscribe de urgencia → va al inicio
        lista.AddFirst("Marco");

        // Luis se dio de baja
        lista.Remove("Luis");

        // Mostrar la lista final
        Console.WriteLine("=== Lista de alumnos ===");
        Console.WriteLine($"Total: {lista.Count}");

        foreach (string a in lista)
        {
            Console.WriteLine($"  → {a}");
        }
    }
}
