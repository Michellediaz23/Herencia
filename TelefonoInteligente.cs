using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class TelefonoInteligente : Telefono
    {
        internal string Marca;
        internal string Modelo;
        internal decimal Precio;
        internal int Stock;

        public String SistemaOperativo { get; set; }
        public int  MemoriaRam { get; set; }
        public void MostrarInformacionInteligente()
        {

            MostrarInformacion();
            Console.WriteLine($"Sistema Operativo: {SistemaOperativo}, Memoria RAM: {MemoriaRam} GB");
        }
    }
}

