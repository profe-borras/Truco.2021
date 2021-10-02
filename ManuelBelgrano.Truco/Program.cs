using ManuelBelgrano.Truco.Entities;
using ManuelBelgrano.Truco.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Truco
{
    class Program
    {

        static void Main(string[] args)
        {
            var rndm = new Random();

            var contador = 0;
            var listadoDeIndicesDelMazo = new List<int>();
            do
            {
                contador++;
                //Entrada
                var idx = rndm.Next(0, 100);
                //proceso
                if (listadoDeIndicesDelMazo.Contains(idx) == true) continue;
                listadoDeIndicesDelMazo.Add(idx);

            } while (listadoDeIndicesDelMazo.Count < 100); //salida


             

            int[] numeros = new int[] { 3, 0, 77, 9 };
            //intercambiar el elemento de la posición 2 con el elmento de la posición 0
            //int num = numeros[2];
            //numeros[2] = numeros[0];
            //numeros[0] = num; //By Juampi

            //algoritmo de Fisher-Yates
            Random rnd = new Random();
            for (int i = numeros.Length - 1; i > 0; i--) {
                int idr = rnd.Next(0, i);
                int aux = numeros[idr];
                numeros[idr] = numeros[i];
                numeros[i] = aux;
            }




            List<CartaDeTruco> mazo = new List<CartaDeTruco>();
            //Armar el mazo
            for (int palo = 1; palo <= 4; palo++)
            {
                //conversión de tipo ()
                PaloEnum paloEnum = (PaloEnum)palo;
                for (short numero = 1; numero <= 12; numero++)
                {
                    if (numero == 8 || numero == 9) continue;//la plarab                    
                    var carta = new CartaDeTruco(numero, paloEnum);
                    mazo.Add(carta);
                }
            }

            /*
             int i = numeros.Lenght
while (i > 1) {
 
        int j = rng.Next(i);  
        int swap = numeros[j];  
        numeros[j] = numeros[i];  
        numeros[i] = swap;
        i--;

             
             */

            Console.ReadKey();

            //var rndm = new Random();

            //var listadoDeIndicesDelMazo = new List<int>();

            ////Objetivo: obtener 6 números distintos del 0 al 39 ionclusive

            //do
            //{
            //    //Entrada
            //    var idx = rndm.Next(0, 40);
            //    //proceso
            //    if (listadoDeIndicesDelMazo.Contains(idx) == true) continue;
            //    listadoDeIndicesDelMazo.Add(idx);

            //} while (listadoDeIndicesDelMazo.Count < 6); //salida



            //var cartasJugador1 = new List<CartaDeTruco>();
            //for (var i = 0; i < 3; i++)
            //{

            //    var indiceDelMazo = listadoDeIndicesDelMazo[i];
            //    var carta = mazo[indiceDelMazo];
            //    cartasJugador1.Add(carta);
            //}

            //var cartasJugador2 = new List<CartaDeTruco>();
            //for (var i = 3; i < 6; i++)
            //{
            //    var indiceDelMazo = listadoDeIndicesDelMazo[i];
            //    var carta = mazo[indiceDelMazo];
            //    cartasJugador2.Add(carta);
            //}

            //Console.WriteLine("Cartas del jugador 1");
            //foreach (var item in cartasJugador1.OrderByDescending(c=>c.Numero))
            //{
            //    Console.WriteLine($"{item.Numero} de {item.Palo}");
            //}

            //Console.WriteLine("Cartas del jugador 2");
            //foreach (var item in cartasJugador2.OrderBy(c => c.Numero))
            //{
            //    Console.WriteLine($"{item.Numero} de {item.Palo}");
            //}

            /*
              var numerosGenerados = new List<int>();
            var rnd = new Random();
            while (numerosGenerados.Count <= 30)
            {
                var valorRandom = rnd.Next(0, 30);
                if (numerosGenerados.Contains(valorRandom)) continue;

                numerosGenerados.Add(valorRandom);
                Console.WriteLine(valorRandom);
            }

            Console.ReadLine();
            */



            Console.ReadLine();
        }
    }
}
