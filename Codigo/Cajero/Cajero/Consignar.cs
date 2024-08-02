using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    internal class Consignar
    {
        static void consignara(Cuentas cuenta)
        {
            //Cantidad a consignar y fecha
            Console.WriteLine("Digite la cantidad a consignar: ");
            int consignar = int.Parse(Console.ReadLine());
            DateTime fecha = DateTime.Now;
            Console.Clear();

            //Verifico que consignar sea mayor a 10.000
            if (consignar >= 10)
            {
                using (StreamWriter fact = new StreamWriter("C:\\Users\\Fasire\\Desktop\\Factura.txt", true))
                {
                    fact.WriteLine("----------------------------------------------");
                    fact.WriteLine("|Numero de cuenta: {0}", cuenta.NumeroCuenta);
                    fact.WriteLine("----------------------------------------------");
                    fact.WriteLine("COMPROBANTE DE CONSIGNACION");
                    fact.WriteLine("----------------------------------------------");
                    fact.WriteLine("|Fecha y hora: {0}", fecha);
                    fact.WriteLine("----------------------------------------------");
                    fact.WriteLine("Saldo actual: ${0}", cuenta.saldo);
                    fact.WriteLine("----------------------------------------------");
                    fact.WriteLine("|Monto a consignar: ${0}", consignar);
                    fact.WriteLine("----------------------------------------------");
                    cuenta.saldo += consignar;
                    fact.WriteLine("|Total saldo: ${0}", cuenta.saldo);
                    fact.WriteLine("----------------------------------------------");
                    fact.WriteLine("|¡Gracias por utilizar nuestros servicios!");
                    fact.WriteLine("----------------------------------------------");
                    fact.WriteLine("");
                    fact.WriteLine("");
                }

            }
            else
            {
                using (StreamWriter fact = new StreamWriter("C:\\Users\\Fasire\\Desktop\\Factura.txt", true))
                {
                    fact.WriteLine("-----------------------------------------------------------");
                    fact.WriteLine("|Numero de cuenta: {0}", cuenta.NumeroCuenta);
                    fact.WriteLine("-----------------------------------------------------------");
                    fact.WriteLine("|Fecha y hora: {0}", fecha);
                    fact.WriteLine("-----------------------------------------------------------");
                    fact.WriteLine("|La cantidad a consignar debe ser mayor o igual 10.000");
                    fact.WriteLine("-----------------------------------------------------------");
                    fact.WriteLine("");
                    fact.WriteLine("");
                }
            }
        }
    }
}
