using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> historial = new Stack<string>();

        // Simulamos 4 pedidos que hace el alumno
        historial.Push("Tacos x2");
        historial.Push("Agua 500ml");
        historial.Push("Torta de jamón");
        historial.Push("Jugo naranja");

        // Mostramos el historial completo
        Console.WriteLine("=== Historial de pedidos ===");
        foreach (string p in historial)
        {
            Console.WriteLine($"  {p}");
        }

        // El alumno quiere cancelar su último pedido
        string cancelado = historial.Pop();
        Console.WriteLine($"\nCancelado: {cancelado}");

        // ¿Cuál es ahora el pedido más reciente?
        Console.WriteLine($"Nuevo último: {historial.Peek()}");
        Console.WriteLine($"Pedidos restantes: {historial.Count}");
    }
}
