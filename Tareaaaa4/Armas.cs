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
            this.Precio = precio;
        }
        public Armas()
        {

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
        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public void SetDaño(int Daño)
        {
            this.Daño = Daño;
        }
        public void SetVelocidadAtaque(float VelocidadAtaque)
        {
            this.VelocidadAtaque = VelocidadAtaque;
        }
        public void SetPrecio(float Precio)
        {
            this.Precio = Precio;
        }




    }
}
