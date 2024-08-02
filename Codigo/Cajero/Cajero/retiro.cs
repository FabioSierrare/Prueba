using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    public class retiro
    {
        public void retirar(Cuentas cuenta, double cantidad)
        {
            DateTime fecha = DateTime.Now;
            if (cantidad <= cuenta.saldo && cantidad >= 10 && cantidad <= 2400000)
            {
                //Hago que el texto se guarde en un documento de texto sin borrar los datos ya escritos
                using (StreamWriter fact = new StreamWriter("C:\\Users\\Fasire\\Desktop\\Factura.txt", true))
                {
                    fact.WriteLine("----------------------------------------------");
                    fact.WriteLine("|Factura - CUENTA: {0}", cuenta);
                    fact.WriteLine("----------------------------------------------");
                    fact.WriteLine("COMPROBANTE DE cantidad");
                    fact.WriteLine("----------------------------------------------");
                    fact.WriteLine("|Fecha y hora: {0}", fecha);
                    fact.WriteLine("----------------------------------------------");
                    fact.WriteLine("Saldo actual: ${0}", cuenta.saldo);
                    fact.WriteLine("----------------------------------------------");
                    fact.WriteLine("|Monto retirado: ${0}", cantidad);
                    fact.WriteLine("----------------------------------------------");
                    cuenta.saldo -= cantidad;
                    fact.WriteLine("|Saldo restante: ${0}", cuenta.saldo);
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
                    //cantidad se menor a 10.000
                    if (cantidad < 10)
                    {
                        fact.WriteLine("--------------------------------------------------");
                        fact.WriteLine("Factura - CUENTA: {0}", cuenta.NumeroCuenta);
                        fact.WriteLine("--------------------------------------------------");
                        fact.WriteLine("|Fecha y hora: {0}", fecha);
                        fact.WriteLine("--------------------------------------------------");
                        fact.WriteLine("|El minimo de cantidad es de $10");
                        fact.WriteLine("--------------------------------------------------");
                        fact.WriteLine("");
                        fact.WriteLine("");

                        //cantidad sea mayor a el saldo
                    }
                    else if (cantidad > cuenta.saldo)
                    {
                        fact.WriteLine("--------------------------------------------------");
                        fact.WriteLine("Factura - CUENTA: {0}", cuenta.NumeroCuenta);
                        fact.WriteLine("--------------------------------------------------");
                        fact.WriteLine("|Fecha y hora: {0}", fecha);
                        fact.WriteLine("--------------------------------------------------");
                        fact.WriteLine("|Saldo insuficiente");
                        fact.WriteLine("--------------------------------------------------");
                        fact.WriteLine("");
                        fact.WriteLine("");

                        //cantidad mayor a 2.400.000
                    }
                    else if (cantidad > 2400000)
                    {
                        fact.WriteLine("--------------------------------------------------");
                        fact.WriteLine("Factura - CUENTA: {0}", cuenta.NumeroCuenta);
                        fact.WriteLine("--------------------------------------------------");
                        fact.WriteLine("|Fecha y hora: {0}", fecha);
                        fact.WriteLine("--------------------------------------------------");
                        fact.WriteLine("|El maximo de cantidad es de $2.400.000");
                        fact.WriteLine("--------------------------------------------------");
                        fact.WriteLine("");
                        fact.WriteLine("");
                    }
                }
            }

        }
    }
}
