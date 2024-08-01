using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    internal class Program
    {

        static int VerificarCuenta(int cuentav, int[,] cuentas)
        {
            for (int i = 0; i < cuentas.GetLength(0); i++)
            {
                if (cuentas[i, 0] == cuentav)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[,] cuentas = new int[3, 3];

            cuentas[0, 0] = 1000;
            cuentas[0, 1] = 1234;
            cuentas[0, 2] = 50;

            cuentas[1, 0] = 1001;
            cuentas[1, 1] = 0000;
            cuentas[1, 2] = 320;


            cuentas[2, 0] = 1002;
            cuentas[2, 1] = 4321;
            cuentas[2, 2] = 200;

            Console.WriteLine("Digite el numero de cuentas");
            int nverificar = int.Parse(Console.ReadLine());

            int x = 0;
            while (x == 5)
            {
                Console.WriteLine("Digite la opcion");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {

                }
            }


        }
    }
}
