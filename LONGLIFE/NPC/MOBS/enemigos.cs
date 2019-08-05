using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LONGLIFE.NPC.MOBS
{
 public class soldado : stats
    {
        enum stats {HP = 4
                ,DEF = 1
                ,ATK = 1
        };
       
        public override int hp()
        {
            return (int)stats.HP;
        }

        public override int def()
        {
            return (int)stats.DEF;
        }

        public override int atk()
        {
            return (int)stats.ATK;
        }

        public override string nombre()
        {
            return "Soldado NormalS";
        }

        
      
        public override Tuple<string, int> Nameatk(int number)
        {
            int atk = (int)stats.ATK;
            string nombre = null;
            switch (number)
            {
                case 0:
                    nombre = "Ataca con dagga";
                    atk = (int)stats.ATK * 1;
                    break;
                case 1:
                    nombre = "Dispara varias veces";
                    atk = (int)stats.ATK * 2;
                    break;               
            }

            return Tuple.Create(nombre, atk);
        }
    }
    class ratas : stats
    {
        enum stats
        {
            HP = 30
               , DEF = 1
               , ATK = 2
        };

        public override int atk()
        {
            return (int)stats.ATK;
        }

        public override int def()
        {
            return (int)stats.DEF;
        }

        public override int hp()
        {
            return (int)stats.HP;
        }

        public override string nombre()
        {
            return "Ratas";
        }

        public override Tuple<string, int> Nameatk(int number)
        {
            int atk = (int)stats.ATK;
            string nombre = null;
            switch (number)
            {
                case 0:
                    nombre = "Trata de morderne";
                    atk = (int)stats.ATK * 2;
                    break;
                case 1:
                    nombre = "Varias ratas tratan de treparse a mi cuerpo";
                    atk = (int)stats.ATK * 4;
                    break;
            }

            return Tuple.Create(nombre, atk);
        }
    }

    public class gatoputrefacto : stats
    {
        enum stats
        {
            HP = 20,
            ATK = 4,
            DEF = 0,
        }
        public override int atk()
        {
            return (int)stats.ATK;
        }

        public override int def()
        {
            return (int)stats.DEF;
        }

        public override int hp()
        {
            return (int)stats.HP;        }

        public override string nombre()
        {
            return "Gato putrefacto";
                }

        public override Tuple<string, int> Nameatk(int number)
        {
            throw new NotImplementedException();
        }
    }
    public class rebellista : stats
    {
        enum stats
        {
            hp = 10,
            def = 2,
            atk=1
        }
        public override int atk()
        {
            return (int)stats.atk;
        }

        public override int def()
        {
            return (int)stats.def;
        }

        public override int hp()
        {
            return (int)stats.hp;
        }

        public override string nombre()
        {
            return "Joven comunista";
        }

        public override Tuple<string, int> Nameatk(int number)
        {
            throw new NotImplementedException();
        }
    }
    public class ninos : stats
    {
        enum stats
        {
            hp =1,
            atk = 10,
            def=0
        }
        public override int atk()
        {
            return (int)stats.atk;
        }

        public override int def()
        {
            return (int)stats.def;
        }

        public override int hp()
        {
            return (int)stats.hp;
        }

        public override string nombre()
        {
            return "Nino abandonado";
        }

        public override Tuple<string, int> Nameatk(int number)
        {
            throw new NotImplementedException();
        }
    }
}
