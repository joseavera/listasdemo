using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creamos la pila de pedidos (textos)
        Stack<string> pedidos = new Stack<string>();

        // Push = agregar encima de la pila
        pedidos.Push("Tacos");    // Pila: Tacos
        pedidos.Push("Torta");    // Pila: Torta ← tope
        pedidos.Push("Agua");     // Pila: Agua  ← tope

        // Count = cuántos pedidos hay en la pila
        Console.WriteLine(pedidos.Count);  // 3
    }
}
