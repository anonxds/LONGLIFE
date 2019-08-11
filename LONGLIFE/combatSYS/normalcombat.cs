using LCDLabel;
using LONGLIFE.items;
using LONGLIFE.NPC;
using LONGLIFE.NPC.MOBS;
using LONGLIFE.SFX;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LONGLIFE.combatSYS
{
    class normalcombat 
    {


        Sound sfx = new Sound();
        Random random = new Random();
        dialogos _dialogos = new dialogos();
        sql s = new sql();
        item _i = new item();
        int counter = 0;
        int len = 0;
        int damage;
        string text;        
        void readmessage(string mensage,TextBox sendmesasge,Timer timer1)
        {
            
            sendmesasge.Text = mensage;
            text += sendmesasge.Text+ "\r\n";       
            len = text.Length; 
            timer1.Start();        
        }
        public void ticktock(Timer timer1,TextBox sendmesasge)
        {
            counter++;
            if (counter > len)
            {
               timer1.Stop();
                counter = 0;               
            }
            else
            {
                sendmesasge.Text = text;
                sendmesasge.SelectionStart = sendmesasge.TextLength;
                sendmesasge.ScrollToCaret();
            }
           
        }
        public void seleccion(string cmd,string weapon,int myhp,int myatk,int mydef,int enemyhp,int enemydef,int enemyatk,Label displayenemyhp,LcdLabel displayMyhp,Panel dialog,Label _log,Panel cmdlist,string enemyname,Timer _start,TextBox mycommand,string _item,ComboBox cbitem)
        {
           
            dialog.Enabled = false;
            int randomNumber = random.Next(myatk, (myatk+1));
            switch (cmd)
            {
                case "ATK":
                    myATK(weapon,randomNumber,enemyhp,enemydef,displayenemyhp,_log,dialog,cmdlist,mycommand,_start,enemyname);
                    break;
                case "DEF":
                    _log.Text = "Me cubro con todo lo que puedo \n";
                    mydef = mydef + 2;
                    break;
                case "NADA":
                    _log.Text = "Me quedo parado en pleno combate \n";
                    break;
                case "USE":
                    items(_item, myatk, enemyatk, enemydef, displayenemyhp, _log, dialog, cmdlist, mycommand, _start,cbitem,displayMyhp);
                    break;
            }
            //parte donde ataca el enemigo
            int _enemyhp = int.Parse(displayenemyhp.Text);            
            if (_enemyhp > 0)
            {                
                Enemyturn(enemyatk, myhp,mydef, displayMyhp,_log,enemyname,mycommand,_start);
            }
            checkenemyhp(_enemyhp, _log, dialog, cmdlist,mycommand);
          
        }


        void items(string nombre, int myatk, int enemyhp, int enemydef, Label _enemyhp, Label _log, Panel dialog, Panel cmd, TextBox mycommand, Timer timer1,ComboBox cbitem,LcdLabel myhp)
        {
            switch (nombre)
            {
                case "Granada":
                    Stream stream = Properties.Resources.granada;
                    sfx.playsound(stream);
                    damage = 9 - enemydef;
                    _enemyhp.Text = (int.Parse(_enemyhp.Text) - 9).ToString();
                    readmessage(("Sora lanza una granada: " + damage + " de daño" + "\n"), mycommand, timer1);
                    break;
                case "Piedra":
                    Stream piedra = Properties.Resources.piedra;
                    sfx.playsound(piedra);
                    damage = 3 - enemydef;
                    _enemyhp.Text = (int.Parse(_enemyhp.Text) - 3).ToString();
                    readmessage(("Sora tira una piedra: " + damage + " de daño" + "\n"), mycommand, timer1);
                    break;                
            }
            _i.usaritem(cbitem.Text, myhp, cbitem, _log);
            string remove = string.Format("delete from items where nombre = '{0}'",nombre);
            s.Exe(remove);
            cbitem.Text = null;
            s.populate(cbitem, "select * from items", "nombre");
        }

        void myATK(string weapon,int myatk,int enemyhp,int enemydef, Label _enemyhp,Label _log,Panel dialog,Panel cmd,TextBox mycommand,Timer timer1,string enemyname)
        {
            if (myatk <= enemydef)
            {
                readmessage(("Sora ataca: " + 0 + " de daño. Parece ser inpenetrable" + " \n"), mycommand, timer1);
            }
            else
            {
               
             //   damage = myatk - enemydef;
                _enemyhp.Text = (int.Parse(_enemyhp.Text) - weakness(enemyname, myatk,weapon)).ToString();
                readmessage(("\n"+"Sora ataca: " + weakness(enemyname, myatk,weapon) + " de daño" + "\n"), mycommand,timer1);
            }
        }
       void checkenemyhp(int enemyhp, Label _log, Panel dialog, Panel cmd,TextBox battlelog)
        {           
            if (enemyhp <= 0)
            {              
                _log.Text += "Fui exitoso en mi pelea";
                dialog.Enabled = true;
                cmd.Visible = false;
            }
        }
        void Enemyturn(int enemyatk,int myhp,int mydef,LcdLabel _HP,Label _log,string enemyname,TextBox enemyconmand,Timer timer1)
        { 
            
            int quedecir = random.Next(0, 2);
            damage = Seleccionar(enemyname,quedecir).Item2 - mydef;     
            _HP.Text = (int.Parse(_HP.Text) - damage).ToString();
            readmessage("\n " + Seleccionar(enemyname, quedecir).Item1.ToString() + " " + damage + " de daño"+"\n", enemyconmand, timer1);
            if (myhp <= 0)
            {         
                _log.Text += "El ataque me saco volando";
            }
        }

       Tuple<string,int> Seleccionar(string nombre,int numero)
        {
            stats _stat = null;
            switch (nombre)
            {
                case "Soldado NormalS":
                    _stat = new soldado();
                    break;
                case "gato":
                    _stat = new gatoputrefacto();
                    break;
                case "joven":
                    _stat = new rebellista();
                    break;
                case "nino":
                    _stat = new ninos();
                    break;
                case "Ratas":
                    _stat = new ratas();
                    break;
                case "Papelon":
                    _stat = new Papelon();
                    break;
            }
            return Tuple.Create(_stat.Nameatk(numero).Item1,_stat.Nameatk(numero).Item2);
        }

        public int weakness(string nombre,int dmg,string weapon)
        {
            stats _stat = null;
            switch (nombre)
            {
                case "Soldado NormalS":
                    _stat = new soldado();
                    break;
                case "gato":
                    _stat = new gatoputrefacto();
                    break;
                case "joven":
                    _stat = new rebellista();
                    break;
                case "nino":
                    _stat = new ninos();
                    break;
                case "Ratas":
                    _stat = new ratas();
                    break;
                case "Papelon":
                    _stat = new Papelon();
                    break;
            }
            return _stat.weakness(weapon, dmg);
        }
    }
}
