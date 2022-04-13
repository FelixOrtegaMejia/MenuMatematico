using System;
using System.Media;

namespace MenuMatematico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            int z = 0;
            int x = 0;
            int m = 0;

            while (x != 5)
            {
                Console.WriteLine();
                Console.WriteLine("Menu Principal");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("1 - Capturar un Valor");
                Console.WriteLine("2 - Generar Tabla de Multiplicación");
                Console.WriteLine("3 - Determinar si es Primo o No Primo");
                Console.WriteLine("4 - Capturar Matriz 4x4");
                Console.WriteLine("5 - Salir del Programa");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine();

                try
                {
                    x = (Convert.ToInt32(Console.ReadLine()));
                    Console.Beep();
                }

                catch (FormatException)
                {
                    Console.WriteLine("Valor Invalido, debe ser un numero entero.");
                }

                switch (x)
                {
                    case 1:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                        Console.WriteLine("Por favor digite el valor que se quiera capturar");
                        Console.WriteLine();
                        try
                        {
                            z = (Convert.ToInt32(Console.ReadLine()));
                        }

                        catch (FormatException)
                        {
                            Console.WriteLine("Por favor ponga un numero entero");
                            Console.WriteLine();
                            Console.WriteLine("Presione un valor para volver al Menu Principal");
                            Console.ReadKey();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Clear();
                            break;

                        }

                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("El valor capturado es " + z);
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Presiona una tecla para volver al Menu Principal");
                        Console.ReadKey();
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Clear();
                        m = 1;

                        break;

                    case 2:
                        if (m == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Por favor capture un valor con la opción 1");
                            Console.WriteLine();
                            Console.WriteLine("Presione una tecla para volver al Menu Principal");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            ProcedimientoTablaMultiplicar(z);
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Clear();
                        }

                        break;

                    case 3:
                        if (m == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Por favor capture un valor con la opción 1");
                            Console.WriteLine();
                            Console.WriteLine("Presione una tecla para volver al Menu Principal");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                            ProcedimientoMostrarEvaluacionPrimo(z);
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Clear();


                        }



                        break;

                    case 4:

                        try
                        {
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                            ProcedimietoDiagonalesMatriz();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Clear();
                        }
                        catch
                        {
                            Console.WriteLine("Valor Invalido, debe ser un numero entero.");
                            Console.WriteLine();
                            Console.WriteLine("Presione una tecla para volver al principio.");
                            Console.ReadKey();
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Clear();
                        }
                        break;

                    case 5: break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("No ha ingresido un numero valido.");
                        Console.WriteLine();
                        Console.WriteLine("Presione una tecla para volver al Menu Principal");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                }


            }

            Console.Clear();
            Console.WriteLine("Fin del Programa");
        }

        private static void ProcedimientoTablaMultiplicar(int z)
        {
            Console.Clear();
            Console.WriteLine("Table de Multiplicación");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            for (int e = 1; e <= 12; e += 1)
            {
                int f = z * e;
                Console.WriteLine(z + " * " + e + " = " + f);
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Presione una tecla para volver al Menu Principal");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ProcedimientoMostrarEvaluacionPrimo(int z)
        {
            int j = 0;
            int t = 0;
            t = z;
            for (int e = 1; e <= z; e++)
            {
                if (z % e == 0)
                {
                    j++;
                }

            }
            Console.Clear();
            Console.WriteLine("Respuesta");
            Console.WriteLine();
            Console.WriteLine("------------------------------");

            if (j == 2)
            {
                Console.WriteLine("el " + z + " es un numero primo");
            }
            else
            {
                Console.WriteLine("el " + z + " no es un numero primo");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            z = t;
            Console.WriteLine("Presione una tecla para volver al Menu Principal");
            Console.ReadKey();
            Console.Clear();

        }

        public static void ProcedimietoDiagonalesMatriz()
        {
            int[,] matriz;

            matriz = new int[5, 5];

            for (int fila = 1; fila < 5; fila++)
            {
                for (int columna = 1; columna < 5; columna++)
                {
                    Console.WriteLine("escriba las celdas" + "," + fila + "," + columna);
                    matriz[fila, columna] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Clear();

            for (int fila = 1; fila < 5; fila++)
            {
                for (int columna = 1; columna < 5; columna++)
                {
                    Console.Write(string.Format(" | {0,-3} | ", matriz[fila, columna]));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Diagonal Principal");
            Console.WriteLine();
            Console.WriteLine(matriz[1, 1] + ", " + matriz[2, 2] + ", " + matriz[3, 3] + ", " + matriz[4, 4]);
            Console.WriteLine();
            Console.WriteLine("Diagonal Secundaria");
            Console.WriteLine(matriz[4, 1] + ", " + matriz[3, 2] + ", " + matriz[2, 3] + ", " + matriz[1, 4]);
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("Precione una tecla para volver al Menu Principal");
            Console.ReadKey();
            Console.Clear();




        }







    }
}
