using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareaaaa4
{
    class ArmasRanged : Armas
    {
        protected string NombreProyectil;
        protected int DañoProyectil;

        public ArmasRanged(string nombreProyectil, int dañoProyectil, string nombre, int daño, float velocidadAtaque, float precio) :base(nombre, daño, velocidadAtaque, precio)
        {
            this.Nombre = nombre;
            this.Daño = daño;
            this.VelocidadAtaque = velocidadAtaque;
            this.Precio = precio;
            this.NombreProyectil = nombreProyectil;
            this.DañoProyectil = dañoProyectil;
           
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Daño: " + Daño + " Velocidadataque: " + VelocidadAtaque + " Precio: " + Precio +  "NombreProyectil: " + NombreProyectil + "DañoProyectil: " + DañoProyectil;
        }


        public float CalcularDaño(int Daño, float VelocidadAtaque, int DañoProyectil )
        {
            return (Daño + DañoProyectil) * VelocidadAtaque;
        }
        public string GetNombreProyectil()
        {
            return NombreProyectil;
        }
        public int GetDañoProyectil()
        {
            return DañoProyectil;
        }



    }
}
