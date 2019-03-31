using System;
namespace Alumnos
{
    public class CInterfaz
    {
        static CInterfaz()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static string darOpcion()
        {
            Console.Clear();
            Console.WriteLine("***********************************************");
            Console.WriteLine("*        Sistema de Gestión de Alumnos        *");
            Console.WriteLine("***********************************************");
            Console.WriteLine("\n[C] Establecer Cuota General.");
            Console.WriteLine("\n[G] Conocer Cuota General.");
            Console.WriteLine("\n[A] Agregar un Alumno.");
            Console.WriteLine("\n[M] Mostrar datos de un Alumno.");
            Console.WriteLine("\n[L] Listar los datos de todos los Alumnos.");
            Console.WriteLine("\n[R] Remover un Alumno.");
            Console.WriteLine("\n[S] Salir de la aplicación.");
            Console.WriteLine("\n**********************************************");
            return CInterfaz.pedirDato("opción elegida");
        }
        public static string pedirDato(string nombDato)
        {
            Console.Write("[?] Ingrese " + nombDato + ": ");
            string ingreso = Console.ReadLine();
            while (ingreso == "")
            {
                Console.Write("[!] " + nombDato + "es de ingreso OBLIGATORIO:");
                ingreso = Console.ReadLine();
            }
            Console.Clear();
            return ingreso.Trim();
            //.Trim() Remueve espacios en blanco previos y posteriores.

        }
        public static void mostrarInfo(string mensaje)
        {
            Console.WriteLine(mensaje);
            Console.Write("<Pulse Enter>");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

