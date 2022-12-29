using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab03_Search;
class BinarySearch
{
    static void Main2(string[] args)
    {
        // Arreglo desordenado
        Console.WriteLine("Algoritmo de busqueda binaria: ");
        int[] A = { 86,9,85,68,61,94,33,55,60,12,62,49,63,52,36,59,41,45,88,92 };

        // Impresion del arreglo
        Console.WriteLine("Arreglo desordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i+1}]={A[i]}, ");
        }
        Array.Sort(A);
        Console.WriteLine("\n\nArreglo ordenado: ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"A[{i+1}]={A[i]}, ");
        }

        // Leer elemento a buscar por teclado
        Console.Write("\nIngrese el elemento a buscar: ");
        int elemBuscado = int.Parse(Console.ReadLine());

        var horaInicio = DateTime.Now; // Hora de inicio
        Stopwatch time = new Stopwatch(); // Reloj para el tiempo de ejecucion
        time.Start(); // Inicio de reloj 

        // Busqueda y impresion del elemento encontrado
        int posicionEncontrada = BusquedaBinaria(A, A.Length, elemBuscado);
        if (posicionEncontrada == -1)
        {
            Console.WriteLine("\nElemento no encontrado");
        }
        else
        {
            Console.WriteLine($"\nElemento encontrado en la posicion: A[{posicionEncontrada}]={A[posicionEncontrada]}");
        }

        time.Stop(); // Fin del reloj
        Console.WriteLine("Tiempo total de ejecucion: " + time.Elapsed.TotalMilliseconds + " ms");
        var horaFin = DateTime.Now; // Hora de finalizacion

        // Impresion de la hora de inicio y fin
        Console.WriteLine($"Hora de inicio: {horaInicio}");
        Console.WriteLine($"Hora de fin: {horaFin}");
    }
    static int BusquedaBinaria(int[] lista, int n, int clave)
    {
        int bajo = 0, alto = n - 1, central=0;
        bool encontrado = false;
        while ((bajo <= alto) && (!encontrado))
        {
            central = (bajo + alto) / 2;
            if (lista[central] == clave)
                encontrado = true;             // éxito en la búsqueda
            else if (clave < lista[central]) // a lo bajo del central
                alto = central - 1;
            else                            // a la alto del central
                bajo = central + 1;
        }
        if(encontrado) // central si encontrado -1 otro caso
        {
            return central;
        }else{
            return -1;
        }
    }
}
