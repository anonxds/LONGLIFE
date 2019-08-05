using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LONGLIFE.combatSYS
{
    class dialogos
    {
        public string combatdialog(int indice)
        {
            string[] sora = new string[]
            {
                "El enemigo se rasca su cabeza y luego ataca",
                "Veo que no puedo moverme",
                "Disparo una bala pero hize que lo danara",
                "El enemigo solo me mira con cara tonta"
            };
            return sora[indice];
        }
    }
}
