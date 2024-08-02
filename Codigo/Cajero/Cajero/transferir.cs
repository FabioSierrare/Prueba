using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    internal class transferir
    {
        static void transferi(Cuentas cuenta, List<Cuentas> cuentas)
        {
            //datos de transferencia - ctransferir y cantidad
            //fecha y una variable sw
            Console.WriteLine("Digite el numero de cuenta a transeferir");
            int cuentat = int.Parse(Console.ReadLine());

            DateTime fecha = DateTime.Now;

            for (int i = 0; i < cuentas.Count; i++)
            {
                Console.WriteLine("Digite la cantidad a transeferir");
                double cantidaa = double.Parse(Console.ReadLine());
                if (cuentas[i].NumeroCuenta == cuenta.NumeroCuenta)
                {

                    if (cantidaa >= 10 && cantidaa <= cuenta.saldo)
                                    {
                                        using (StreamWriter fact = new StreamWriter("C:\\Users\\Fasire\\Desktop\\Factura.txt", true))
                                        {
                                            fact.WriteLine("----------------------------------------------");
                                            fact.WriteLine("|Numero de cuenta: {0}", cuenta.NumeroCuenta);
                                            fact.WriteLine("----------------------------------------------");
                                            fact.WriteLine("COMPROBANTE DE TRANSFERENCIA");
                                            fact.WriteLine("----------------------------------------------");
                                            fact.WriteLine("|Fecha y hora: {0}", fecha);
                                            fact.WriteLine("----------------------------------------------");
                                            fact.WriteLine("Saldo actual: ${0}", cuenta.saldo);
                                            fact.WriteLine("----------------------------------------------");
                                            fact.WriteLine("|Monto a Transferir: ${0}", cantidaa);
                                            fact.WriteLine("----------------------------------------------");
                                            fact.WriteLine("|Transferir a: {0}", cuentat);
                                            fact.WriteLine("----------------------------------------------");
                                            cuenta.saldo -= cantidaa;
                                            cuentas[i].saldo += cantidaa;
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
                                            if(cantidaa < 10)
                                            {
                                                fact.WriteLine("--------------------------------------------------");
                                                fact.WriteLine("|Numero de cuenta: {0}", cuenta.NumeroCuenta);
                                                fact.WriteLine("--------------------------------------------------");
                                                fact.WriteLine("|Fecha y hora: {0}", fecha);
                                                fact.WriteLine("--------------------------------------------------");
                                                fact.WriteLine("|El monto minimo es de $10");
                                                fact.WriteLine("--------------------------------------------------");
                                                fact.WriteLine("");
                                                fact.WriteLine("");
                                            } 
                                            else if(cantidaa > cuenta.saldo)
                                            {
                                                fact.WriteLine("--------------------------------------------------");
                                                fact.WriteLine("|Numero de cuenta: {0}", cuenta.NumeroCuenta);
                                                fact.WriteLine("--------------------------------------------------");
                                                fact.WriteLine("|Fecha y hora: {0}", fecha);
                                                fact.WriteLine("--------------------------------------------------");
                                                fact.WriteLine("|Saldo insuficiente");
                                                fact.WriteLine("--------------------------------------------------");
                                                fact.WriteLine("");
                                                fact.WriteLine("");
                                            }

                                        }
                                        
                                    }
                }
            }
        }
    }
}
