using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab03_Search;
class FinalExercise
{
    static void Main3(string[] args)
    {
        // Arreglo desordenado
        Console.WriteLine("\n\nAlgoritmo ejercicio final: ");
        int[] A = new int[101];
        Random random = new Random();
        for (int i = 1;  i < A.Length; i++)
        {
            A[i] = random.Next(1, 201);
        }

        // Impresión del arreglo
        Console.WriteLine("\n\nArreglo desordenado: ");
        for (int i = 1; i < A.Length; i++)
        {
            Console.Write($"A[{i}]={A[i]}, ");
        }

        // Elementos que se buscaran
        int[] B = new int[51];
        for (int i = 1; i < B.Length; i++)
        {
            B[i] = random.Next(1, 201);
        }

        //Variables para el tiempo de inicio
        var horaInicio = DateTime.Now; // Hora de inicio
        Stopwatch time = new Stopwatch(); // Reloj para el tiempo de ejecucion
        time.Start(); // Inicio de reloj 

        // Busqueda y impresion del elemento encontrado
        int busquedasExitosas = 0;
        int busquedasFallidas = 0;
        for (int i = 1; i < B.Length; i++)
        {
            int posicionEncontrada = BusquedaLinealID(A, A.Length, B[i]);
            if (posicionEncontrada == -1)
            {
                busquedasFallidas++;
            }
            else
            {
                busquedasExitosas++;
            }
        }

        // Porcentajes de exito y fallido
        double porcentajeExito = (busquedasExitosas*100)/50;
        double porcentajeFallido = (busquedasFallidas*100)/50;

        // Ordenar Array
        Array.Sort(A);

        // Impresion de Resultados
        Console.WriteLine("\n\nElementos aleatorios a buscar: ");
        for (int i = 1; i < B.Length; i++)
        {
            Console.Write($"B[{i}]={B[i]}, ");
        }

        //Arreglo ordenado
        Console.WriteLine("\n\nArreglo ordenado: ");
        for (int i = 1; i < A.Length; i++)
        {
            Console.Write($"A[{i}]={A[i]}, ");
        }

        //Variables del tiempo de finalización
        time.Stop(); // Fin del reloj
        Console.WriteLine("\n\nTiempo total de ejecucion en milisegundos es: " + time.Elapsed.TotalMilliseconds + " ms");
        var horaFin = DateTime.Now; // Hora de finalizacion

        //Impresion de datos 
        Console.WriteLine("Las busquedas existosas son: " + busquedasExitosas);
        Console.WriteLine("Las busquedas fallidas son: " + busquedasFallidas);
        Console.WriteLine("Porcentaje de exito en las busquedas es de: " + porcentajeExito + "%");
        Console.WriteLine("Porcentaje de fallas en las busquedas es de: " + porcentajeFallido + "%");

        // Hora de inicio y fin 
        Console.WriteLine($"Hora de inicio: {horaInicio}");
        Console.WriteLine($"Hora de fin: {horaFin}");
    }

    static int BusquedaLinealID(int[] A, int n, int clave)
    {
        int i;
        for (i = 1; i < n; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }
}
