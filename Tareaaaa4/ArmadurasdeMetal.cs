using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareaaaa4
{
    class ArmadurasdeMetal : ArmadurasdeCuero

       

    {
        private float reducciondeDaño = 



        public ArmadurasdeMetal(string nombre, float reducciondeDaño, float durabilidad) : base(nombre, reducciondeDaño, durabilidad)
        {
            Nombre = nombre;
            ReducciondeDaño = reducciondeDaño;
            Durabilidad = durabilidad;
        }



    }
}
