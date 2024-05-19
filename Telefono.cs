using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Telefono
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }


        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: (Modelo), Precio: ${Precio}, Stock: ${Stock}");


        }

      
    }
}
