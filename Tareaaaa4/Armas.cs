using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareaaaa4
{
    class Armas
    {
        protected string Nombre;
        protected int Daño;
        protected float VelocidadAtaque;
        protected float Precio;

        public Armas(string nombre, int daño, float velocidadAtaque, float precio)
        {
            this.Nombre = nombre;
            this.Daño = daño;
            this.VelocidadAtaque = velocidadAtaque;
            this.Precio = precio;
        }

        
        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Daño: "+ Daño + " Velocidadataque: " + VelocidadAtaque + " Precio: "+ Precio;
        }

        public float CalcularDPS(int Daño, float VelocidadAtaque)
        {
            return Daño * VelocidadAtaque;

        }

        public string GetNombre()
        {
            return Nombre;
        }
        public int GetDaño()
        {
            return Daño;
        }
        public float GetVelocidadAtaque()
        {
            return VelocidadAtaque;
        }
        public float GetPrecio()
        {
            return Precio;
        }
        




    }
}
