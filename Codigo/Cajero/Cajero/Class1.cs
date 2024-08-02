using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    internal class Class1
    {
        static void consulta(Cuentas cuenta)
        {
            DateTime fecha = DateTime.Now;
            using (StreamWriter fact = new StreamWriter("C:\\Users\\Fasire\\Desktop\\Factura.txt", true))
            {
                fact.WriteLine("----------------------------------------------");
                fact.WriteLine("|Numero de cuenta: {0}", cuenta.saldo);
                fact.WriteLine("----------------------------------------------");
                fact.WriteLine("CONSULTA DE SALDO");
                fact.WriteLine("----------------------------------------------");
                fact.WriteLine("|Fecha y hora: {0}", fecha);
                fact.WriteLine("----------------------------------------------");
                fact.WriteLine("|Total saldo: ${0}", cuenta.saldo);
                fact.WriteLine("----------------------------------------------");
                fact.WriteLine("|¡Gracias por utilizar nuestros servicios!");
                fact.WriteLine("----------------------------------------------");
                fact.WriteLine("");
                fact.WriteLine("");
            }
        }
    }
}
