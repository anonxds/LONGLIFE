using LONGLIFE.Botones;
using LONGLIFE.combatSYS;
using LONGLIFE.dialogos;
using LONGLIFE.items;
using LONGLIFE.NPC;
using LONGLIFE.NPC.MOBS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using LONGLIFE.SFX;
using System.Reflection;

namespace LONGLIFE
{
    public partial class Form1 : Form
    {
        opciones _text = new Botones.opciones();
        listadialogos dialogo = new listadialogos();
        sql s = new sql();
        Random random = new Random();
        item _i = new item();
        Sound sfx = new Sound();
        dialogoplus Dplus = new dialogoplus();
        public static string _logs;
        //
        int i = 0;
        int counter = 0;
        int len = 0;
        int myhp;
        int myatk;
        int mydef;
        int enemyhp;
        int enemyatk;
        int enemydef;
        string text;
        string _ruta;
        string weapon;
        //
        List<string> despertar = new List<string>{
    "Un disparo fuerte retumba mis oídos. Creo que la bala pego la pared metálica.",
    "“¡Sora!”",
    "“Uhhhhhhhhhhhh”",
    "“¡Sora por favor despierta¡”",
    "“¿Que sucede?”",
    "“Nos están atacando, el escuadrón se encuentra afuera. Solo soy yo.”",
    "Mi mente apenas está recuperando conciencia; dos balas atraviesa los lados de mi cuello.\n Agarro mi rifle.",
    "Eran dos atacantes; no se les podía ver el rostro. Lo pobres esclavos no saben que hacen con su vida."
};
        string mystast = "select * from personaje";
  public static List<string> _log = new List<string>();
        public Form1()
        {
            InitializeComponent();
            dialogbox.BackColor = Color.FromArgb(125, Color.Black);
           lblhp.Text =  s.getdata(mystast, "HP");
            lblmaxhp.Text = "/"+s.getdata(mystast, "HP");
            s.populate(cbitem, "select * from items where Type = 1", "nombre");
            lblammo.Text = s.getdata(mystast, "m4Ammo");
            lblescopeta.Text = s.getdata(mystast, "Shotgunshells");
            lblTiempo.Text = "9:00 A.M";
            lblubicacion.Text = "Dentro del Refugio";
            lblNhp.Text = "HP";
        }
        void endcombat()
        {
            cmdpanel.Visible = false;
            dialogbox.Enabled = true;
        }
        //eventos especiales
        void eventos()
        {
            if(int.Parse(lblhp.Text) == 7 && lblnombreenemigo.Text == "Soldado NormalS")
            {
                agregartext(dialogo.avisoG());
                dialogbox.Enabled = true;
                cmdpanel.Enabled = false;
                lbldialog.Text = "Maldicion creo que este es el final...";
            }
            if(int.Parse(lblenemyhp.Text) <= 0 && lblnombreenemigo.Text == "Soldado NormalS")
            {
                agregartextE(dialogo.primercombate());
            }

            if (int.Parse(lblhp.Text) <= 0)
            {
                dialogbox.Enabled = true;
                cmdpanel.Visible = false;
                agregartext(dialogo.fin());
            }
        }
            //
            
