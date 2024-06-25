using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades_AylinFernandez
{
     class Club
    {
        private Socios socio1,socio2,socio3;
        public Club()
        {
            socio1 = new Socios();
            socio1.Nombre = "Pedrito"; // para pedir el nombre tambien se puede usar console.writeline("ingrese nombre"); socio.nombre=console.readline();
            socio1.Antiguiedad = 19;
            socio2 = new Socios();
            socio2.Nombre = "Juana";
            socio2.Antiguiedad = 20;
            socio3 = new Socios();
            socio3.Nombre = "Lurdes";
            socio3.Antiguiedad = 20;
        }
        /*  public void Ingresar() // esto se puede eliminar tranquilamente y lo podes poner en donde esta =0
          {
              socio1.Antiguiedad = socio1.Antiguiedad + 20;
              socio2.Antiguiedad = socio2.Antiguiedad + 15;
              socio3.Antiguiedad = socio3.Antiguiedad + 19;
          }*/
        public void Imprimir()
        {
            if (socio2.Antiguiedad> socio1.Antiguiedad & socio2.Antiguiedad > socio3.Antiguiedad)
            {
                Console.WriteLine("El socio con mas antiguedad es: " + socio2.Nombre);
            }else if(socio3.Antiguiedad > socio1.Antiguiedad & socio3.Antiguiedad > socio2.Antiguiedad)
            {
                Console.WriteLine("El socio con mas antiguedad es: " + socio3.Nombre);
            }
            else
            {
                Console.WriteLine("El socio con mas antiguedad es: " + socio1.Nombre);
            }
        }
        static void Main(string[] args)
        {
            Club Clubes = new Club();
            Clubes.Ingresar();
            Clubes.Imprimir();
            Console.ReadKey();
        }
    }
    
} 
