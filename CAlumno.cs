using System;
namespace Alumnos
{
    public class CAlumno
    {
        //Variables Miembro.
        //De Clase.
        private static float CUOTA;
        //De Instancia.
        private ulong legajo;
        private string apellidos;
        private string nombres;
        private float beca;

        //Métodos Miembro.
        //De Clase.
        public static void setCUOTA(float cuo)
        { CAlumno.CUOTA = cuo; }
        public static float getCUOTA()
        { return CAlumno.CUOTA; }
        //De Instancia.
        //Constructores.
        public CAlumno()
        {
        this.apellidos = "Power";
        this.nombres = "Max";
        }
        public CAlumno(ulong leg, string ape, string nom, float bec)
        {
            this.legajo = leg;
            this.apellidos = ape;
            this.nombres = nom;
            this.beca = bec;
        }
        //Setters.
        public void setLegajo(ulong leg)
        { this.legajo = leg; }
        public void setApellidos(string ape)
        { this.apellidos = ape; }
        public void setNombres(string nom)
        { this.nombres = nom; }
        public void setBeca(float bec)
        { this.beca= bec; }
        //Getters.
        public ulong getLegajo()
        { return this.legajo; }
        public string getApellidos()
        { return this.apellidos; }
        public string getNombres()
        { return this.nombres; }
        public float getBeca()
        { return this.beca; }
        //Funcionales.
        public string darDatos()
        {
            string datos = "Legajo: " + this.legajo.ToString();
            datos += " - Alumno: " + this.apellidos + ", " + this.nombres;
            datos += " - Cuota Mensual: $" + this.darCuotaMensual().ToString() + ".";
            return datos;
        }
        public float darCuotaMensual()
        {
            return CAlumno.CUOTA * (1 - this.beca / 100);
        }
    }
}
