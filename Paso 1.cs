using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ── Declarar una lista enlazada vacía de textos ──────────────────
        LinkedList<string> alumnos = new LinkedList<string>();
        //                  ↑ tipo del dato              ↑ constructor (crea la lista vacía)

        // ── Agregar al FINAL de la lista — AddLast ───────────────────────
        alumnos.AddLast("Ana");    // Lista: Ana
        alumnos.AddLast("Luis");   // Lista: Ana → Luis
        alumnos.AddLast("Sofía");  // Lista: Ana → Luis → Sofía

        // ── Agregar al INICIO de la lista — AddFirst ─────────────────────
        alumnos.AddFirst("Marco"); // Lista: Marco → Ana → Luis → Sofía
        // Marco quedó primero — sin mover a nadie, solo cambió el puntero head

        // ── Mostrar cuántos elementos hay — Count ────────────────────────
        Console.WriteLine($"Total de alumnos: {alumnos.Count}"); // Total de alumnos: 4
    }
}
