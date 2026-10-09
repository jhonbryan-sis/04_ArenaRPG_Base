using ArenaRPG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ArenaRPG_Base
{
    public class Supay : SerMitologico, IMagico
    { public int Mana { get; set; }
        public Supay()
        {
            Nombre = (("supay(El tio"));
            Vida = 300;
            Mana = 100;

        }
        public override void Atacar()
        {
            Console.WriteLine("Supay ataca con su tridente");

        }

        public void LanzarHechizo()
        { Console.WriteLine("Supay invoca fuego del inframundo");
            Mana -= 20;

        }
    } 
}

