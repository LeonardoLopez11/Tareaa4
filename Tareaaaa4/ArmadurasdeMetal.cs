using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareaaaa4
{
    class ArmadurasdeMetal : ArmadurasdeCuero
    {
        
        public ArmadurasdeMetal(string nombre, float reducciondeDaño, float durabilidad) : base(nombre, reducciondeDaño, durabilidad)
        {
            this.Nombre = nombre;
            this.ReducciondeDaño = reducciondeDaño * 2;
            this.Durabilidad = durabilidad;
        }
        public override string ToString()
        {
            return "Nombre: " + Nombre + ", Reduccion de Daño: " + ReducciondeDaño + " Durabilidad: " + Durabilidad;
        }






    }
}
