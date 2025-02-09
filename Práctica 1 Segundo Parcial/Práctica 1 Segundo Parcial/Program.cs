using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_1_Segundo_Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int id = 1;
                List<Asalariado> lista = new List<Asalariado>();
                lista.Add(new Asalariado(id++, "Ale", 150000));
                lista.Add(new Asalariado(id++, "Mayra", 350000));
                lista.Add(new Asalariado(id++, "Stwar t", 450000));
                lista.Add(new Asalariado(id++, "Joan", 600000));
                lista.Add(new Asalariado(id++, "Diego", 850000));
                lista.Add(new Asalariado(id++, "Daniel", 650000));
                lista.Add(new Asalariado(id++, "Joel", 1500000));
                lista.Add(new Asalariado(id++, "Victor", 20000000));
            Console.Write("\t!!! Grupo Hermanos Rosa !!!\n\nIntegrantes:\n\nVíctor Rosa - 19-1028\nAlejandro Rosa - 20-0971\n\nPresione cualquier tecla para comenzar");
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < 10000; i++)
            {
                foreach (var l in lista)
                {
                    if (l.Salario <= 416220)
                    {

                    }
                    else
                    {
                        if (l.Salario >= 416220.01 && l.Salario <= 624329)
                        {
                            l.TasaAnual = Math.Round((l.Salario - 416220.01) * 0.15, 2);
                            l.TasaMensual = Math.Round(((l.Salario - 416220.01) * 0.15) / 12, 2);
                        }
                        else
                        {
                            if (l.Salario >= 624329.01 && l.Salario <= 867123)
                            {
                                l.TasaAnual = Math.Round(31216 + ((l.Salario - 624329.01) * 0.20), 2);
                                l.TasaMensual = Math.Round((31216 + ((l.Salario - 624329.01) * 0.20)) / 12, 2);
                            }
                            else
                            {
                                if (l.Salario >= 867123.01)
                                {
                                    l.TasaAnual = Math.Round(79776 + ((l.Salario - 867123.01) * 0.25), 2);
                                    l.TasaMensual = Math.Round((79776 + ((l.Salario - 867123.01) * 0.25)) / 12, 2);
                                }
                            }
                        }
                    }
                }
                var descendente = from l in lista
                                  orderby l.Salario
                                  select l;

                List<Asalariado> exento = lista.FindAll(x => x.Tipo == Asalariado.Tasa.Exento.ToString());
                List<Asalariado> quincePorciento = lista.FindAll(x => x.Tipo == Asalariado.Tasa.QuincePorciento.ToString());
                List<Asalariado> veintePorCiento = lista.FindAll(x => x.Tipo == Asalariado.Tasa.VeintePorCiento.ToString());
                List<Asalariado> veintiCincoPorCiento = lista.FindAll(x => x.Tipo == Asalariado.Tasa.VeintiCincoPorCiento.ToString());

                Asalariado[] exentos = new Asalariado[exento.Count];
                Asalariado[] quincePorcientos = new Asalariado[quincePorciento.Count];
                Asalariado[] veintePorCientos = new Asalariado[veintePorCiento.Count];
                Asalariado[] veintiCincoPorCientos = new Asalariado[veintiCincoPorCiento.Count];

                exento.CopyTo(exentos);
                quincePorciento.CopyTo(quincePorcientos);
                veintePorCiento.CopyTo(veintePorCientos);
                veintiCincoPorCiento.CopyTo(veintiCincoPorCientos);

                Asalariado temp;
                for (int j = 0; j < exentos.Length; j++)
                {
                    for (int k = 0; k < exentos.Length; k++)
                    {
                        if (exentos[k].Salario > exentos[j].Salario)
                        {
                            temp = exentos[k];
                            exentos[k] = exentos[j];
                            exentos[j] = temp;
                        }
                    }
                }
                for (int j = 0; j < quincePorcientos.Length; j++)
                {
                    for (int k = 0; k < quincePorcientos.Length; k++)
                    {
                        if (quincePorcientos[k].Salario > quincePorcientos[j].Salario)
                        {
                            temp = quincePorcientos[k];
                            quincePorcientos[k] = quincePorcientos[j];
                            quincePorcientos[j] = temp;
                        }
                    }
                }
                for (int j = 0; j < veintePorCientos.Length; j++)
                {
                    for (int k = 0; k < veintePorCientos.Length; k++)
                    {
                        if (veintePorCientos[k].Salario > veintePorCientos[j].Salario)
                        {
                            temp = veintePorCientos[k];
                            veintePorCientos[k] = veintePorCientos[j];
                            veintePorCientos[j] = temp;
                        }
                    }
                }
                for (int j = 0; j < veintiCincoPorCientos.Length; j++)
                {
                    for (int k = 0; k < veintiCincoPorCientos.Length; k++)
                    {
                        if (veintiCincoPorCientos[k].Salario > veintiCincoPorCientos[j].Salario)
                        {
                            temp = veintiCincoPorCientos[k];
                            veintiCincoPorCientos[k] = veintiCincoPorCientos[j];
                            veintiCincoPorCientos[j] = temp;
                        }
                    }
                }
                int opcion = 0;
                int conteo = 0;
                try
                {
                    Console.WriteLine("Información del Asalariado\n");
                    Console.WriteLine("1- Agregar personas\n2- Eliminar personas\n3- Mostrar personas\n4- Mostrar Max, Min y promedio\n5- Salir");
                    Console.Write("\nDigite una opción: ");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    conteo = lista.Count();
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Ha ocurrido un error inesperado!!!\n\n!!! {ex.Message} !!!");
                    Console.ReadKey();
                    Console.Clear();
                }
                switch (opcion)
                {
                    case 1:
                        int cantPersonas = 0;
                        try
                        {
                            Console.Clear();
                            Console.Write("Digite cantidad de personas para agregar: ");
                            cantPersonas = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();
                            Console.WriteLine($"Ha ocurrido un error inesperado!!!\n\n!!! {ex.Message} !!!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        for (int j = 0; j < cantPersonas; j++)
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
                                string nombre = Console.ReadLine();
                                if (string.IsNullOrEmpty(nombre))
                                {
                                    Console.Clear();
                                    Console.WriteLine("El nombre no puede estar vacío, debe digitar un nombre!!!\n\nPresione cualquier tecla para continuar!");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.Write("Digite el salario: ");
                                    int salario = Convert.ToInt32(Console.ReadLine());
                                    lista.Add(new Asalariado(id++, nombre, salario));
                                    Console.Clear();
                                    Console.WriteLine("Agregado satisfactoriamente!!!\n\nPresione cualquier tecla para continuar!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.Clear();
                                Console.WriteLine($"Ha ocurrido un error inesperado!!!\n\n!!! {ex.Message} !!!");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        break;

                    case 2:
                        int opcionEliminar = 0;
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("1- Eliminar última persona agregada\n2- Eliminar una persona en específico\n3- Eliminar todo\n4- Volver al menú");
                            Console.Write("\nDigite una opción: ");
                            opcionEliminar = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();
                            Console.WriteLine($"Ha ocurrido un error inesperado!!!\n\n!!! {ex.Message} !!!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        switch (opcionEliminar)
                        {
                            case 1:
                                int opcionEliminarUltimo = 0;
                                try
                                {
                                    Console.Clear();
                                    if (lista.Count == 0)
                                    {
                                        Console.WriteLine("!!! No hay datos para borrar !!!\n\nPresione cualquier tecla para continuar!");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Desea eliminar a: {lista.Last().Nombre}\n\n1- Sí\t2-No\n");
                                        Console.Write("Elija una opción: ");
                                        opcionEliminarUltimo = Convert.ToInt32(Console.ReadLine());
                                        switch (opcionEliminarUltimo)
                                        {
                                            case 1:
                                                lista.Remove(lista.Last());
                                                Console.Clear();
                                                Console.WriteLine("Eliminado satisfactoriamente!!!\n\nPresione cualquier tecla para continuar!");
                                                Console.ReadKey();
                                                break;
                                            case 2:
                                                Console.Clear();
                                                Console.WriteLine("No se eliminó a nadie!!!\n\nPresione cualquier tecla para continuar!");
                                                Console.ReadKey();
                                                break;
                                            default:
                                                Console.Clear();
                                                Console.Write("La opción digitada no existe !!!\n\nPresione cualquier tecla para continuar!");
                                                Console.ReadKey();
                                                break;
                                        }
                                    }
                                    Console.Clear();
                                }
                                catch (Exception ex)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Ha ocurrido un error inesperado!!!\n\n!!! {ex.Message} !!!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                            case 2:
                                string indiceEliminar = "";
                                try
                                {
                                    Console.Clear();
                                    int indice = 0;
                                    foreach (var item in lista)
                                    {
                                        Console.WriteLine($"Indice: '{indice}' para eliminar a {item.Nombre}");
                                        indice++;
                                    }
                                    Console.WriteLine("Presione 'V' para volver al menú");
                                    Console.Write("\nDigite el indice de la posición que desea eliminar: ");
                                    indiceEliminar = Console.ReadLine();
                                    if (Convert.ToChar(indiceEliminar) == 'v' || Convert.ToChar(indiceEliminar) == 'V')
                                    {
                                        Console.Clear();
                                        Console.WriteLine("No se eliminó a nadie!!!\n\nPresione cualquier tecla para continuar!");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        lista.RemoveAt(Convert.ToInt32(indiceEliminar));
                                        Console.Clear();
                                        Console.WriteLine("Eliminado satisfactoriamente!!!\n\nPresione cualquier tecla para continuar!");
                                        Console.ReadKey();
                                    }
                                    Console.Clear();
                                }
                                catch (Exception ex)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Ha ocurrido un error inesperado!!!\n\n!!! {ex.Message} !!!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                            case 3:
                                int opcionEliminarTodos = 0;
                                try
                                {
                                    Console.Clear();
                                    Console.Write("Desea eliminar a todos\n\n1- Sí\t2-No\n\nElija una opción: ");
                                    opcionEliminarTodos = Convert.ToInt32(Console.ReadLine());
                                    switch (opcionEliminarTodos)
                                    {
                                        case 1:
                                            Console.Clear();
                                            if (lista.Count == 0)
                                            {
                                                Console.WriteLine("!!! No hay datos para borrar !!!\n\nPresione cualquier tecla para continuar!");
                                                Console.ReadKey();
                                            }
                                            else
                                            {
                                                lista.RemoveAll(x => x.Id > 0);
                                                Console.WriteLine("Eliminados satisfactoriamente!!!\n\nPresione cualquier tecla para continuar!");
                                                Console.ReadKey();
                                            }
                                            break;
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine("No se eliminó a nadie!!!\n\nPresione cualquier tecla para continuar!");
                                            Console.ReadKey();
                                            break;
                                        default:
                                            Console.Clear();
                                            Console.Write("La opción digitada no existe !!!\n\nPresione cualquier tecla para continuar!");
                                            Console.ReadKey();
                                            break;
                                    }
                                    Console.Clear();
                                }
                                catch (Exception ex)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Ha ocurrido un error inesperado!!!\n\n!!! {ex.Message} !!!");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                break;
                            case 4:
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.Write("La opción digitada no existe !!!\n\nPresione cualquier tecla para continuar!");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                        break;

                    case 3:
                        Console.Clear();
                        foreach (var l in descendente)
                        {
                            Console.WriteLine($"Nombre: {l.Nombre}\nSalario: ${l.Salario} pesos\nTipo de tasa: {l.Tipo}\nTasa Anual: ${l.TasaAnual} pesos\nTasa mensual: ${l.TasaMensual} pesos\n");
                        }
                        if (exentos.Length == 0 && quincePorcientos.Length == 0 && veintePorCientos.Length == 0 && veintiCincoPorCientos.Length == 0)
                        {
                            Console.WriteLine("!!! No hay datos para mostrar !!!");
                        }
                        Console.Write("\nPresione cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        int e = 0;
                        int v = 0;
                        int vc = 0;
                        int q = 0;
                        foreach (var l in descendente)
                        {
                            if (l.Salario <= 416220)
                            {
                                e++;
                            }
                            else
                            {
                                if (l.Salario >= 416220.01 && l.Salario <= 624329)
                                {
                                    q++;
                                }
                                else
                                {
                                    if (l.Salario >= 624329.01 && l.Salario <= 867123)
                                    {
                                        v++;
                                    }
                                    else
                                    {
                                        if (l.Salario >= 867123.01)
                                        {
                                            vc++;
                                        }
                                    }
                                }
                            }
                        }
                        double exentoPromedioTotal = 0;
                        double quincePromedioTotal = 0;
                        double veintePromedioTotal = 0;
                        double vCincoPromedioTotal = 0;
                        foreach (var ex in exentos)
                        {
                            exentoPromedioTotal += ex.Salario;
                        }
                        foreach (var quince in quincePorcientos)
                        {
                            quincePromedioTotal += quince.Salario;
                        }
                        foreach (var veinte in veintePorCientos)
                        {
                            veintePromedioTotal += veinte.Salario;
                        }
                        foreach (var vCinco in veintiCincoPorCientos)
                        {
                            vCincoPromedioTotal += vCinco.Salario;
                        }

                        if (exentos.Length != 0)
                        {
                            Console.WriteLine($"Renglón: {Asalariado.Tasa.Exento} - Cantidad: {e}\n\nMínimo: ${exentos[0].Salario} pesos\nMáximo: ${exentos[exentos.Length - 1].Salario} pesos\nPromedio: ${Math.Round((exentos[0].Salario + exentos[exentos.Length - 1].Salario) / 2, 2)} pesos\nPromedio general: ${Math.Round(exentoPromedioTotal / exentos.Length, 2)} pesos\n");
                        }
                        else
                        {
                            Console.WriteLine($"Renglón: {Asalariado.Tasa.Exento} - Cantidad: {e}\n");
                        }
                        if (quincePorcientos.Length != 0)
                        {
                            Console.WriteLine($"Renglón: {Asalariado.Tasa.QuincePorciento} - Cantidad: {q}\n\nMínimo: ${quincePorcientos[0].Salario} pesos\nMáximo: ${quincePorcientos[quincePorcientos.Length - 1].Salario} pesos\nPromedio: ${Math.Round((quincePorcientos[0].Salario + quincePorcientos[quincePorcientos.Length - 1].Salario) / 2, 2)} pesos\nPromedio general: ${Math.Round(quincePromedioTotal / quincePorcientos.Length, 2)} pesos\n");
                        }
                        else
                        {
                            Console.WriteLine($"Renglón: {Asalariado.Tasa.QuincePorciento} - Cantidad: {q}\n");
                        }
                        if (veintePorCientos.Length != 0)
                        {
                            Console.WriteLine($"Renglón: {Asalariado.Tasa.VeintePorCiento} - Cantidad: {v}\n\nMínimo: $ {veintePorCientos[0].Salario}  pesos\nMáximo: ${veintePorCientos[veintePorCientos.Length - 1].Salario}  pesos\nPromedio: ${Math.Round((veintePorCientos[0].Salario + veintePorCientos[veintePorCientos.Length - 1].Salario) / 2, 2)} pesos\nPromedio general: ${Math.Round(veintePromedioTotal / veintePorCientos.Length, 2)} pesos\n");
                        }
                        else
                        {
                            Console.WriteLine($"Renglón: {Asalariado.Tasa.VeintePorCiento} - Cantidad: {v}\n");
                        }
                        if (veintiCincoPorCientos.Length != 0)
                        {
                            Console.WriteLine($"Renglón: {Asalariado.Tasa.VeintiCincoPorCiento} - Cantidad: {vc}\n\nMínimo: $ {veintiCincoPorCientos[0].Salario}  pesos\nMáximo: ${veintiCincoPorCientos[veintiCincoPorCientos.Length - 1].Salario}  pesos\nPromedio: ${Math.Round((veintiCincoPorCientos[0].Salario + veintiCincoPorCientos[veintiCincoPorCientos.Length - 1].Salario) / 2, 2)} pesos\nPromedio general: ${Math.Round(vCincoPromedioTotal / veintiCincoPorCientos.Length, 2)} pesos");
                        }
                        else
                        {
                            Console.WriteLine($"Renglón: {Asalariado.Tasa.VeintiCincoPorCiento} - Cantidad: {vc}\n");
                        }
                        Console.Write("\nPresione cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Gracias por su visita, hasta luego!!!");
                        break;

                    default:
                        Console.Clear();
                            Console.Write("La opción digitada no existe !!!\n\nPresione cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                if (opcion == 5)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
