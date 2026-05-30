using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<string> alumnos = new LinkedList<string>();
        alumnos.AddLast("Ana");
        alumnos.AddLast("Luis");
        alumnos.AddLast("Sofía");

        // ── RECORRER con foreach — igual que con arreglos ────────────────
        foreach (string alumno in alumnos)
        {
            Console.WriteLine(alumno); // Imprime: Ana, luego Luis, luego Sofía
        }

        // ── BUSCAR si un valor existe — Contains ─────────────────────────
        bool existe = alumnos.Contains("Luis");
        Console.WriteLine(existe); // True

        bool noExiste = alumnos.Contains("Pedro");
        Console.WriteLine(noExiste); // False

        // ── ELIMINAR un elemento — Remove ────────────────────────────────
        alumnos.Remove("Luis"); // Lista ahora: Ana → Sofía
        // C# busca el nodo con ese valor y redirige los punteros automáticamente

        Console.WriteLine($"Después de eliminar Luis: {alumnos.Count} alumnos"); // 2 alumnos

        // ── Ver el primer y último elemento ──────────────────────────────
        Console.WriteLine(alumnos.First.Value); // Ana  (el head)
        Console.WriteLine(alumnos.Last.Value);  // Sofía (el último)
    }
}
