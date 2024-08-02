using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    internal class Program
    {

        
        
        static void Main(string[] args)
        {
            List<Cuentas> ObjCuenta = new List<Cuentas>();

            ObjCuenta.Add(new Cuentas());
            ObjCuenta[0].NumeroCuenta = 1000;
            ObjCuenta[0].pin = 1234;
            ObjCuenta[0].saldo = 200;


            ObjCuenta.Add(new Cuentas());
            ObjCuenta[1].NumeroCuenta = 1001;
            ObjCuenta[1].pin = 0000;
            ObjCuenta[1].saldo = 1200;

            ObjCuenta.Add(new Cuentas());
            ObjCuenta[2].NumeroCuenta = 1002;
            ObjCuenta[2].pin = 4321;
            ObjCuenta[2].saldo = 452;

            Console.WriteLine(ObjCuenta.Count);

            Console.WriteLine("Digite el numero de cuentas");
            int cverificar = int.Parse(Console.ReadLine());

            

            int x = 0;
            while (x != 5)
            {
                Console.WriteLine("Digite la opciones n");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;

                }
            }


        }
    }

    public class Cuentas: retiro
    {
        public int NumeroCuenta{get; set;}
        public int pin { get; set;}
        public double saldo { get; set;}
    }
}
