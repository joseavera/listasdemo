using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> pedidos = new Stack<string>();
        pedidos.Push("Tacos"); pedidos.Push("Torta"); pedidos.Push("Agua");

        // Peek = VER el tope sin quitarlo
        string actual = pedidos.Peek();
        Console.WriteLine($"Tope actual: {actual}");   // Agua
        Console.WriteLine(pedidos.Count);              // 3 (no cambió)

        // Pop = QUITAR y devolver el tope
        string retirado = pedidos.Pop();
        Console.WriteLine($"Se retiró: {retirado}");   // Agua
        Console.WriteLine(pedidos.Count);              // 2 (sí cambió)

        // Nuevo tope es Torta
        Console.WriteLine(pedidos.Peek());             // Torta
    }
}
