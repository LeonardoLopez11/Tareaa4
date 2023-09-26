using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareaaaa4
{
    class Program
    {

        
        private List<Armas> armasMelee = new List<Armas>();
        private List<ArmasRanged> armasRanged = new List<ArmasRanged>();
        private List<ArmadurasdeCuero> armadurasCuero = new List<ArmadurasdeCuero>();
        private List<ArmadurasdeMetal> armadurasMetal = new List<ArmadurasdeMetal>();


        static void Main(string[] args) {

            List<Armas> armasMelee = new List<Armas>();
            Armas Espada = new Armas("Espada", 20, 25, 500);
            List<ArmasRanged> armasRanged = new List<ArmasRanged>();
            List<ArmadurasdeCuero> armadurasCuero = new List<ArmadurasdeCuero>();
            List<ArmadurasdeMetal> armadurasMetal = new List<ArmadurasdeMetal>();
            ArmasRanged Arco = new ArmasRanged("FLECHA", 20, "ARCO", 150, 20, 500);
            ArmasRanged Pistola = new ArmasRanged("BALA", 50, "PISTOLA", 100, 20, 1000);
            ArmadurasdeCuero Cuero = new ArmadurasdeCuero("Cuero", 50, 100);
            ArmadurasdeMetal Metal = new ArmadurasdeMetal("Metal", 50, 200);




            armasMelee.Add(Espada);
            armasRanged.Add(Arco);
            armasRanged.Add(Pistola);
            armadurasCuero.Add(Cuero);
            armadurasMetal.Add(Metal);



            foreach (var items in armasMelee)
            {
                Console.WriteLine(items.ToString());
                Console.WriteLine($"El DPS es: "+ items.CalcularDPS(items.GetDaño(),items.GetVelocidadAtaque()));
            }
            foreach (var items in armasRanged)
            {
                Console.WriteLine(items.ToString());

            }
            foreach (var items in armadurasCuero)
            {
                Console.WriteLine(items.ToString());

            }

            foreach (var items in armadurasMetal)
            {
                Console.WriteLine(items.ToString());

            }

            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introducir la opción");
                Console.WriteLine("1. Mostrar Articulos");
                Console.WriteLine("2. Ir a la CESTA");
                Console.WriteLine("0. Regresar");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Introducir la opción");
                        Console.WriteLine("1. Mostrar Armas Melee");
                        Console.WriteLine("2. Mostrar Armas Ranged");
                        Console.WriteLine("3. Mostrar Armaduras");
                        Console.WriteLine("4. Mostrar Armaduras de Metal");
                        Console.WriteLine("0. Regresar");
                        string option2 = Console.ReadLine();
                        switch (option2)

                        {
                            case "1":
                                {
                                    foreach (var items in armasMelee)
                                    {
                                        Console.WriteLine(items.ToString());
                                        Console.WriteLine($"El DPS es: " + items.CalcularDPS(items.GetDaño(), items.GetVelocidadAtaque()));
                                    }


                                    break;
                                }
                            case "2":
                                {
                                    foreach (var items in armasRanged)
                                    {
                                        Console.WriteLine(items.ToString());

                                    }

                                    break;
                                }
                            case "3":
                                {
                                    foreach (var items in armadurasCuero)
                                    {
                                        Console.WriteLine(items.ToString());

                                    }

                                    break;
                                }
                            case "4":
                                {
                                    foreach (var items in armadurasMetal)
                                    {
                                        Console.WriteLine(items.ToString());

                                    }

                                    break;
                                }
                                case "0":
                                {

                                    break;
                                }
                        }

                        
                        break;
                    case "2":
                        
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }



        }
        
            
   


             
    }
}

