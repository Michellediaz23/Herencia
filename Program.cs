using System;
using System.Collections.Generic;

using ConsoleApp7;

internal class Program
{
    private static void Main(string[] args)
    {
        int contador = 0;

        // Crea instancias de TelefonoInteligente y TelefonoBasico
        TelefonoInteligente telInteligente = new TelefonoInteligente
        {
            Marca = "Samsung",
            Modelo = "Galaxy S55",
            Precio = 999.99m,
            Stock = 10,
            SistemaOperativo = "Android",
            MemoriaRam = 8
        };

        TelefonoBasico telBasico = new TelefonoBasico
        {
            Marca = "huawei",
            Modelo = "p30pro",
            Precio = 200.99m,
            Stock = 50,
            TieneRadioFM = true,
            TieneLinterna = true
        };

        // Muestra la información específica de cada tipo de teléfono utilizando los métodos definidos
        Console.WriteLine("Información del teléfono inteligente:");
        telInteligente.MostrarInformacion();
        telInteligente.MostrarInformacionInteligente();

        Console.WriteLine("\nInformación del teléfono básico:");
        telBasico.MostrarInformacion();
        telBasico.MostrarInformacionBasico();



        // Crea un arreglo de objetos Telefono para almacenar los teléfonos registrados
        List<Telefono> telefonos = new List<Telefono>();

        // Muestra el menú principal


        while (true)
        {
            Console.WriteLine("1. Registrar teléfono");
            Console.WriteLine("2. Mostrar teléfonos registrados");
            Console.WriteLine("3. Consultar stock de un teléfono específico");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Console.Write("Ingrese la marca del teléfono: ");
                    string marca = Console.ReadLine();
                    Console.Write("Ingrese el modelo del teléfono: ");
                    string modelo = Console.ReadLine();
                    Console.Write("Ingrese el precio del teléfono: ");
                    decimal precio = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Ingrese el stock del teléfono: ");
                    int stock = Convert.ToInt32(Console.ReadLine());

                    if (stock > 0)
                    {
                        Console.Write("¿Es un teléfono inteligente? (s/n): ");
                        string esInteligente = Console.ReadLine();

                        if (esInteligente.ToLower() == "s")
                        {
                            Console.Write("Ingrese el sistema operativo del teléfono: ");
                            string sistemaOperativo = Console.ReadLine();
                            Console.Write("Ingrese la memoria RAM del teléfono: ");
                            int memoriaRam = Convert.ToInt32(Console.ReadLine());

                           
                            };
                        }
                        else
                        {
                            Console.Write("¿Tiene radio FM? (s/n): ");
                            bool tieneRadioFM = Console.ReadLine().ToLower() == "s";
                            Console.Write("¿Tiene linterna? (s/n): ");
                            bool tieneLinterna = Console.ReadLine().ToLower() == "s";

                        telefonos[contador] = new TelefonoBasico();

                        contador++;
                        Console.WriteLine("Teléfono esta  registrado con éxito.");
                        Console.WriteLine("El stock debe ser mayor a 0.");

                    }
                    break;
                  

                case 2:
            Console.WriteLine("Teléfonos registrados:");
            for (int i = 0; i < contador; i++)
            {
                telefonos[i].MostrarInformacion();
                if (telefonos[i] is TelefonoInteligente)
                {
                    TelefonoInteligente telefonoInteligente = (TelefonoInteligente)telefonos[i];
                    telefonoInteligente.MostrarInformacionInteligente();
                }
                else if (telefonos[i] is TelefonoBasico)
                {
                    TelefonoBasico telefonoBasico = (TelefonoBasico)telefonos[i];
                    telefonoBasico.MostrarInformacionBasico();
                }
            }
            break;
        case 3:

            Console.Write("Ingrese el modelo del teléfono aque sea de su preferencia : ");
            string modeloConsulta = Console.ReadLine();

            bool encontrado = false;
            for (int i = 0; i < contador; i++)
            {
                if (telefonos[i].Modelo == modeloConsulta)
                {
                    telefonos[i].MostrarInformacion();
                    if (telefonos[i] is TelefonoInteligente)
                    {
                        TelefonoInteligente telefonoInteligente = (TelefonoInteligente)telefonos[i];
                        telefonoInteligente.MostrarInformacionInteligente();
                    }
                    else if (telefonos[i] is TelefonoBasico)
                    {
                        TelefonoBasico telefonoBasico = (TelefonoBasico)telefonos[i];
                        telefonoBasico.MostrarInformacionBasico();
                    }
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró ningún teléfono con el modelo especificado.");
            }
            break;

        case 4:
            Console.WriteLine("¡Finalizado con exito!");
            break;

        }
    }
}

}




