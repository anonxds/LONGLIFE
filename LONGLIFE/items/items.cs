using LCDLabel;
using LONGLIFE.SFX;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LONGLIFE.items
{
    class item
    {
        sql s = new sql();
        Sound sfx = new Sound();
        public void usaritem(string nombre,LcdLabel hp,ComboBox cbitem,Label dialog)
        {
            int heal;
            switch (nombre)
            {               
                case "Pomada":
                    
                    heal = 4;
                    hp.Text = (int.Parse(hp.Text) + heal).ToString();
                    dialog.Text = "Uso pomada";
                    if (int.Parse(hp.Text) >= int.Parse(s.getdata("select * from personaje", "HP")))
                    {
                        hp.Text = s.getdata("select * from personaje", "HP");
                    }
                    break;
                case "Ciabatta™ chica de jamon":
                    Stream stream = Properties.Resources.aet;
                    sfx.playsound(stream);
                    string ciabata = string.Format("update personaje set HP = (HP + '{0}'), ATK =(ATK + '{1}'), DEF = (DEF + '{2}')",4,1,0);
                    s.Exe(ciabata);
                    dialog.Text = "Consumo una Ciabatta; mis musculos empiezan a crecer, mi mentalidad aumenta y\n mis agallas incrementan exageradamente";
                    hp.Text = s.getdata("select * from personaje", "HP");
                    break;
                    
            }
            cbitem.Text = null;
            string remove = string.Format("delete from items where nombre = '{0}'", nombre);
            s.Exe(remove);
            s.populate(cbitem, "select * from items", "nombre");
        }
        public void recibiritem(string nombre,int cantidad,LcdLabel m4,LcdLabel shot,ComboBox cbitem)
        {
            switch (nombre)
            {
                case "Obtuve NATO":
                    m4.Text = (int.Parse(m4.Text) + cantidad).ToString();                
                    break;
                case "Obtuve Balas":                  
                    shot.Text = (int.Parse(shot.Text) + cantidad).ToString();
                    break;
                case "Obtuve Ciabatta™":
                    string ciabata = string.Format("insert into items (nombre,Type) values ('{0}','{1}')", "Ciabatta™ chica de jamon", 1);
                    s.Exe(ciabata);
                    break;
                case "Obtuve Granada":
                    string granada = string.Format("insert into items (nombre,Type) values ('{0}','{1}')", "Granada", 2);
                    s.Exe(granada);
                    break;
            }
            s.populate(cbitem, "select * from items where Type = 1", "nombre");
        }
    }
}
