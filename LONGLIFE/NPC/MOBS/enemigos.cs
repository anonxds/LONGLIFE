using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LONGLIFE.NPC.MOBS
{
 public class soldado : stats
    {
        enum stats {HP = 40
                ,DEF = 2
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
        int damage;
        public override int weakness(string nombre,int dmg)
        {
            
            switch (nombre)
            {
                case "M4":
                   damage =  dmg * 3 - (int)stats.DEF;
                    break;
                case "Dagga":
                    damage =  (dmg * 2) - (int)stats.DEF;
                    break;
                case "Escopeta":
                    damage =   dmg * 4 - (int)stats.DEF;
                    break;
            }
            return damage;
        }
    }
    class ratas : stats
    {
        enum stats
        {
            HP = 20
               , DEF = 0
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
                    atk = (int)stats.ATK * 1;
                    break;
                case 1:
                    nombre = "Varias ratas tratan de treparse a mi cuerpo";
                    atk = (int)stats.ATK * 2;
                    break;
            }

            return Tuple.Create(nombre, atk);
        }
        int damage;
        public override int weakness(string nombre, int dmg)
        {
            switch (nombre)
            {
                case "M4":
                    damage = dmg * 2 - (int)stats.DEF;
                    break;
                case "Dagga":
                    damage = (dmg * 3) - (int)stats.DEF;
                    break;
                case "Escopeta":
                    damage = dmg * 4 - (int)stats.DEF;
                    break;
            }
            return damage;
        }
    }
    public class Papelon : stats
    {
        enum stats
        {
            HP = 10,
            ATK = 2,
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
            return (int)stats.HP;
        }

        public override Tuple<string, int> Nameatk(int number)
        {
            int atk = (int)stats.ATK;
            string nombre = null;
            switch (number)
            {
                case 0:
                    nombre = "Dispara pelo de agujas";
                    atk = (int)stats.ATK * 2;
                    break;
                case 1:
                    nombre = "Escupe un nuez a una velocidad sorprendente";
                    atk = (int)stats.ATK * 3;
                    break;
            }

            return Tuple.Create(nombre, atk);
        }

        public override string nombre()
        {
            return "Papelon";
        }

        public override int weakness(string nombre, int dmg)
        {
            throw new NotImplementedException();
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

        public override int weakness(string nombre, int dmg)
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

        public override int weakness(string nombre, int dmg)
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

        public override int weakness(string nombre, int dmg)
        {
            throw new NotImplementedException();
        }
    }
}
