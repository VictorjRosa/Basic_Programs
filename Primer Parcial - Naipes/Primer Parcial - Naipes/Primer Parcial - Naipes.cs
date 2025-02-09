using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial___Naipes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carta[] cartas = new Carta[52];
            for (int i = 0; i < cartas.Length; i++)
            {
                if (i < 13)
                {
                    cartas[i] = new Carta("Corazones", Convert.ToString(i + 1));
                }
                else
                {
                    if (i < 26)
                    {
                        cartas[i] = new Carta("Diamantes", Convert.ToString(i + 1 - 13));
                    }
                    else
                    {
                        if (i < 39)
                        {
                            cartas[i] = new Carta("Treboles", Convert.ToString(i + 1 - 26));
                        }
                        else
                        {
                            cartas[i] = new Carta("Picas", Convert.ToString(i + 1 - 39));
                        }
                    }
                }
            }
            Console.Write("Digite cantidad de cartas que desea: ");
            int cantidadCartas = Convert.ToInt16(Console.ReadLine());
            if (cantidadCartas > 52)
            {
                Console.WriteLine("No hay más de 52 cartas!!!");
            }
            Carta[] cartasElegidas = new Carta[cantidadCartas];
            for (int i = 0; i < cantidadCartas; i++)
            {
                cartasElegidas[i] = new Carta("0", "0");
            }
            Random rand = new Random();
            int random = rand.Next(0, 51);
            
            cartasElegidas[0] = cartas[random];
            for (int i = 0; i < cantidadCartas; i++)
            {
                int todosRandom = rand.Next(0, 51);
                for (int j = 0; j < cantidadCartas; j++)
                {
                    if (cartasElegidas[i].NumeroCarta != cartasElegidas[j].NumeroCarta && cartasElegidas[i].TipoCarta != cartasElegidas[j].TipoCarta)
                    {
                        if (i < cantidadCartas - 1)
                        {
                            cartasElegidas[i + 1] = cartas[todosRandom];
                        }
                        else
                        {
                            cartasElegidas[i] = cartas[todosRandom];
                        }
                    }
                }
            }
            Carta temp;
            for (int i = 0; i < cantidadCartas; i++)
            {
                for (int j = 0; j < cantidadCartas; j++)
                {
                    if (Convert.ToInt16(cartasElegidas[j].NumeroCarta) < Convert.ToInt16(cartasElegidas[i].NumeroCarta))
                    {
                        temp = cartasElegidas[j];
                        cartasElegidas[j] = cartasElegidas[i];
                        cartasElegidas[i] = temp;
                    }
                }
            }
            for (int i = 0; i < cartas.Length; i++)
            {
                if (i + 1 == 1)
                {
                    cartas[i].NumeroCarta = "A";
                }
                else
                {
                    if (i + 1 == 11)
                    {
                        cartas[i].NumeroCarta = "J";
                    }
                    else
                    {
                        if (i + 1 == 12)
                        {
                            cartas[i].NumeroCarta = "Q";
                        }
                        else
                        {
                            if (i + 1 == 13)
                            {
                                cartas[i].NumeroCarta = "K";
                            }
                        }
                    }
                }
            }
            int menos = 0;
            Console.WriteLine("Cartas ordenadas de forma descendente!\n");
            while (menos != cantidadCartas)
            {
                Console.WriteLine($"Carta #{menos + 1}: {cartasElegidas[menos].NumeroCarta} de {cartasElegidas[menos].TipoCarta}\n");
                menos++;
            }
            Console.ReadKey();
        }
    }
}
