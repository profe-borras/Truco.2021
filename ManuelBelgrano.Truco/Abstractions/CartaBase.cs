using ManuelBelgrano.Truco.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuelBelgrano.Truco.Abstractions
{
    public class CartaBase
    {

        public CartaBase(short numero, PaloEnum palo)
        {
            if (numero < 1 || numero > 12)
            {
                throw new ArgumentException($"El valor ingresado {numero} no está permitido");
            }
            //El uso de la palabra "this" hace referencia a la clase
            //que estoy diseñando, muestra todos los métodos, atributos y propiedades
            //de la misma, el uso del mismo es en general, opcional.
            this.Numero = numero;
            Palo = palo;
        }
        public PaloEnum Palo { get; private set; }
        public short Numero { get; private set; }


        public void AsignarValores()
        {
        }

    }
}
