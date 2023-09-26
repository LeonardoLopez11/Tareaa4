using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareaaaa4
{
    class ArmadurasdeCuero
    {
        protected string Nombre;
        protected float ReducciondeDaño;
        protected float Durabilidad;

        public ArmadurasdeCuero(string nombre, float reducciondeDaño, float durabilidad)
        {
            this.Nombre = nombre;
            this.ReducciondeDaño = reducciondeDaño;
            this.Durabilidad = durabilidad;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Reduccion de Daño: " + ReducciondeDaño + " Durabilidad: " + Durabilidad;
        }


        public string GetNombre()
        {
            return Nombre;
        }
        public float GetReduccionDaño()
        {
            return ReducciondeDaño;
        }
        public float GetDurabilidad()
        {
            return Durabilidad;
        }
        
        




    }
}