        private void dialogbox_MouseClick(object sender, MouseEventArgs e)
        {
           
            string frase = lbldialog.Text;
            string[] item = frase.Split(' ');
            if (item[0] == "Obtuve")
            {
                _i.recibiritem(item[0] + " " + item[1], int.Parse(item[item.Length - 1]), lblammo, lblescopeta,cbitem);
            }
            if(lbldialog.Text == "¡Ack! una bala raspa un lado de mi hombro." || lbldialog.Text == "Uso mi hombro..." || lbldialog.Text == "Me hecho por atrás y pateo con fuerzas la puerta. La fuerza era muy intensa que la rompí pero\n me caí... y me lastime mis rodillas.")
            {
                lblhp.Text = (int.Parse(lblhp.Text) - 2).ToString();
            }
            if(lbldialog.Text == "Veo va a amanecer apenas. Miro como el cielo empieza a brillar poco; con la\n nublazón de color café claro, se ve que será un día normal.")
            {
                lblubicacion.Text = "Afuera del refugio";
                lblTiempo.Text = "11:00 A.M";
            }
            if(lbldialog.Text == "Papelon se acerca")
            {
                cbitem.Text = null;
                s.populate(cbitem, "select * from items", "nombre");
                enemystast("Papelon");
                cmdpanel.Visible = true;

            }

            if (i >= despertar.Count)
            {
              string texto = despertar[i-1];
                switch (texto)
                {
                
                    case "...Y ahora ¿que?":
                        panel2.Show();
                        opciones("Ir a la cama", "Caminar por el area", "Salir");
                        break;
                    case "¿Cómo lo motivo?":
                        panel2.Show();
                        opciones("Le doy el pulgar", "Mirarlo profundamente", "Agresivo");
                        break;
                    case "Eran dos atacantes; no se les podía ver el rostro. Lo pobres esclavos no saben que hacen con su vida.":
                        panel2.Show();
                        opciones(_text.llamar(),_text.cubrir(),_text.hacer());
                        break;
                    case "Soldado desconocido se acerca.":
                        cbitem.Text = null;
                        s.populate(cbitem, "select * from items", "nombre");
                        enemystast("soldado");
                        cmdpanel.Visible = true;                       
                        break;
                    case "Ratas enormes se acecan":
                        cbitem.Text = null;
                        s.populate(cbitem, "select * from items", "nombre");
                        enemystast("Ratas");
                        cmdpanel.Visible = true;
                        break;
                  
                    case "Creo que me acuerdo de algo...":
                        panel2.Show();
                        opciones(_text.aventargranada(), _text.noaventar(), _text.pensando());
                        break;
                    case "Pepes agarran una de sus granadas y los avienta hacia ellos. Los dos intrusos se dan cuenta \ny salen del lugar.":
                        agregartextE(dialogo.granda());
                        break;
                    case "Hay que estar en cubierta. Puede que ellos entren de nuevo... ¿Qué hare?":
                        panel2.Show();
                        opciones(_text.esperar(), _text.salir(), _text.bien());
                        break;
                    case "Mientras que espero a Pepes ¿Qué hare?...":
                        lblubicacion.Text = "Afuera del refugio";
                        panel2.Show();
                        opciones(_text.nada(), _text.analizar(), _text.Pensar());
                        break;
                    case "Entonces mi decisión es...":
                        panel2.Show();
                        opcionfinal(_text.continuar(), _text.buscar());
                        break;
                    case "¿Debería entrar?":
                        panel2.Show();
                        opciones("Disparar", "Patear", "Regresar");
                        break;
                    case "¿A dónde iré?":
                        panel2.Show();
                        opciones("Ir al cuarto de los padres", "Ver la sala", "Ir cuarto del hijo");
                        break;
                    case "¿Las abro?":
                        panel2.Show();
                        opcionfinal("Si", "No");
                        break;
                    case "Me paro y ¿ahora dónde?":
                        panel2.Show();
                        opcionfinal("Ir al cuarto de los padres", "Ir cuarto del hijo");
                        break;
                    case "¿Cómo la abro?":
                        panel2.Show();
                        opciones("Salir de la casa","Usar rifle","Usar fuerza bruta");
                        break;
                    case "Saco mi rifle y disparo en la manecilla... No hubo efecto":
                        
                        panel2.Show();
                        opcionfinal("Continuar disparando", "Usar escopeta");
                        break;
                    case "¿Lo muevo?":
                        panel2.Show();
                        opcionfinal("Moverlo", "Dejarlo");
                        break;
                    case "Ahhhhhhhhhhhh dolió más de lo que pensé que dolería.":
                        panel2.Show();
                        opcionfinal("Usar rifle", "Usar escopeta");
                        break;
                    case "¿Qué usare?":
                        panel2.Show();
                        opcionfinal("Usar granada","Disparar con escopeta");
                        break;
                    case "¿Disparo de nuevo?":
                        panel2.Show();
                        opcionfinal("Usar granada", "Disparar con escopeta");
                        break;
                    case "¿Debería parar?":
                        panel2.Show();
                        opcionfinal("Continuar viendo", "Parar");
                        break;
                    case "¿Debería detenerme?":
                        panel2.Show();
                        opcionfinal("Continuar", "Parar");

                        break;

                }             
            }

            else
            {
                       
                lbldialog.Text = despertar[i].ToString();
                i++;
                text = lbldialog.Text;
                len = text.Length;
                timer1.Start();
                _log.Add(lbldialog.Text + "\n");
             
            }
       
            //fin del juego

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            counter++;
            if (counter > len)
            {
                timer1.Stop();
                counter = 0;      
            }
            else
            {               
                lbldialog.Text = text.Substring(0, counter);              
            }
        }
        private void btnatk_Click(object sender, EventArgs e)
        {
            wastem4ammo();
        }
        void wastem4ammo()
        {
            int m4ammo = int.Parse(lblammo.Text);
            if (m4ammo <= 0)
            {
                lbldialog.Text = "No tengo municion";
            }
            else
            {
                Stream ak47 = Properties.Resources.ak47;
                sfx.playsound(ak47);
                int randomNumber = random.Next(5, 9);
                lblammo.Text = (m4ammo - randomNumber).ToString();
                if (int.Parse(lblammo.Text) < randomNumber)
                {
                    lblammo.Text = "0";
                }
                switch (cmdpanel.Visible)
                {
                    case true:
                        lblweapon.Text = "M4";
                        myatk = int.Parse(s.getdata(mystast, "ATK"));
                        comamando("ATK", (myatk + 1), null);
                        break;
                }
            }           
        }
        void wasteshotgunammo()
        {
            int escopeta = int.Parse(lblescopeta.Text);
            if (escopeta <= 0)
            {
                lbldialog.Text = "No tengo municion";
            }
          
            else
            {
                Stream stream = Properties.Resources.escopeta;
                sfx.playsound(stream);
                lblescopeta.Text = (escopeta - 1).ToString();
                switch (cmdpanel.Visible)
                {
                    case true:
                        lblweapon.Text = "Escopeta";
                        myatk = int.Parse(s.getdata(mystast, "ATK"));
                        comamando("ATK", (myatk + 4), null);
                        break;
                }
            }

        }
        private void btnescopeta_Click(object sender, EventArgs e)
        {
            wasteshotgunammo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {         
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            _logs = string.Join(",",_log);
            log l = new log();
            l.Show();

        }
        public void opciones(string op1,string op2,string op3)
        {
            btnop2.Visible = true;
            btnop1.Text = op1;
            btnop2.Text = op2;
            btnop3.Text = op3;
          

        }
        void opcionfinal(string op1,string op2)
        {
            btnop1.Text = op1;
            btnop2.Visible = false;
            btnop3.Text = op2;
            
        }
        private void btnop1_Click(object sender, EventArgs e)
        {
            _ruta = btnop1.Text;
            switch (_ruta)
            {
                case "Ir a la cama":
                    agregartext(Dplus.Cama());
                    agregartext(dialogo.salir());
                    break;
                case "Le doy el pulgar":
                    agregartext(dialogo.pulgar());
                    agregartext(dialogo.adentrodelrefugio());
                    break;
                case "Continuar":
                    agregartext(dialogo.dibujocont2());
                    break;
                case "Continuar viendo":
                    agregartext(dialogo.dibujocont());
                    break;
                case "Usar granada":
                    lbldialog.Text = "Aviento una granada y cierro el cuarto\n una explosion fuerte hizo retumbar la casa";
                    agregartextE(dialogo.cajafuerte());
                    agregartext(dialogo.llegaEs());
                    break;

                case "Usar rifle":
                    if (int.Parse(lblammo.Text) == 0)
                    {
                        lbldialog.Text = "No tengo municion";
                    }
                    else
                    {
                        wastem4ammo();
                        agregartext(dialogo.disparar2());
                      
                    }
                    break;
                case "Ir al cuarto de los padres":
                    agregartext(dialogo.padres());
                    break;
                case "Llamar al escuadrón":                
                    agregartext(dialogo.llamar());
                    break;
                case "— !Avienta la granada!":
                    dialogbox.Enabled = true;
                    cmdpanel.Visible = false;
                    agregartext(dialogo.tirargranda());
                    endcombat();
                    break;
                case "Esperar adentro":
                    agregartext(dialogo.esperar());
                    break;
                case "Nada":
                    agregartext(dialogo.llegaEs());
                    break;
                case "Disparar":
                    if (int.Parse(lblammo.Text) == 0)
                    {
                        lbldialog.Text = "No tengo municion";
                    }
                    else
                    {
                        wastem4ammo();
                        agregartext(dialogo.disparar());
                        agregartext(dialogo.entrar());
                    }
                    //gastar bala
                    break;
                case "Si":
                    agregartext(dialogo.cajones());
                    break;
                case "Dejarlo ir":

                    break;
                case "Continuar disparando":
                    if (int.Parse(lblammo.Text) == 0)
                    {
                        lbldialog.Text = "No tengo municion";
                    }
                    else
                    {
                        wastem4ammo();
                        agregartext(dialogo.continuar());
                        agregartext(dialogo.recamara1());
                    }
                        break;
                case "Moverlo":
                    agregartext(dialogo.ratas());
                    break;
                case "Salir de la casa":
                    lbldialog.Text = "Ehhhhhh esta casa me da escalofrios. Ya no me voy arriesgar \n salgo de la casa y espero al escuadron";
                    agregartextE(dialogo.llegaEs());
                    break;
            }            
        }
        

        private void btnop2_Click(object sender, EventArgs e)
        {
            _ruta = btnop2.Text;

            switch (_ruta)
            {
                case "Caminar por el area":
                    agregartext(Dplus.A_Alrededor());
                    break;
                case "Mirarlo profundamente":
                    agregartext(dialogo.Mirar());
                    agregartext(dialogo.adentrodelrefugio());
                    break;
                case "Cubrirme":
                    agregartext(dialogo.cubrir());
                    break;
                case "Es mejor no arriesgarse":
                    lbldialog.Text = "Ugh una bala raspa mi rodilla.";
                    dialogbox.Enabled = false;
                    cmdpanel.Enabled = true;
                    panel2.Hide();
                    lblhp.Text = (int.Parse(lblhp.Text) - 1).ToString();
                    break;
                case "Salir":
                    lblubicacion.Text = "Afuera del refugio";
                    lblTiempo.Text = "11:00 A.M";
                    agregartext(dialogo.salir());
                    break;
                case "Investigar el area":
                    agregartext(dialogo.analizar());
                    break;
                case "Patear":
                    lbldialog.Text = "Me hecho por atrás y pateo con fuerzas la puerta. La fuerza era muy intensa que la rompí pero\n me caí... y me lastime mis rodillas.";
                    agregartextE(dialogo.entrar());
                    break;
                case "Usar rifle":
                    if (int.Parse(lblammo.Text) == 0)
                    {
                        lbldialog.Text = "No tengo municion";
                    }
                    else
                    {
                        wastem4ammo();
                        agregartext(dialogo.disparar2());
                    }
                    break;
                case "Ver la sala":
                    agregartext(dialogo.sala());
                    break;

            }
           
        }
        public void agregartext(string[] op2)
        {
            lbldialog.Text = "";
            panel2.Hide();
            despertar.AddRange(op2);
        }
        public void agregartextE(string[] op2)
        {            
            panel2.Hide();
            despertar.AddRange(op2);
        }
        normalcombat combat = new normalcombat();
     
        private void btnop3_Click(object sender, EventArgs e)
        {
            _ruta = btnop3.Text;
            switch (_ruta)
            {
                case "Agresivo":
                    agregartext(dialogo.agresividad());
                    agregartext(dialogo.adentrodelrefugio());
                    break;
                case "Parar":
                    agregartext(dialogo.rumba());
                    break;
                case "Dejarlo":
                    agregartext(dialogo.inspeccionPadres());
                    break;
                case "Ir cuarto del hijo":
                    agregartext(dialogo.cuartohijo());
                    break;
                case "¿...Que estamos haciendo?":
    
                    agregartext(dialogo.hacer());
                    break;
                case "...":
                    lbldialog.Text = "Ugh! una bala raspa mi cara";
                    dialogbox.Enabled = false;
                    cmdpanel.Enabled = true;
                    panel2.Hide();
                    lblhp.Text = (int.Parse(lblhp.Text) - 2).ToString();
                    break;
                case "Pararse":
                    agregartext(Dplus.levantarse());
                    break;
                case "Pensar":

                    break;
              
                case "No":
                    panel2.Show();
                    lbldialog.Text = "Dejo la sala ¿Donde ire?";
                    opcionfinal("Ir al cuarto de los padres", "Ir cuarto del hijo");                 
                    break;
                case "Usar fuerza bruta":
                    lbldialog.Text = "Uso mi hombro...";
                    agregartextE(dialogo.hombro());
                    break;
                case "Usar escopeta":
                    if (int.Parse(lblescopeta.Text) == 0)
                    {
                        lbldialog.Text = "No tengo municion";
                    }
                    else
                    {
                        wasteshotgunammo();
                        agregartext(dialogo.escopeta());
                        agregartext(dialogo.recamara1());
                    }
                    break;
                case "Regresar":
                    lbldialog.Text = "Es mejor no perder tiempo. Regreso y espero al escuadron";
                    agregartext(dialogo.llegaEs());
                    break;
                case "Disparar con escopeta":
                    if (int.Parse(lblescopeta.Text) == 0)
                    {
                        lbldialog.Text = "No tengo municion";
                    }
                    else
                    {
                        lbldialog.Text = "Saco mi escopeta y disparo";
                        int randomNumber = random.Next(0, 100);
                        if (randomNumber < 30)
                        {
                            wasteshotgunammo();
                            agregartextE(dialogo.cajafuerte());
                            agregartextE(dialogo.llegaEs());

                        }
                        else
                        {
                            wasteshotgunammo();
                            agregartextE(dialogo.escopeta2());
                        }
                    }
                    break;
            }
         
        }

        private void btnatk_MouseHover(object sender, EventArgs e){toolTip1.SetToolTip(btnatk, "Usar rifle");}
        private void btndef_MouseHover(object sender, EventArgs e){toolTip1.SetToolTip(btndef, "Defender");}
        private void btnnothing_MouseHover(object sender, EventArgs e){}
        private void btnuse_MouseHover(object sender, EventArgs e){toolTip1.SetToolTip(btnuse, "Usar item");}

        public void enemystast(string mob)
        {
            stats _stat = null;
            switch (mob)
            {
                case "soldado":
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
            lblenemyhp.Text = _stat.hp().ToString();
            lblenemyatk.Text = _stat.atk().ToString();
            lblenemydef.Text = _stat.def().ToString();
            lblnombreenemigo.Text = _stat.nombre();

        }
      
        void comamando(string cmd, int myatk,string item)
        {          
            lbldialog.Text = "";
            myhp = int.Parse(lblhp.Text);
            mydef = int.Parse(s.getdata(mystast, "DEF"));
            enemyhp = int.Parse(lblenemyhp.Text);
            enemydef = int.Parse(lblenemydef.Text);
            enemyatk = int.Parse(lblenemyatk.Text);
            string enemyname = lblnombreenemigo.Text;
            weapon = lblweapon.Text;
            combat.seleccion(cmd,weapon, myhp, myatk, mydef, enemyhp, enemydef, enemyatk, lblenemyhp, lblhp, dialogbox, lbldialog, cmdpanel,enemyname,dialogtimer,battlelogtxt,item,cbitem);
            eventos();
        }

        private void btndef_Click(object sender, EventArgs e)
        {
            comamando("DEF",0,null);
        }

        private void btnnothing_Click(object sender, EventArgs e)
        {
            comamando("NADA",0,null);
        }

        private void cbitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnuse.Enabled = true;
        }

        private void btnsalir_MouseHover(object sender, EventArgs e){}
        private void btnescopeta_MouseLeave(object sender, EventArgs e){}
        private void btnescopeta_MouseHover(object sender, EventArgs e)

        {
            toolTip1.SetToolTip(btnescopeta, "Escopeta");

        }
        private void btndagger_Click(object sender, EventArgs e)
        {
            lblweapon.Text = "Dagga";
            Stream dagger = Properties.Resources.atk;
            sfx.playsound(dagger);
            myatk = int.Parse(s.getdata(mystast, "ATK"));
            comamando("ATK", myatk,null);
            
        }

        private void btnuse_Click(object sender, EventArgs e)
        {
            if (cmdpanel.Visible == true)
            {
                comamando("USE", 0, cbitem.Text);
            }
            _i.usaritem(cbitem.Text, lblhp, cbitem, lbldialog);
            lblmaxhp.Text = "/" + s.getdata(mystast, "HP");
        }



        private void dialogtimer_Tick(object sender, EventArgs e)
        {
            combat.ticktock(dialogtimer, battlelogtxt);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lblcomando.Text = null;
        }

        private void battlepanel_ControlAdded(object sender, ControlEventArgs e){}
        private void btnstatus_Click(object sender, EventArgs e){}
        private void dialogbox_Paint(object sender, PaintEventArgs e){}
        private void lblescopeta_Click(object sender, EventArgs e) {}

        private void btnsalir_Click(object sender, EventArgs e)
        {
            string items = string.Format("delete from personaje where id = 1");
            s.Exe(items);
            this.Close();
        }

        private void btnsalir_MouseHover_1(object sender, EventArgs e){toolTip1.SetToolTip(btnsalir, "Salir de la realidad");}

    }
}
