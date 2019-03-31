using System;
namespace Alumnos
{
    public class CControladora
    {
        public static void Main()
        {
            CAlumnos listadoAlumnos = new CAlumnos();
            char opcion;
            ulong auxLegajo;
            do
            {
                opcion = Convert.ToChar(CInterfaz.darOpcion().ToUpper());
                //.ToUpper() Convierte la cadena a MAYÚSCULAS.
                switch (opcion)
                {
                    case 'C':
                        listadoAlumnos.setCUOTA(Convert.ToSingle(CInterfaz.pedirDato("Cuota General")));
                        break;
                    case 'G':
                        CInterfaz.mostrarInfo(Convert.ToString(listadoAlumnos.getCUOTA()));
                        break;
                    case 'A':
                        auxLegajo = Convert.ToUInt64(CInterfaz.pedirDato("Legajo"));
                        string auxApellidos = CInterfaz.pedirDato("Apellidos");
                        string auxNombres = CInterfaz.pedirDato("Nombres");
                        float auxBeca =Convert.ToSingle( CInterfaz.pedirDato("Beca"));
                        if (!listadoAlumnos.crearAlumno(auxLegajo, auxApellidos, auxNombres, auxBeca))
                        {
                            CInterfaz.mostrarInfo("Legajo Preexistente");
                        }
                        break;
                    case 'M':
                        auxLegajo = Convert.ToUInt64(CInterfaz.pedirDato("Legajo"));
                        CInterfaz.mostrarInfo(listadoAlumnos.darDatos(auxLegajo));
                        break;
                     case 'L':
                        listadoAlumnos.ordenar();
                        CInterfaz.mostrarInfo(listadoAlumnos.darDatos());
                        break;
                    case 'R':
                        auxLegajo = Convert.ToUInt64(CInterfaz.pedirDato("Legajo"));
                        if (!listadoAlumnos.eliminarAlumno(auxLegajo))
                        {
                            CInterfaz.mostrarInfo("Alumno Inexistente");
                        }
                        break;
                    case 'S':
                        break;
                    default:
                        CInterfaz.mostrarInfo("Opción inválida");
                        break;
                }
            } while (opcion != 'S');
        }
    }
}

