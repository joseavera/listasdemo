using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> pedidos = new Stack<string>();
        pedidos.Push("Tacos"); pedidos.Push("Torta"); pedidos.Push("Agua");

        // foreach recorre del tope al fondo — sin quitar nada
        Console.WriteLine("=== Pedidos (del más reciente al más antiguo) ===");
        foreach (string p in pedidos)
        {
            Console.WriteLine($"  → {p}");
        }
        Console.WriteLine($"Total: {pedidos.Count} pedidos");
    }
}
