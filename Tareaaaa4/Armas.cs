using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareaaaa4
{
    class Armas
    {
        private string Nombre;
        private int Daño;
        private float VelocidadAtaque;
        private float Precio;

        public Armas(string nombre, int daño, float velocidadAtaque, float precio)
        {
            this.Nombre = nombre;
            this.Daño = daño;
            this.VelocidadAtaque = velocidadAtaque;
            Precio = precio;
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
