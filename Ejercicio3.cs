using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Matrices
    {
        public void EjercicioMatrizEnteros()
        {
            int[,] matriz = CrearMatrizEnteros();
            Console.WriteLine("Matriz de enteros:");
            ImprimirMatriz(matriz);
        }

        public void EjercicioMatrizCadenas()
        {
            string[,] matriz = CrearMatrizCadenas();
            Console.WriteLine("\nMatriz de cadenas:");
            ImprimirMatriz(matriz);
        }

        public void EjercicioMatrizDoubles()
        {
            double[,] matriz = CrearMatrizDoubles();
            Console.WriteLine($"\nLa suma de todos los elementos de la matriz de doubles es: {CalcularSuma(matriz)}");
        }

        public void EjercicioMatrizCaracteres()
        {
            char[,] matriz = CrearMatrizCaracteres();
            Console.WriteLine("\nMatriz de caracteres:");
            ImprimirMatriz(matriz);
        }

        private int[,] CrearMatrizEnteros()
        {
            int[,] matriz = new int[3, 3];
            int valorEntero = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = valorEntero;
                    valorEntero++;
                }
            }

            return matriz;
        }

        private string[,] CrearMatrizCadenas()
        {
            return new string[,] { { "Rojo", "Verde" }, { "Azul", "Amarillo" } };
        }

        private double[,] CrearMatrizDoubles()
        {
            return new double[,] { { 1.5, 2.5, 3.5 }, { 4.5, 5.5, 6.5 }, { 7.5, 8.5, 9.5 }, { 10.5, 11.5, 12.5 } };
        }

        private char[,] CrearMatrizCaracteres()
        {
            return new char[,] { { 'A', 'B', 'C', 'D' }, { 'E', 'F', 'G', 'H' } };
        }

        private void ImprimirMatriz<T>(T[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private double CalcularSuma(double[,] matriz)
        {
            double suma = 0;
            foreach (double elemento in matriz)
            {
                suma += elemento;
            }
            return suma;
        }
    }
}
