// Realizar un programa que pida la carga de dos vectores numéricos enteros de 4 elementos. Obtener la suma de los dos vectores, dicho
// resultado guardarlo en un tercer vector del mismo tamaño. Sumar componente a componente.

using System;

namespace dos_vectores_array
{
    class dos_vectores_array
    {
        private int[] vec1;
        private int[] vec2;
        private int[] suma;

        public void Carga()
        {
            vec1 = new int[4];
            vec2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Ingrese el entero {i+1} del vector 1: ");
                vec1[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Ingrese el entero {j+1} del vector 2: ");
                vec2[j] = int.Parse(Console.ReadLine());
            }
        }

        public void Sumar()
        {
            suma = new int[4];
            for (int k = 0; k < 4; k++)
            {
                suma[k] = vec1[k] + vec2[k];
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("El resulta de la suma de los vectores es: ");
            for (int l = 0; l < 4; l++)
            {
                Console.Write($"Indice {l}: ");
                Console.WriteLine(suma[l]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            dos_vectores_array array = new dos_vectores_array();
            array.Carga();
            array.Sumar();
            array.Imprimir();
        }
    }
}