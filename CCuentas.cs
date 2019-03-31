using System;
using System.Collections;
namespace Alumnos
{
    public class CAlumnos
    {
        //Variables Miembro
        private ArrayList listado;

        //Constructor
        public CAlumnos()
        {
            this.listado = new ArrayList();
        }
        //Metodos
        public CAlumno buscaAlumno(ulong leg)
        {
            foreach (CAlumno aux in this.listado)
            {
                if (aux.getLegajo() == leg) return aux;
            }
            return null;
        }

        public bool crearAlumno(ulong leg, string ape, string nom, float bec)
        {
            if (this.buscaAlumno(leg) == null)
            {
                this.listado.Add(new CAlumno(leg,ape,nom,bec));
                return true;
            }
            return false;
        }

        public string darDatos(ulong leg)
        {
            CAlumno aux = this.buscaAlumno(leg);
            if (aux != null) return aux.darDatos();
            return "Alumno inexistente";
        }

        public string darDatos()
        {

            if (this.listado.Count != 0)
            {
                String datos = "";
                foreach (CAlumno aux in this.listado) datos += aux.darDatos() + "\n";
                return datos;
            }
            return "No se registraron alumnos válidos";
        }

        public bool eliminarAlumno(ulong leg)
        {
            CAlumno aux = this.buscaAlumno(leg);
            if (aux != null)
            {
                this.listado.Remove(aux);
                return true;
            }
            return false;
        }

        public void setCUOTA(float cuo)
        {
            CAlumno.setCUOTA(cuo);
        }

        public float getCUOTA()
        {
            return CAlumno.getCUOTA();
        }
        public float darCuotaMensual(ulong leg)
        {
            CAlumno aux = this.buscaAlumno(leg);
            if (aux != null) return aux.darCuotaMensual();
            return 0.0f;
        }
        public void ordenar()
        {
            for (int i = 0; i < this.listado.Count - 1; i++)
            {
                for (int j = i + 1; j < this.listado.Count; j++)
                {
                    if (((CAlumno)this.listado[i]).getLegajo() > ((CAlumno)this.listado[j]).getLegajo())
                    {
                        CAlumno auxCta = (CAlumno)this.listado[i];
                        this.listado[i] = this.listado[j];
                        this.listado[j] = auxCta;
                    }
                }
            }
        }
    }
}

