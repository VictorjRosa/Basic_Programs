using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_2_segundo_parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaNacimiento = DateTime.Now;
            DateTime dateTimeNow = DateTime.Now;
            double edadAño = 0;
            int id = 0;
            List<DatosPersonales> lista = new List<DatosPersonales>();
            List<string> nombres = new List<string>
            {
                "Victor",
                "Alejandro",
                "Mayra",
                "Joel",
                "Miguel",
                "Braulio",
                "Elizabeth",
                "Lisbeth",
                "Daniel",
                "Michael",
                "Joan",
                "Stwart",
                "Diego",
                "Ian",
                "Nathaly",
                "Nicole",
                "Jose ramon",
                "Maria",
                "Salomon",
                "Julio"
            };

            List<string> cedulas = new List<string>
            {
                "402-1369763-0",
                "402-0904703-0",
                "001-0726435-0",
                "249-6034331-6",
                "967-8209697-2",
                "443-9079876-0",
                "533-7877840-6",
                "256-2399776-6",
                "402-2755431-4",
                "206-9377891-7",
                "402-2750551-4",
                "402-2743847-4",
                "402-1053786-2",
                "402-3295455-8",
                "402-0990849-6",
                "402-0961294-0",
                "108-8328885-3",
                "804-0735112-4",
                "946-1649469-9",
                "521-3199675-5"
            };

            Random año = new Random();
            Random mes = new Random();
            Random dia = new Random();
            int fechaAño = 0;
            int fechaMes = 0;
            int fechaDia = 0;
            int llenar = 0;
            for (int i = 0; i < 25; i++)
            {
                fechaAño = año.Next(1992, 2021);
                bool bisiesto = DateTime.IsLeapYear(fechaAño);
                fechaMes = mes.Next(1, 12);
                switch (llenar)
                {
                    case 0:
                        if (fechaMes == 2)
                        {
                            fechaDia = dia.Next(1, 28);
                        }
                        else
                        {
                            if (fechaMes == 2 && bisiesto == true)
                            {
                                fechaDia = dia.Next(1, 29);
                            }
                            else
                            {

                                if (fechaMes == 1 || fechaMes == 3 || fechaMes == 5 || fechaMes == 7 || fechaMes == 8 || fechaMes == 10 || fechaMes == 12)
                                {
                                    fechaDia = dia.Next(1, 31);
                                }
                                else
                                {
                                    fechaDia = dia.Next(1, 30);
                                }
                            }
                        }
                        DateTime fechasFijas = new DateTime(fechaAño, fechaMes, fechaDia);
                        lista.Add(new DatosPersonales(id + 1, nombres[id], cedulas[id], fechasFijas));
                        id++;
                        break;
                    default:
                        break;
                }
                if (id == 20)
                {
                    break;
                }
            }
            foreach (var l in lista)
            {
                TimeSpan dateTimeTotal = dateTimeNow.Subtract(l.FechaNacimiento);
                edadAño = Convert.ToInt32(dateTimeTotal.TotalDays) / 365;
                    l.Edad = Convert.ToInt32(edadAño);
            }
            List<string> multiplo = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    multiplo.Add("1");
                }
                else
                {
                    multiplo.Add("2");
                }
            }
            List<string> cedulaSinGuion = new List<string>();
            foreach (var item in cedulas)
            {
                cedulaSinGuion.Add("");
            }
            for (int i = 0; i < cedulas.Count; i++)
            {
                foreach (char c in cedulas[i])
                {
                    if (c >= '0' && c <= '9' && c != '-')
                    {
                        cedulaSinGuion[i] = ((string.Concat(cedulaSinGuion[i], c)));
                    }
                }
            }
            int word = 0;
            string digVerificador = "";
            int producto = 0;
            int suma = 0;
            int entero = 0;
            int longitud = 0;
            List<bool> result = new List<bool>();
            for (int i = 0; i < cedulas.Count; i++)
            {
                suma = 0;
                longitud = multiplo.Count;
                foreach (char c in cedulaSinGuion[i])
                {
                    if (cedulaSinGuion[i] != "" && word <= 9)
                    {
                        producto = Convert.ToInt16(c - 48) * Convert.ToInt16(multiplo[word]);
                        suma += (producto / 10) + (producto % 10);
                    }
                    word++;
                }
                entero = (suma / 10) * 10;
                if (entero < suma)
                {
                    entero += 10;
                }
                digVerificador = Convert.ToString(entero - suma);
                if (digVerificador == cedulas[i].Substring(12,1))
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
                word = 0;
            }
            int masMas = 0;
            foreach (var l in lista)
            {
                l.Validacion = result[masMas];
                masMas++;
            }
            Console.Clear();
            Console.Write("\t!!! Grupo Hermanos Rosa !!!\n\nIntegrantes:\n\nVíctor Rosa - 19-1028\nAlejandro Rosa - 20-0971\n\nPresione cualquier tecla para comenzar");
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < 10000; i++)
            {
                var descendente = from l in lista
                                  orderby l.Edad
                                  select l;

                var ordenadoPorTrue = from l in lista
                                  orderby l.Validacion descending
                                  select l;

                int opcion = 0;
                int conteo = 0;
                try
                {
                    Console.WriteLine("Información del ciudadano\n");
                    Console.WriteLine("1- Agregar personas\n2- Eliminar personas\n3- Mostrar personas\n4- Mostrar veracidad de las cedulas\n5- Mostrar media, moda y mediana\n6- Salir");
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
                                        nombres.Add(nombre);
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
                            string cedula = "";
                            string temp = "";
                            for (int k = 0; k < 1000; k++)
                            {
                                try
                                {
                                    Console.Write("Digite la cédula, ejemplo (123-1234567-1): ");
                                    cedula = Console.ReadLine();
                                    if (string.IsNullOrEmpty(cedula))
                                    {
                                        Console.Clear();
                                        Console.WriteLine("La cédula no puede estar vacía, debe digitar una cédula!!!\n\nPresione cualquier tecla para continuar!");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        foreach (char c in cedula)
                                        {
                                            if (c >= '0' && c <= '9' && c != '-')
                                            {
                                                temp = string.Concat(temp, c);
                                            }
                                        }
                                        if (temp.Length == 11)
                                        {
                                            cedulas.Add(cedula);
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("!!! La cedula debe tener 11 números !!!\n\nPresione cualquier tecla para continuar!");
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
                            for (int k = 0; k < 1000; k++)
                            {
                                try
                                {
                                    Console.Write("Digite la fecha de nacimiento: ");
                                    fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                                    if (fechaNacimiento.Year > dateTimeNow.Year
                                        || (fechaNacimiento.Year == dateTimeNow.Year && fechaNacimiento.Month > dateTimeNow.Month)
                                        || (fechaNacimiento.Year == dateTimeNow.Year && fechaNacimiento.Month == dateTimeNow.Month && fechaNacimiento.Day > dateTimeNow.Day))
                                    {
                                        Console.Clear();
                                        Console.WriteLine("!!! No has nacido, digite una fecha en la que si existas !!!\n\nPresione cualquier tecla para continuar!");
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
                            Console.Clear();
                            lista.Add(new DatosPersonales(id++, nombre, cedula, fechaNacimiento));
                            Console.Clear();
                            Console.WriteLine("Agregado satisfactoriamente!!!\n\nPresione cualquier tecla para continuar!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        try
                        {
                            foreach (var l in lista)
                            {
                                TimeSpan dateTimeTotal = dateTimeNow.Subtract(l.FechaNacimiento);
                                edadAño = Convert.ToInt32(dateTimeTotal.TotalDays) / 365;
                                l.Edad = Convert.ToInt32(edadAño);
                            }
                            for (int f = 0; f < cantPersonas; f++)
                            {
                                cedulaSinGuion.Add("");
                            }
                            for (int j = cedulas.Count - cantPersonas; j < cedulas.Count; j++)
                            {
                                foreach (char c in cedulas[j])
                                {
                                    if (c >= '0' && c <= '9' && c != '-')
                                    {
                                        cedulaSinGuion[j] = string.Concat(cedulaSinGuion[j], c);
                                    }
                                }
                            }
                            for (int j = cedulas.Count - cantPersonas; j < cedulas.Count; j++)
                            {
                                suma = 0;
                                longitud = multiplo.Count;
                                foreach (char c in cedulaSinGuion[j])
                                {
                                    if (cedulaSinGuion[j] != "" && word <= 9)
                                    {
                                        producto = Convert.ToInt16(c - 48) * Convert.ToInt16(multiplo[word]);
                                        suma += (producto / 10) + (producto % 10);
                                    }
                                    word++;
                                }
                                entero = (suma / 10) * 10;
                                if (entero < suma)
                                {
                                    entero += 10;
                                }
                                digVerificador = Convert.ToString(entero - suma);
                                if (digVerificador == cedulaSinGuion[j].Substring(10, 1))
                                {
                                    result.Add(true);
                                }
                                else
                                {
                                    result.Add(false);
                                }
                                word = 0;
                            }
                            for (int j = result.Count - cantPersonas; j < result.Count; j++)
                            {
                                lista[j].Validacion = result[j];
                            }

                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine($"Ha ocurrido un error inesperado!!!\n\nPresione cualquier tecla para continuar!");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case 2:
                        string opcionEliminar = "";
                        for (int j = 0; j < 1000; j++)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("1- Eliminar última persona agregada\n2- Eliminar una persona en específico\n3- Eliminar todo\n4- Volver al menú");
                                Console.Write("\nDigite una opción: ");
                                opcionEliminar = Console.ReadLine();
                                if (string.IsNullOrEmpty(opcionEliminar))
                                {
                                    Console.Clear();
                                    Console.WriteLine("La opción no puede estar vacía, debe digitar una opción!!!\n\nPresione cualquier tecla para continuar!");
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
                        switch (Convert.ToInt32(opcionEliminar))
                        {
                            case 1:
                                string opcionEliminarUltimo = "";
                                Console.Clear();
                                if (lista.Count == 0)
                                {
                                    Console.WriteLine("!!! No hay datos para borrar !!!\n\nPresione cualquier tecla para continuar!");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    for (int j = 0; j < 1000; j++)
                                    {
                                        try
                                        {
                                            Console.WriteLine($"Desea eliminar a: {lista.Last().Nombre}\n\n1- Sí\t2-No\n");
                                            Console.Write("Elija una opción: ");
                                            opcionEliminarUltimo = Console.ReadLine();
                                            if (string.IsNullOrEmpty(opcionEliminarUltimo))
                                            {
                                                Console.Clear();
                                                Console.WriteLine("La opción no puede estar vacía, debe digitar una opción!!!\n\nPresione cualquier tecla para continuar!");
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
                                    switch (Convert.ToInt32(opcionEliminarUltimo))
                                    {
                                        case 1:
                                            lista.Remove(lista.Last());
                                            result.Remove(result.Last());
                                            cedulas.Remove(cedulas.Last());
                                            cedulaSinGuion.Remove(cedulaSinGuion.Last());
                                            nombres.Remove(nombres.Last());
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
                                break;
                            case 2:
                                string indiceEliminar = "";
                                Console.Clear();
                                for (int j = 0; j < 1000; j++)
                                {
                                    try
                                    {
                                        int indice = 1;
                                        foreach (var item in lista)
                                        {
                                            Console.WriteLine($"Indice: '{indice}' para eliminar a {item.Nombre}");
                                            indice++;
                                        }
                                        Console.WriteLine("Presione '0' para volver al menú");
                                        Console.Write("\nDigite el indice de la posición que desea eliminar: ");
                                        indiceEliminar = Console.ReadLine();
                                        if (string.IsNullOrEmpty(indiceEliminar))
                                        {
                                            Console.Clear();
                                            Console.WriteLine("La opción no puede estar vacía, debe digitar una opción!!!\n\nPresione cualquier tecla para continuar!");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            if (Convert.ToInt32(indiceEliminar) > lista.Count)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("La opción no existe, debe digitar una opción válida!!!\n\nPresione cualquier tecla para continuar!");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                break;
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
                                if (Convert.ToInt32(indiceEliminar) == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("No se eliminó a nadie!!!\n\nPresione cualquier tecla para continuar!");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    lista.RemoveAt(Convert.ToInt32(indiceEliminar) - 1);
                                    result.RemoveAt(Convert.ToInt32(indiceEliminar) - 1);
                                    cedulas.RemoveAt(Convert.ToInt32(indiceEliminar) - 1);
                                    cedulaSinGuion.RemoveAt(Convert.ToInt32(indiceEliminar) - 1);
                                    nombres.RemoveAt(Convert.ToInt32(indiceEliminar) - 1);

                                    Console.Clear();
                                    Console.WriteLine("Eliminado satisfactoriamente!!!\n\nPresione cualquier tecla para continuar!");
                                    Console.ReadKey();
                                }
                                Console.Clear();
                                break;
                            case 3:
                                string opcionEliminarTodos = "";
                                Console.Clear();
                                for (int j = 0; j < 1000; j++)
                                {
                                    try
                                    {
                                        Console.Write("Desea eliminar a todos\n\n1- Sí\t2-No\n\nElija una opción: ");
                                        opcionEliminarTodos = Console.ReadLine();
                                        if (string.IsNullOrEmpty(opcionEliminarTodos))
                                        {
                                            Console.Clear();
                                            Console.WriteLine("La opción no puede estar vacía, debe digitar una opción!!!\n\nPresione cualquier tecla para continuar!");
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
                                switch (Convert.ToInt32(opcionEliminarTodos))
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
                                            result.RemoveAll(x => x == false || true);
                                            for (int n = cedulas.Count - 1; n >= 0; n--)
                                            {
                                                cedulas.RemoveAll(x => x == cedulas[n]);
                                            }
                                            for (int n = cedulaSinGuion.Count - 1; n >= 0; n--)
                                            {
                                                cedulaSinGuion.RemoveAll(x => x == cedulaSinGuion[n]);
                                            }
                                            for (int n = nombres.Count - 1; n >= 0; n--)
                                            {
                                                nombres.RemoveAll(x => x == nombres[n]);
                                            }

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
                            Console.WriteLine($"Nombre: {l.Nombre}\nCedula: {l.Cedula}\nFecha de Nacimiento: {l.FechaNacimiento.ToString("dd, MMMM, yyyy", CultureInfo.CreateSpecificCulture("es-MX"))}\nEdad: {l.Edad} años\n");
                        }
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("!!! No hay datos para mostrar !!!");
                        }
                        Console.Write("\nPresione cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        foreach (var l in ordenadoPorTrue)
                        {
                            if (l.Validacion == true)
                            {
                                Console.WriteLine($"La cedula: {l.Cedula}, perteneciente a: {l.Nombre}  \t---->\tes válida\n");
                            }
                            else
                            {
                                Console.WriteLine($"\nLa cedula: {l.Cedula}, perteneciente a: {l.Nombre}  \t---->\tno es válida");
                            }
                        }
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("!!! No hay datos para mostrar !!!");
                        }
                        Console.Write("\nPresione cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.Clear();
                        int media = 0;
                        int moda = 0;
                        int mediana = 0;
                        foreach (var l in lista)
                        {
                            media += l.Edad;
                        }
                        media /= lista.Count;
                        Console.WriteLine($"La media es: {media} años\n");
                        int mediaVacia = 0;
                        foreach (var l in lista)
                        {
                            if (media == l.Edad)
                            {
                                Console.WriteLine($"Nombre: {l.Nombre}\nEdad: {l.Edad} años\n");
                                mediaVacia++;
                            }
                        }
                        if (mediaVacia == 0)
                        {
                            Console.WriteLine("!!! No hay edades iguales que la media !!!\n");
                        }

                        int repite = 0;
                        int repiteTemp1 = 0;
                        int repiteTemp2 = 0;
                        int modaTemp1 = 0;
                        for (int m = 0; m < lista.Count; m++)
                        {
                            repite = 0;
                            for (int n = 0; n < lista.Count; n++)
                            {
                                if (lista[m].Edad == lista[n].Edad)
                                {
                                    repite++;
                                }
                            }
                            if (repite > repiteTemp1)
                            {
                                moda = lista[m].Edad;
                                repiteTemp1 = repite;
                            }
                            if (repite == repiteTemp1 && moda != lista[m].Edad)
                            {
                                modaTemp1 = lista[m].Edad;
                                repiteTemp2 = repite;
                            }
                        }
                        int modaVacia = 0;
                        if (repiteTemp1 != repiteTemp2)
                        {
                            Console.WriteLine($"La moda es: {moda} años\n");
                            foreach (var l in lista)
                            {
                                if (moda == l.Edad)
                                {
                                    Console.WriteLine($"Nombre: {l.Nombre}\nEdad: {l.Edad} años\n");
                                    modaVacia++;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Las modas son: {moda} años y {modaTemp1} años\n");
                            foreach (var l in lista)
                            {
                                if (moda == l.Edad)
                                {
                                    Console.WriteLine($"Nombre: {l.Nombre}\nEdad: {l.Edad} años\n");
                                    modaVacia++;
                                }
                            }
                            foreach (var l in lista)
                            {
                                if (modaTemp1 == l.Edad)
                                {
                                    Console.WriteLine($"Nombre: {l.Nombre}\nEdad: {l.Edad} años\n");
                                    modaVacia++;
                                }
                            }
                        }
                        if (modaVacia == 0)
                        {
                            Console.WriteLine("!!! No hay edades iguales que la moda !!!\n");
                        }

                        List<DatosPersonales> listaTemp = new List<DatosPersonales>();
                        listaTemp = lista.OrderBy(l => l.Edad).ToList();
                        int indiceMediana = 0;
                        int indiceMedianaResiduo = listaTemp.Count() % 2;
                        if (indiceMedianaResiduo == 0)
                        {
                            indiceMediana = listaTemp.Count() / 2;
                            mediana = (listaTemp[indiceMediana - 1].Edad + listaTemp[indiceMediana].Edad) / 2;
                        }
                        else
                        {
                            indiceMediana = listaTemp.Count() / 2;
                            mediana = listaTemp[indiceMediana].Edad;
                        }
                        Console.WriteLine($"La mediana es: {mediana} años\n");
                        int medianaVacia = 0;
                        foreach (var l in lista)
                        {
                            if (mediana == l.Edad)
                            {
                                Console.WriteLine($"Nombre: {l.Nombre}\nEdad: {l.Edad} años\n");
                                medianaVacia++;
                            }
                        }
                        if (medianaVacia == 0)
                        {
                            Console.WriteLine("!!! No hay edades iguales que la mediana !!!\n");
                        }
                        Console.Write("\nPresione cualquier tecla para continuar!");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
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
                if (opcion == 6)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
