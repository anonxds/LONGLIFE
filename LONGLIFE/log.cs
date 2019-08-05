using LONGLIFE.combatSYS;
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

namespace LONGLIFE
{
    public partial class log : Form
    {
    
        public log()
        {
            InitializeComponent();
            lbllog.Text += Form1._logs;           

        }
      
        private void btnatk_Click(object sender, EventArgs e)
        {
        }
      
        private void btndef_Click(object sender, EventArgs e)
        {
        }
      
      
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
