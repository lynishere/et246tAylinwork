using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloEvalucion_aylin_fernandez
{
    internal class Fiambreria
    {
        private Cliente[] cliente;
        public Fiambreria()
        {
            cliente = new Cliente[4];
            for (int i =0; i < 4; i++) // en esta parte ingresamos  los datos.
            {
                cliente[i] = new Cliente();
                // cliente[i]=new Cliente ("",0,0,0);
                Console.WriteLine($"Ingrese los datos del cliente {i + 1}:");
                Console.Write("Ingrese el nombre:");
                cliente[i].Nombre = Console.ReadLine();
                Console.Write("Ingrese el numero de cuenta: ");
                cliente[i].NumeroCuentas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el saldo que adeuda: ");
                cliente[i].SaldoAdeuda = int.Parse(Console.ReadLine());
                Console.Write("Ingrese lso puntos por ser buen cliente: ");
                cliente[i].Puntos = int.Parse(Console.ReadLine());
            }
        }
    
       
        public void CalculoDeDeudaTotal()
        {
            int deudatotal = 0;
            for (int i = 0; i < 4; i++)
            {
                deudatotal += cliente[i].SaldoAdeuda;
            }
            Console.WriteLine("Total que de dinero que debe: " + deudatotal);
        }
        public void ClientesVip()
        {
            for (int i = 0; i < 4; i++)
            {
                if (cliente[i].Puntos > 25)
                {
                    Console.WriteLine($"Nombre: {cliente[i].Nombre} ");
                    Console.WriteLine("Número de cuenta:  " + cliente[i].NumeroCuentas);
                }
            }
        }
        public void ImprimirC()
        {
            for (int i = 0; i < 4; i++)
            {
                cliente[i].Imprimir();
                if (cliente[i].EsBuenCliente())
                {
                    Console.WriteLine($"El cliente {cliente[i].Nombre} es buen cliente y se le agregan 5 puntos.");
                }
            }
        }
        static void Main(string[] args)
        {
            Fiambreria fiemabreria = new Fiambreria();
            fiemabreria.ImprimirC();
            fiemabreria.CalculoDeDeudaTotal();
            fiemabreria.ClientesVip();
            Console.ReadKey();
        }
    }
}
