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

            Console.ReadKey();

            Console.ReadLine();
        }
    }
}
