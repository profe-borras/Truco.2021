using ManuelBelgrano.Truco.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManuelBelgrano.Truco.Enums;
namespace ManuelBelgrano.Truco.Entities
{
    public class CartaDeTruco : CartaBase 
    {
        private List<short> _numerosPermitidos = new List<short>() { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        public short Poder { get; set; }
        public string Apodo { get; set; }
        public CartaDeTruco(short numero, PaloEnum palo) : base(numero, palo)
        {
            if (_numerosPermitidos.Contains(Numero) == false) {
                throw new ArgumentException("El valor númerico ingresado no es válido");
            }
        }

        
        //public Carta(int palo, int numero)
        //{
        //    Numero = (short)numero;
        //    switch (palo)
        //    {
        //        case 1:
        //            Palo = PaloEnum.Espada;
        //            break;
        //        case 2:
        //            Palo = PaloEnum.Basto;
        //            break;
        //        case 3:
        //            Palo = PaloEnum.Oro;
        //            break;
        //        case 4:
        //            Palo = PaloEnum.Copa;
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
}
