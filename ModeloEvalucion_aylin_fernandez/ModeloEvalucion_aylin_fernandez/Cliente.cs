using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloEvalucion_aylin_fernandez
{
    internal class Cliente
    {
        private string nombre;
        private int numeroCuenta;
        private int saldoAdeuda;
        private int puntos;
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int NumeroCuentas
        {
            set { numeroCuenta = value; }
            get { return numeroCuenta; }
        }
        public int SaldoAdeuda
        {
            set { saldoAdeuda  = value; }
            get { return saldoAdeuda ; }
        }
        public int Puntos
        {
            set { puntos = value; }
            get { return puntos; }
        }
        public Cliente()
        {
            Nombre = nombre;
            NumeroCuentas = numeroCuenta;
            SaldoAdeuda = saldoAdeuda;
            Puntos = puntos;
        }
        // Metodos:
        public void Imprimir()
        {
                Console.WriteLine($"Datos del cliente :" );
                Console.WriteLine($"Nombre: " + Nombre);
                Console.WriteLine($"Número de cuenta: "+ NumeroCuentas );
                Console.WriteLine($"Saldo adeuda: "+ SaldoAdeuda );
                Console.WriteLine($"Puntos buen cliente: "+Puntos );
            
        }
        public bool EsBuenCliente()
        {
                if (SaldoAdeuda == 0)
                {
                    Puntos += 5;
                return true;
            }
            return false;
        }

    }
}
