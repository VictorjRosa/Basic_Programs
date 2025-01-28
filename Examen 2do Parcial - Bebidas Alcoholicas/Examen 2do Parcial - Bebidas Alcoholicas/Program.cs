using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen_2do_Parcial___Bebidas_Alcoholicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> cantidadMiliLitros = new List<int>();
            List<int> indiceTipos = new List<int>();
            List<int> cantidadPrecios = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                cantidadMiliLitros.Add(random.Next(100, 3001));
                indiceTipos.Add(random.Next(1, 6));
                cantidadPrecios.Add(random.Next(1000, 5001));
            }
            int id = 1;
            List<Bebidas> bebidas = new List<Bebidas>
            {
                new Bebidas(id++, "Margarita", indiceTipos[0], cantidadMiliLitros[0], cantidadPrecios[0]),
                new Bebidas(id++, "Mojito", indiceTipos[1], cantidadMiliLitros[1], cantidadPrecios[1]),
                new Bebidas(id++, "Gintonic", indiceTipos[2], cantidadMiliLitros[2], cantidadPrecios[2]),
                new Bebidas(id++, "Caipirinha", indiceTipos[3], cantidadMiliLitros[3], cantidadPrecios[3]),
                new Bebidas(id++, "Manhattan", indiceTipos[4], cantidadMiliLitros[4], cantidadPrecios[4]),
                new Bebidas(id++, "Piña colada", indiceTipos[5], cantidadMiliLitros[5], cantidadPrecios[5]),
                new Bebidas(id++, "Daiquiri", indiceTipos[6], cantidadMiliLitros[6], cantidadPrecios[6]),
                new Bebidas(id++, "Cosmopolitan", indiceTipos[7], cantidadMiliLitros[7], cantidadPrecios[7]),
                new Bebidas(id++, "Martini", indiceTipos[8], cantidadMiliLitros[8], cantidadPrecios[8]),
                new Bebidas(id++, "Long Island", indiceTipos[9], cantidadMiliLitros[9], cantidadPrecios[9]),
                new Bebidas(id++, "Bloody Mary", indiceTipos[10], cantidadMiliLitros[10], cantidadPrecios[10]),
                new Bebidas(id++, "Sex on the beach", indiceTipos[11], cantidadMiliLitros[11], cantidadPrecios[11]),
                new Bebidas(id++, "Mai Tai", indiceTipos[12], cantidadMiliLitros[12], cantidadPrecios[12]),
                new Bebidas(id++, "Negroni", indiceTipos[13], cantidadMiliLitros[13], cantidadPrecios[13]),
                new Bebidas(id++, "Rusty Nail", indiceTipos[14], cantidadMiliLitros[14], cantidadPrecios[14]),
                new Bebidas(id++, "Sidecar", indiceTipos[15], cantidadMiliLitros[15], cantidadPrecios[15]),
                new Bebidas(id++, "Coco loco", indiceTipos[16], cantidadMiliLitros[16], cantidadPrecios[16]),
                new Bebidas(id++, "Tom Collins", indiceTipos[17], cantidadMiliLitros[17], cantidadPrecios[17]),
                new Bebidas(id++, "Black Russian", indiceTipos[18], cantidadMiliLitros[18], cantidadPrecios[18]),
                new Bebidas(id++, "White Russian", indiceTipos[19], cantidadMiliLitros[19], cantidadPrecios[19])
            };

            int cantPersonas = 0;
            
            for (int j = 0; j < 1000; j++)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Digite cantidad de personas para agregar: ");
                    cantPersonas = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    break;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine($"Ha ocurrido un error inesperado!!!\n\nPresione cualquier tecla para continuar!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            string nombre = "";
            for (int j = 0; j < cantPersonas; j++)
            {
                for (int k = 0; k < 1000; k++)
                {
                    try
                    {
                        if (cantPersonas == 1)
                        {
                            Console.Write("Digite el nombre de la persona: ");
                        }
                        else
                        {
                            Console.Write($"Digite el nombre de la persona #{j + 1}: ");
                        }
                        nombre = Console.ReadLine();
                        if (string.IsNullOrEmpty(nombre))
                        {
                            Console.Clear();
                            Console.WriteLine("El nombre no puede estar vacío, debe digitar un nombre!!!\n\nPresione cualquier tecla para continuar!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ha ocurrido un error inesperado!!!\n\nPresione cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                string tipo = "";
                Console.WriteLine();
                for (int k = 0; k < 1000; k++)
                {
                    Console.WriteLine("Tipos de bebida:\n");
                    Console.WriteLine("1- Whisky\n2- Ron\n3- Vino\n4- Ginebra\n5- Cognac\n");
                    try
                    {
                        Console.Write("Digite el número del tipo de bebida: ");
                        tipo = Console.ReadLine();
                        if (string.IsNullOrEmpty(tipo))
                        {
                            Console.Clear();
                            Console.WriteLine("La opción no puede estar vacía, debe digitar una opción válida!!!\n\nPresione cualquier tecla para continuar!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            if (Convert.ToInt32(tipo) > 0 && Convert.ToInt32(tipo) <= 5)
                            {
                                break;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"La opción no es válida!!!\n\nPresione cualquier tecla para continuar!");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ha ocurrido un error inesperado!!!\n\nPresione cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                int miliLitros = 0;
                for (int k = 0; k < 1000; k++)
                {
                    try
                    {
                        Console.Write("Digite la cantidad de mililitros: ");
                        miliLitros = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ha ocurrido un error inesperado!!!\n\nPresione cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                int precio = 0;
                for (int k = 0; k < 1000; k++)
                {
                    try
                    {
                        Console.Write("Digite el precio: $");
                        precio = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ha ocurrido un error inesperado!!!\n\nPresione cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                Console.Clear();
                bebidas.Add(new Bebidas(id++, nombre, Convert.ToInt32(tipo), miliLitros, precio));
                Console.Clear();
                Console.WriteLine("Agregado satisfactoriamente!!!\n\nPresione cualquier tecla para continuar!");
                Console.ReadKey();
                Console.Clear();
            }
            List<double> preciosWhisky = new List<double>();
            List<double> preciosRon = new List<double>();
            List<double> preciosVino = new List<double>();
            List<double> preciosGinebra = new List<double>();
            List<double> preciosCognac = new List<double>();
            List<double> preciosWhiskyFirst = new List<double>();
            List<double> preciosRonFirst = new List<double>();
            List<double> preciosVinoFirst = new List<double>();
            List<double> preciosGinebraFirst = new List<double>();
            List<double> preciosCognacFirst = new List<double>();
            List<double> preciosWhiskyLast = new List<double>();
            List<double> preciosRonLast = new List<double>();
            List<double> preciosVinoLast = new List<double>();
            List<double> preciosGinebraLast = new List<double>();
            List<double> preciosCognacLast = new List<double>();

            foreach (var b in bebidas)
            {
                if (b.Tipo == "Whisky")
                {
                    preciosWhisky.Add(b.Precio);
                }
                else
                {
                    if (b.Tipo == "Ron")
                    {
                        preciosRon.Add(b.Precio);
                    }
                    else
                    {
                        if (b.Tipo == "Vino")
                        {
                            preciosVino.Add(b.Precio);
                        }
                        else
                        {
                            if (b.Tipo == "Ginebra")
                            {
                                preciosGinebra.Add(b.Precio);
                            }
                            else
                            {
                                if (b.Tipo == "Cognac")
                                {
                                    preciosCognac.Add(b.Precio);
                                }
                            }
                        }
                    }
                }
            }

            double temp;
            for (int j = 0; j < preciosWhisky.Count; j++)
            {
                for (int k = 0; k < preciosWhisky.Count; k++)
                {
                    if (preciosWhisky[k] > preciosWhisky[j])
                    {
                        temp = preciosWhisky[k];
                        preciosWhisky[k] = preciosWhisky[j];
                        preciosWhisky[j] = temp;
                    }
                }
                if (preciosWhisky.First() == preciosWhisky[j])
                {
                    preciosWhiskyFirst.Add(preciosWhisky[j]);
                }
                if (preciosWhisky.Last() == preciosWhisky[j])
                {
                    preciosWhiskyLast.Add(preciosWhisky[j]);
                }
            }
            for (int j = 0; j < preciosRon.Count; j++)
            {
                for (int k = 0; k < preciosRon.Count; k++)
                {
                    if (preciosRon[k] > preciosRon[j])
                    {
                        temp = preciosRon[k];
                        preciosRon[k] = preciosRon[j];
                        preciosRon[j] = temp;
                    }
                }
                if (preciosRon.First() == preciosRon[j])
                {
                    preciosRonFirst.Add(preciosRon[j]);
                }
                if (preciosRon.Last() == preciosRon[j])
                {
                    preciosRonLast.Add(preciosRon[j]);
                }
            }
            for (int j = 0; j < preciosVino.Count; j++)
            {
                for (int k = 0; k < preciosVino.Count; k++)
                {
                    if (preciosVino[k] > preciosVino[j])
                    {
                        temp = preciosVino[k];
                        preciosVino[k] = preciosVino[j];
                        preciosVino[j] = temp;
                    }
                }
                if (preciosVino.First() == preciosVino[j])
                {
                    preciosVinoFirst.Add(preciosVino[j]);
                }
                if (preciosVino.Last() == preciosVino[j])
                {
                    preciosVinoLast.Add(preciosVino[j]);
                }
            }
            for (int j = 0; j < preciosGinebra.Count; j++)
            {
                for (int k = 0; k < preciosGinebra.Count; k++)
                {
                    if (preciosGinebra[k] > preciosGinebra[j])
                    {
                        temp = preciosGinebra[k];
                        preciosGinebra[k] = preciosGinebra[j];
                        preciosGinebra[j] = temp;
                    }
                }
                if (preciosGinebra.First() == preciosGinebra[j])
                {
                    preciosGinebraFirst.Add(preciosGinebra[j]);
                }
                if (preciosGinebra.Last() == preciosGinebra[j])
                {
                    preciosGinebraLast.Add(preciosGinebra[j]);
                }
            }
            for (int j = 0; j < preciosCognac.Count; j++)
            {
                for (int k = 0; k < preciosCognac.Count; k++)
                {
                    if (preciosCognac[k] > preciosCognac[j])
                    {
                        temp = preciosCognac[k];
                        preciosCognac[k] = preciosCognac[j];
                        preciosCognac[j] = temp;
                    }
                }
                if (preciosCognac.First() == preciosCognac[j])
                {
                    preciosCognacFirst.Add(preciosCognac[j]);
                }
                if (preciosCognac.Last() == preciosCognac[j])
                {
                    preciosCognacLast.Add(preciosCognac[j]);
                }
            }

            var ascendente = from b in bebidas
                              orderby b.MiliLitros ascending
                              select b;

            if (preciosWhisky.Count() != 0)
            {
                Console.WriteLine($"Tipo de bebida: {Bebidas.TipoBebida.Whisky} - Cantidad: {preciosWhisky.Count()}\n\nMínimo: ${preciosWhisky[0]} pesos\nMáximo: ${preciosWhisky[preciosWhisky.Count - 1]} pesos\nPromedio: ${Math.Round(preciosWhisky.Average(), 2)} pesos\n");
            }
            else
            {
                Console.WriteLine($"Tipo de bebida: {Bebidas.TipoBebida.Whisky} - Cantidad: {preciosWhisky.Count()}\n");
            }
            if (preciosRon.Count() != 0)
            {
                Console.WriteLine($"Tipo de bebida: {Bebidas.TipoBebida.Ron} - Cantidad: {preciosRon.Count()}\n\nMínimo: ${preciosRon[0]} pesos\nMáximo: ${preciosRon[preciosRon.Count - 1]} pesos\nPromedio: ${Math.Round(preciosRon.Average(x => x), 2)} pesos\n");
            }
            else
            {
                Console.WriteLine($"Tipo de bebida: {Bebidas.TipoBebida.Ron} - Cantidad: {preciosRon.Count()}\n");
            }
            if (preciosVino.Count() != 0)
            {
                Console.WriteLine($"Tipo de bebida: {Bebidas.TipoBebida.Vino} - Cantidad: {preciosVino.Count()}\n\nMínimo: ${preciosVino[0]}  pesos\nMáximo: ${preciosVino[preciosVino.Count - 1]}  pesos\nPromedio: ${Math.Round(preciosVino.Average(x => x), 2)} pesos\n");
            }
            else
            {
                Console.WriteLine($"Tipo de bebida: {Bebidas.TipoBebida.Vino} - Cantidad: {preciosVino.Count()}\n");
            }
            if (preciosGinebra.Count() != 0)
            {
                Console.WriteLine($"Tipo de bebida: {Bebidas.TipoBebida.Ginebra} - Cantidad: {preciosGinebra.Count()}\n\nMínimo: ${preciosGinebra[0]}  pesos\nMáximo: ${preciosGinebra[preciosGinebra.Count - 1]}  pesos\nPromedio: ${Math.Round(preciosGinebra.Average(x => x), 2)} pesos\n");
            }
            else
            {
                Console.WriteLine($"Tipo de bebida: {Bebidas.TipoBebida.Ginebra} - Cantidad: {preciosGinebra.Count()}\n");
            }
            if (preciosCognac.Count() != 0)
            {
                Console.WriteLine($"Tipo de bebida: {Bebidas.TipoBebida.Cognac} - Cantidad: {preciosCognac.Count()}\n\nMínimo: ${preciosCognac[0]}  pesos\nMáximo: ${preciosCognac[preciosCognac.Count - 1]}  pesos\nPromedio: ${Math.Round(preciosCognac.Average(x => x), 2)} pesos\n");
            }
            else
            {
                Console.WriteLine($"Tipo de bebida: {Bebidas.TipoBebida.Cognac} - Cantidad: {preciosCognac.Count()}\n");
            }
            Console.WriteLine($"Promedio total: ${bebidas.Average(x => x.Precio)} pesos");
            Console.WriteLine("\nPresione una tecla para mostrar posibles máximos y mínimos iguales");
            Console.ReadKey();
            Console.Clear();

            if (preciosWhiskyFirst.Count > 1)
            {
                Console.WriteLine($"Precios mínimos del whisky:\n\n");
                foreach (var item in preciosWhiskyFirst)
                {
                    Console.WriteLine($"${item} pesos");
                }
            }
            else
            {
                Console.WriteLine("No hay mínimos iguales");
            }
            if (preciosWhiskyLast.Count > 1)
            {
                Console.WriteLine($"Precios máximos del whisky:\n\n");
                foreach (var item in preciosWhiskyFirst)
                {
                    Console.WriteLine($"${item} pesos");
                }
            }
            else
            {
                Console.WriteLine("No hay máximos iguales");
            }

            if (preciosRonFirst.Count > 1)
            {
                Console.WriteLine($"Precios mínimos del ron:\n\n");
                foreach (var item in preciosRonFirst)
                {
                    Console.WriteLine($"${item} pesos");
                }
            }
            else
            {
                Console.WriteLine("No hay mínimos iguales");
            }
            if (preciosWhiskyLast.Count > 1)
            {
                Console.WriteLine($"Precios máximos del ron:\n\n");
                foreach (var item in preciosRonFirst)
                {
                    Console.WriteLine($"${item} pesos");
                }
            }
            else
            {
                Console.WriteLine("No hay máximos iguales");
            }

            if (preciosVinoFirst.Count > 1)
            {
                Console.WriteLine($"Precios mínimos del vino:\n\n");
                foreach (var item in preciosVinoFirst)
                {
                    Console.WriteLine($"${item} pesos");
                }
            }
            else
            {
                Console.WriteLine("No hay mínimos iguales");
            }
            if (preciosVinoFirst.Count > 1)
            {
                Console.WriteLine($"Precios máximos del vino:\n\n");
                foreach (var item in preciosVinoFirst)
                {
                    Console.WriteLine($"${item} pesos");
                }
            }
            else
            {
                Console.WriteLine("No hay máximos iguales");
            }

            if (preciosGinebraFirst.Count > 1)
            {
                Console.WriteLine($"Precios mínimos del ginebra:\n\n");
                foreach (var item in preciosGinebraFirst)
                {
                    Console.WriteLine($"${item} pesos");
                }
            }
            else
            {
                Console.WriteLine("No hay mínimos iguales");
            }
            if (preciosGinebraFirst.Count > 1)
            {
                Console.WriteLine($"Precios máximos del ginebra:\n\n");
                foreach (var item in preciosGinebraFirst)
                {
                    Console.WriteLine($"${item} pesos");
                }
            }
            else
            {
                Console.WriteLine("No hay máximos iguales");
            }

            if (preciosCognacFirst.Count > 1)
            {
                Console.WriteLine($"Precios mínimos del cognac:\n\n");
                foreach (var item in preciosCognacFirst)
                {
                    Console.WriteLine($"${item} pesos");
                }
            }
            else
            {
                Console.WriteLine("No hay mínimos iguales");
            }
            if (preciosCognacFirst.Count > 1)
            {
                Console.WriteLine($"Precios máximos del cognac:\n\n");
                foreach (var item in preciosCognacFirst)
                {
                    Console.WriteLine($"${item} pesos");
                }
            }
            else
            {
                Console.WriteLine("No hay máximos iguales");
            }

            Console.ReadKey();
        }
    }
}
