﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        struct pelicula
        {
            public string codigo, nombre, clasificacion, duracion, horario1, horario2, horario3, horario4, horario5;

        }
        static List<pelicula> Peliculas = new List<pelicula>();

        static string ubicacion = @"..\peliculas.txt";

        public static void cargarCartelera()
        {
            StreamReader leer = new StreamReader(ubicacion);
            while (!leer.EndOfStream)
            {
                string linea = leer.ReadLine();
                string[] aux = linea.Split(',');
                pelicula pelicula = new pelicula();

                pelicula.codigo = aux[0];
                pelicula.nombre = aux[1];
                pelicula.clasificacion = aux[2];
                pelicula.duracion = aux[3];
                pelicula.horario1 = aux[4];
                pelicula.horario2 = aux[5];
                pelicula.horario3 = aux[6];
                pelicula.horario4 = aux[7];
                pelicula.horario5 = aux[8];
                Peliculas.Add(pelicula);


            }
            leer.Close();
        }



        public static void Cartelera()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cartelera Actual");

            Console.SetCursorPosition(0, 2);
            Console.WriteLine("#");
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("Nombre");
            Console.SetCursorPosition(24, 2);
            Console.WriteLine("Clasificacion");
            Console.SetCursorPosition(42, 2);
            Console.WriteLine("Duracion");
            Console.SetCursorPosition(54, 2);
            Console.WriteLine("Horario 1");
            Console.SetCursorPosition(64, 2);
            Console.WriteLine("Horario 2");
            Console.SetCursorPosition(76, 2);
            Console.WriteLine("Horario 3");
            Console.SetCursorPosition(86, 2);
            Console.WriteLine("Horario 4");
            Console.SetCursorPosition(99, 2);
            Console.WriteLine("Horario 5");

            Console.ForegroundColor = ConsoleColor.Cyan;
            int x = 0;
            foreach (pelicula aux in Peliculas)
            {
                Console.SetCursorPosition(0, 3 + x);
                Console.WriteLine(aux.codigo);
                Console.SetCursorPosition(5, 3 + x);
                Console.WriteLine(aux.nombre);
                Console.SetCursorPosition(24, 3 + x);
                Console.WriteLine(aux.clasificacion);
                Console.SetCursorPosition(42, 3 + x);
                Console.WriteLine(aux.duracion);
                Console.SetCursorPosition(54, 3 + x);
                Console.WriteLine(aux.horario1);
                Console.SetCursorPosition(64, 3 + x);
                Console.WriteLine(aux.horario2);
                Console.SetCursorPosition(76, 3 + x);
                Console.WriteLine(aux.horario3);
                Console.SetCursorPosition(86, 3 + x);
                Console.WriteLine(aux.horario4);
                Console.SetCursorPosition(99, 3 + x);
                Console.WriteLine(aux.horario5);
                x++;
            }
        }
        

        static void Main(string[] args)
        {
            cargarCartelera();
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1. Ver cartelera");
                Console.WriteLine("2. Escoger pelicula por edad(Ejercicio 1)");
                Console.WriteLine("3. Escoger peliculas por horario 2");
                Console.WriteLine("4. salir");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("¿Qué opción desea?: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Cartelera();
                        break;
                    case 2:

                        break;
                    case 3:
                        break;
                    case 4:
                        opcion = 0;
                        break;
                    default:
                        Console.WriteLine("opcion no valida vuelva a intentar");
                        break;


                }
                Console.ReadLine();
            } while (opcion >= 1 && opcion < 4);


        }
    }
}