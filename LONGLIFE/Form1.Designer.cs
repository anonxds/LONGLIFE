namespace LONGLIFE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dialogbox = new System.Windows.Forms.Panel();
            this.lbldialog = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnop3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnop2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnop1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdpanel = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Comandos = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbitem = new System.Windows.Forms.ComboBox();
            this.lblenemyhp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblenemydef = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblnombreenemigo = new System.Windows.Forms.Label();
            this.lblenemyatk = new System.Windows.Forms.Label();
            this.dialogtimer = new System.Windows.Forms.Timer(this.components);
            this.battlepanel = new System.Windows.Forms.Panel();
            this.battlelogtxt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblcomando = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTiempo = new LCDLabel.LcdLabel();
            this.lblubicacion = new LCDLabel.LcdLabel();
            this.btnsalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnuse = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnatk = new Bunifu.Framework.UI.BunifuImageButton();
            this.btndef = new Bunifu.Framework.UI.BunifuImageButton();
            this.btndagger = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnescopeta = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnlog = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnstatus = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblescopeta = new LCDLabel.LcdLabel();
            this.lblammo = new LCDLabel.LcdLabel();
            this.lcdLabel3 = new LCDLabel.LcdLabel();
            this.lcdLabel2 = new LCDLabel.LcdLabel();
            this.lblmaxhp = new LCDLabel.LcdLabel();
            this.lblhp = new LCDLabel.LcdLabel();
            this.lblNhp = new LCDLabel.LcdLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dialogbox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cmdpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.battlepanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnuse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnatk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndagger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnescopeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnstatus)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogbox
            // 
            this.dialogbox.Controls.Add(this.lbldialog);
            this.dialogbox.Location = new System.Drawing.Point(314, 333);
            this.dialogbox.Name = "dialogbox";
            this.dialogbox.Size = new System.Drawing.Size(783, 251);
            this.dialogbox.TabIndex = 1;
            this.dialogbox.Paint += new System.Windows.Forms.PaintEventHandler(this.dialogbox_Paint);
            this.dialogbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dialogbox_MouseClick);
            // 
            // lbldialog
            // 
            this.lbldialog.AutoSize = true;
            this.lbldialog.ForeColor = System.Drawing.Color.White;
            this.lbldialog.Location = new System.Drawing.Point(44, 39);
            this.lbldialog.Name = "lbldialog";
            this.lbldialog.Size = new System.Drawing.Size(13, 20);
            this.lbldialog.TabIndex = 0;
            this.lbldialog.Text = " ";
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnop3);
            this.panel2.Controls.Add(this.btnop2);
            this.panel2.Controls.Add(this.btnop1);
            this.panel2.Location = new System.Drawing.Point(432, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 243);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // btnop3
            // 
            this.btnop3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnop3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnop3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnop3.BorderRadius = 0;
            this.btnop3.ButtonText = "opcion 3";
            this.btnop3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnop3.DisabledColor = System.Drawing.Color.Gray;
            this.btnop3.Iconcolor = System.Drawing.Color.Transparent;
            this.btnop3.Iconimage = null;
            this.btnop3.Iconimage_right = null;
            this.btnop3.Iconimage_right_Selected = null;
            this.btnop3.Iconimage_Selected = null;
            this.btnop3.IconMarginLeft = 0;
            this.btnop3.IconMarginRight = 0;
            this.btnop3.IconRightVisible = true;
            this.btnop3.IconRightZoom = 0D;
            this.btnop3.IconVisible = true;
            this.btnop3.IconZoom = 90D;
            this.btnop3.IsTab = false;
            this.btnop3.Location = new System.Drawing.Point(146, 169);
            this.btnop3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnop3.Name = "btnop3";
            this.btnop3.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnop3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnop3.OnHoverTextColor = System.Drawing.Color.White;
            this.btnop3.selected = false;
            this.btnop3.Size = new System.Drawing.Size(315, 53);
            this.btnop3.TabIndex = 2;
            this.btnop3.Text = "opcion 3";
            this.btnop3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnop3.Textcolor = System.Drawing.Color.White;
            this.btnop3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnop3.Click += new System.EventHandler(this.btnop3_Click);
            // 
            // btnop2
            // 
            this.btnop2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnop2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnop2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnop2.BorderRadius = 0;
            this.btnop2.ButtonText = "opcion 2";
            this.btnop2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnop2.DisabledColor = System.Drawing.Color.Gray;
            this.btnop2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnop2.Iconimage = null;
            this.btnop2.Iconimage_right = null;
            this.btnop2.Iconimage_right_Selected = null;
            this.btnop2.Iconimage_Selected = null;
            this.btnop2.IconMarginLeft = 0;
            this.btnop2.IconMarginRight = 0;
            this.btnop2.IconRightVisible = true;
            this.btnop2.IconRightZoom = 0D;
            this.btnop2.IconVisible = true;
            this.btnop2.IconZoom = 90D;
            this.btnop2.IsTab = false;
            this.btnop2.Location = new System.Drawing.Point(146, 97);
            this.btnop2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnop2.Name = "btnop2";
            this.btnop2.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnop2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnop2.OnHoverTextColor = System.Drawing.Color.White;
            this.btnop2.selected = false;
            this.btnop2.Size = new System.Drawing.Size(315, 53);
            this.btnop2.TabIndex = 1;
            this.btnop2.Text = "opcion 2";
            this.btnop2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnop2.Textcolor = System.Drawing.Color.White;
            this.btnop2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnop2.Click += new System.EventHandler(this.btnop2_Click);
            // 
            // btnop1
            // 
            this.btnop1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnop1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnop1.BorderRadius = 0;
            this.btnop1.ButtonText = "opcion 1";
            this.btnop1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnop1.DisabledColor = System.Drawing.Color.Gray;
            this.btnop1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnop1.Iconimage = null;
            this.btnop1.Iconimage_right = null;
            this.btnop1.Iconimage_right_Selected = null;
            this.btnop1.Iconimage_Selected = null;
            this.btnop1.IconMarginLeft = 0;
            this.btnop1.IconMarginRight = 0;
            this.btnop1.IconRightVisible = true;
            this.btnop1.IconRightZoom = 0D;
            this.btnop1.IconVisible = true;
            this.btnop1.IconZoom = 90D;
            this.btnop1.IsTab = false;
            this.btnop1.Location = new System.Drawing.Point(144, 35);
            this.btnop1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnop1.Name = "btnop1";
            this.btnop1.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.btnop1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnop1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnop1.selected = false;
            this.btnop1.Size = new System.Drawing.Size(315, 53);
            this.btnop1.TabIndex = 0;
            this.btnop1.Text = "opcion 1";
            this.btnop1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnop1.Textcolor = System.Drawing.Color.White;
            this.btnop1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnop1.Click += new System.EventHandler(this.btnop1_Click);
            // 
            // cmdpanel
            // 
            this.cmdpanel.ColumnCount = 2;
            this.cmdpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cmdpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cmdpanel.Controls.Add(this.bunifuCustomLabel3, 0, 3);
            this.cmdpanel.Controls.Add(this.bunifuCustomLabel2, 0, 3);
            this.cmdpanel.Controls.Add(this.btnatk, 0, 0);
            this.cmdpanel.Controls.Add(this.btndef, 1, 0);
            this.cmdpanel.Controls.Add(this.btndagger, 0, 2);
            this.cmdpanel.Controls.Add(this.btnescopeta, 1, 2);
            this.cmdpanel.Controls.Add(this.Comandos, 0, 1);
            this.cmdpanel.Controls.Add(this.bunifuCustomLabel1, 1, 1);
            this.cmdpanel.Location = new System.Drawing.Point(22, 333);
            this.cmdpanel.Name = "cmdpanel";
            this.cmdpanel.RowCount = 4;
            this.cmdpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.47059F));
            this.cmdpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.52941F));
            this.cmdpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.cmdpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.cmdpanel.Size = new System.Drawing.Size(217, 290);
            this.cmdpanel.TabIndex = 10;
            this.cmdpanel.Visible = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(3, 230);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(57, 20);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "Dagga";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(111, 230);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(77, 20);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Escopeta";
            // 
            // Comandos
            // 
            this.Comandos.AutoSize = true;
            this.Comandos.Location = new System.Drawing.Point(3, 97);
            this.Comandos.Name = "Comandos";
            this.Comandos.Size = new System.Drawing.Size(41, 20);
            this.Comandos.TabIndex = 7;
            this.Comandos.Text = "Rifle";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(111, 97);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(76, 20);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Defender";
            // 
            // cbitem
            // 
            this.cbitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbitem.FormattingEnabled = true;
            this.cbitem.Location = new System.Drawing.Point(100, 3);
            this.cbitem.Name = "cbitem";
            this.cbitem.Size = new System.Drawing.Size(103, 28);
            this.cbitem.TabIndex = 5;
            this.cbitem.SelectedIndexChanged += new System.EventHandler(this.cbitem_SelectedIndexChanged);
            // 
            // lblenemyhp
            // 
            this.lblenemyhp.AutoSize = true;
            this.lblenemyhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenemyhp.Location = new System.Drawing.Point(15, 12);
            this.lblenemyhp.Name = "lblenemyhp";
            this.lblenemyhp.Size = new System.Drawing.Size(24, 26);
            this.lblenemyhp.TabIndex = 4;
            this.lblenemyhp.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 726);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 726);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status";
            // 
            // lblenemydef
            // 
            this.lblenemydef.AutoSize = true;
            this.lblenemydef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenemydef.Location = new System.Drawing.Point(15, 56);
            this.lblenemydef.Name = "lblenemydef";
            this.lblenemydef.Size = new System.Drawing.Size(24, 26);
            this.lblenemydef.TabIndex = 11;
            this.lblenemydef.Text = "0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblnombreenemigo);
            this.panel3.Controls.Add(this.lblenemyatk);
            this.panel3.Controls.Add(this.lblenemyhp);
            this.panel3.Controls.Add(this.lblenemydef);
            this.panel3.Location = new System.Drawing.Point(992, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 156);
            this.panel3.TabIndex = 12;
            // 
            // lblnombreenemigo
            // 
            this.lblnombreenemigo.AutoSize = true;
            this.lblnombreenemigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreenemigo.Location = new System.Drawing.Point(15, 126);
            this.lblnombreenemigo.Name = "lblnombreenemigo";
            this.lblnombreenemigo.Size = new System.Drawing.Size(24, 26);
            this.lblnombreenemigo.TabIndex = 13;
            this.lblnombreenemigo.Text = "0";
            // 
            // lblenemyatk
            // 
            this.lblenemyatk.AutoSize = true;
            this.lblenemyatk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenemyatk.Location = new System.Drawing.Point(15, 100);
            this.lblenemyatk.Name = "lblenemyatk";
            this.lblenemyatk.Size = new System.Drawing.Size(24, 26);
            this.lblenemyatk.TabIndex = 12;
            this.lblenemyatk.Text = "0";
            // 
            // dialogtimer
            // 
            this.dialogtimer.Interval = 1;
            this.dialogtimer.Tick += new System.EventHandler(this.dialogtimer_Tick);
            // 
            // battlepanel
            // 
            this.battlepanel.AutoScroll = true;
            this.battlepanel.Controls.Add(this.battlelogtxt);
            this.battlepanel.Controls.Add(this.lblcomando);
            this.battlepanel.Location = new System.Drawing.Point(578, 590);
            this.battlepanel.Name = "battlepanel";
            this.battlepanel.Size = new System.Drawing.Size(519, 174);
            this.battlepanel.TabIndex = 1;
            this.battlepanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.battlepanel_ControlAdded);
            // 
            // battlelogtxt
            // 
            this.battlelogtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(13)))));
            this.battlelogtxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.battlelogtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(240)))), ((int)(((byte)(116)))));
            this.battlelogtxt.Location = new System.Drawing.Point(23, 13);
            this.battlelogtxt.Multiline = true;
            this.battlelogtxt.Name = "battlelogtxt";
            this.battlelogtxt.ReadOnly = true;
            this.battlelogtxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.battlelogtxt.Size = new System.Drawing.Size(483, 129);
            this.battlelogtxt.TabIndex = 1;
            // 
            // lblcomando
            // 
            this.lblcomando.AutoSize = true;
            this.lblcomando.Location = new System.Drawing.Point(19, 145);
            this.lblcomando.Name = "lblcomando";
            this.lblcomando.Size = new System.Drawing.Size(82, 20);
            this.lblcomando.TabIndex = 0;
            this.lblcomando.Text = "Battle Log";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnuse);
            this.flowLayoutPanel1.Controls.Add(this.cbitem);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 629);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 117);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Usar item";
            // 
            // lblTiempo
            // 
            this.lblTiempo.BackGround = System.Drawing.Color.Transparent;
            this.lblTiempo.BorderColor = System.Drawing.Color.Black;
            this.lblTiempo.BorderSpace = 3;
            this.lblTiempo.CharSpacing = 2;
            this.lblTiempo.DotMatrix = LCDLabel.DotMatrix.dos5x7;
            this.lblTiempo.LineSpacing = 2;
            this.lblTiempo.Location = new System.Drawing.Point(529, 12);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.NumberOfCharacters = 13;
            this.lblTiempo.PixelHeight = 2;
            this.lblTiempo.PixelOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblTiempo.PixelOn = System.Drawing.Color.Black;
            this.lblTiempo.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lblTiempo.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lblTiempo.PixelSpacing = 1;
            this.lblTiempo.PixelWidth = 2;
            this.lblTiempo.Size = new System.Drawing.Size(214, 28);
            this.lblTiempo.TabIndex = 15;
            this.lblTiempo.Text = "lcdLabel1";
            this.lblTiempo.TextLines = 1;
            // 
            // lblubicacion
            // 
            this.lblubicacion.BackGround = System.Drawing.Color.Transparent;
            this.lblubicacion.BorderColor = System.Drawing.Color.Black;
            this.lblubicacion.BorderSpace = 3;
            this.lblubicacion.CharSpacing = 2;
            this.lblubicacion.DotMatrix = LCDLabel.DotMatrix.mat5x7;
            this.lblubicacion.LineSpacing = 2;
            this.lblubicacion.Location = new System.Drawing.Point(396, 50);
            this.lblubicacion.Name = "lblubicacion";
            this.lblubicacion.NumberOfCharacters = 28;
            this.lblubicacion.PixelHeight = 2;
            this.lblubicacion.PixelOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblubicacion.PixelOn = System.Drawing.Color.Black;
            this.lblubicacion.PixelShape = LCDLabel.PixelShape.Shaped;
            this.lblubicacion.PixelSize = LCDLabel.PixelSize.pix2x2;
            this.lblubicacion.PixelSpacing = 1;
            this.lblubicacion.PixelWidth = 2;
            this.lblubicacion.Size = new System.Drawing.Size(454, 28);
            this.lblubicacion.TabIndex = 16;
            this.lblubicacion.Text = "lcdLabel2";
            this.lblubicacion.TextLines = 1;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.Image = global::LONGLIFE.Properties.Resources.russian_roulette;
            this.btnsalir.ImageActive = global::LONGLIFE.Properties.Resources.russian_roulette__1_;
            this.btnsalir.Location = new System.Drawing.Point(1073, 27);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(81, 126);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 14;
            this.btnsalir.TabStop = false;
            this.btnsalir.Zoom = 10;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            this.btnsalir.MouseHover += new System.EventHandler(this.btnsalir_MouseHover_1);
            // 
            // btnuse
            // 
            this.btnuse.BackColor = System.Drawing.Color.Transparent;
            this.btnuse.Enabled = false;
            this.btnuse.Image = global::LONGLIFE.Properties.Resources.power;
            this.btnuse.ImageActive = global::LONGLIFE.Properties.Resources.motivation;
            this.btnuse.Location = new System.Drawing.Point(3, 3);
            this.btnuse.Name = "btnuse";
            this.btnuse.Size = new System.Drawing.Size(91, 68);
            this.btnuse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnuse.TabIndex = 3;
            this.btnuse.TabStop = false;
            this.btnuse.Zoom = 10;
            this.btnuse.Click += new System.EventHandler(this.btnuse_Click);
            this.btnuse.MouseHover += new System.EventHandler(this.btnuse_MouseHover);
            // 
            // btnatk
            // 
            this.btnatk.BackColor = System.Drawing.Color.Transparent;
            this.btnatk.Image = global::LONGLIFE.Properties.Resources.rifle;
            this.btnatk.ImageActive = global::LONGLIFE.Properties.Resources.rifle__1_;
            this.btnatk.Location = new System.Drawing.Point(3, 3);
            this.btnatk.Name = "btnatk";
            this.btnatk.Size = new System.Drawing.Size(95, 73);
            this.btnatk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnatk.TabIndex = 0;
            this.btnatk.TabStop = false;
            this.btnatk.Zoom = 10;
            this.btnatk.Click += new System.EventHandler(this.btnatk_Click);
            this.btnatk.MouseHover += new System.EventHandler(this.btnatk_MouseHover);
            // 
            // btndef
            // 
            this.btndef.BackColor = System.Drawing.Color.Transparent;
            this.btndef.Image = global::LONGLIFE.Properties.Resources.shield;
            this.btndef.ImageActive = global::LONGLIFE.Properties.Resources.shield__1_;
            this.btndef.Location = new System.Drawing.Point(111, 3);
            this.btndef.Name = "btndef";
            this.btndef.Size = new System.Drawing.Size(91, 73);
            this.btndef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btndef.TabIndex = 1;
            this.btndef.TabStop = false;
            this.btndef.Zoom = 10;
            this.btndef.Click += new System.EventHandler(this.btndef_Click);
            this.btndef.MouseHover += new System.EventHandler(this.btndef_MouseHover);
            // 
            // btndagger
            // 
            this.btndagger.BackColor = System.Drawing.Color.Transparent;
            this.btndagger.Image = global::LONGLIFE.Properties.Resources.dagger;
            this.btndagger.ImageActive = global::LONGLIFE.Properties.Resources.knife;
            this.btndagger.Location = new System.Drawing.Point(3, 129);
            this.btndagger.Name = "btndagger";
            this.btndagger.Size = new System.Drawing.Size(86, 87);
            this.btndagger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btndagger.TabIndex = 8;
            this.btndagger.TabStop = false;
            this.btndagger.Zoom = 10;
            this.btndagger.Click += new System.EventHandler(this.btndagger_Click);
            // 
            // btnescopeta
            // 
            this.btnescopeta.BackColor = System.Drawing.Color.Transparent;
            this.btnescopeta.Image = global::LONGLIFE.Properties.Resources.shotgun;
            this.btnescopeta.ImageActive = global::LONGLIFE.Properties.Resources.shotgun__1_;
            this.btnescopeta.Location = new System.Drawing.Point(111, 129);
            this.btnescopeta.Name = "btnescopeta";
            this.btnescopeta.Size = new System.Drawing.Size(71, 71);
            this.btnescopeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnescopeta.TabIndex = 6;
            this.btnescopeta.TabStop = false;
            this.btnescopeta.Zoom = 10;
            this.btnescopeta.Click += new System.EventHandler(this.btnescopeta_Click);
            this.btnescopeta.MouseLeave += new System.EventHandler(this.btnescopeta_MouseLeave);
            this.btnescopeta.MouseHover += new System.EventHandler(this.btnescopeta_MouseHover);
            // 
            // btnlog
            // 
            this.btnlog.BackColor = System.Drawing.Color.Transparent;
            this.btnlog.Image = global::LONGLIFE.Properties.Resources.note;
            this.btnlog.ImageActive = null;
            this.btnlog.Location = new System.Drawing.Point(314, 652);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(71, 71);
            this.btnlog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlog.TabIndex = 7;
            this.btnlog.TabStop = false;
            this.btnlog.Zoom = 10;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btnstatus
            // 
            this.btnstatus.BackColor = System.Drawing.Color.Transparent;
            this.btnstatus.Image = global::LONGLIFE.Properties.Resources.helmet;
            this.btnstatus.ImageActive = global::LONGLIFE.Properties.Resources.helmet1;
            this.btnstatus.Location = new System.Drawing.Point(441, 652);
            this.btnstatus.Name = "btnstatus";
            this.btnstatus.Size = new System.Drawing.Size(71, 71);
            this.btnstatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnstatus.TabIndex = 5;
            this.btnstatus.TabStop = false;
            this.btnstatus.Zoom = 10;
            this.btnstatus.Click += new System.EventHandler(this.btnstatus_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LONGLIFE.Properties.Resources.greenback;
            this.panel1.Controls.Add(this.lblescopeta);
            this.panel1.Controls.Add(this.lblammo);
            this.panel1.Controls.Add(this.lcdLabel3);
            this.panel1.Controls.Add(this.lcdLabel2);
            this.panel1.Controls.Add(this.lblmaxhp);
            this.panel1.Controls.Add(this.lblhp);
            this.panel1.Controls.Add(this.lblNhp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 277);
            this.panel1.TabIndex = 8;
            // 
            // lblescopeta
            // 
            this.lblescopeta.BackGround = System.Drawing.Color.Transparent;
            this.lblescopeta.BackgroundImage = global::LONGLIFE.Properties.Resources.greenback;
            this.lblescopeta.BorderColor = System.Drawing.Color.Black;
            this.lblescopeta.BorderSpace = 3;
            this.lblescopeta.CharSpacing = 2;
            this.lblescopeta.DotMatrix = LCDLabel.DotMatrix.mat5x7;
            this.lblescopeta.LineSpacing = 2;
            this.lblescopeta.Location = new System.Drawing.Point(187, 182);
            this.lblescopeta.Name = "lblescopeta";
            this.lblescopeta.NumberOfCharacters = 6;
            this.lblescopeta.PixelHeight = 1;
            this.lblescopeta.PixelOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblescopeta.PixelOn = System.Drawing.Color.White;
            this.lblescopeta.PixelShape = LCDLabel.PixelShape.Square;
            this.lblescopeta.PixelSize = LCDLabel.PixelSize.pix1x1;
            this.lblescopeta.PixelSpacing = 1;
            this.lblescopeta.PixelWidth = 1;
            this.lblescopeta.Size = new System.Drawing.Size(72, 21);
            this.lblescopeta.TabIndex = 23;
            this.lblescopeta.Text = "0";
            this.lblescopeta.TextLines = 1;
            this.lblescopeta.Click += new System.EventHandler(this.lblescopeta_Click);
            // 
            // lblammo
            // 
            this.lblammo.BackColor = System.Drawing.Color.White;
            this.lblammo.BackGround = System.Drawing.Color.Transparent;
            this.lblammo.BackgroundImage = global::LONGLIFE.Properties.Resources.greenback;
            this.lblammo.BorderColor = System.Drawing.Color.Black;
            this.lblammo.BorderSpace = 3;
            this.lblammo.CharSpacing = 2;
            this.lblammo.DotMatrix = LCDLabel.DotMatrix.mat5x7;
            this.lblammo.LineSpacing = 2;
            this.lblammo.Location = new System.Drawing.Point(187, 117);
            this.lblammo.Name = "lblammo";
            this.lblammo.NumberOfCharacters = 6;
            this.lblammo.PixelHeight = 1;
            this.lblammo.PixelOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblammo.PixelOn = System.Drawing.Color.White;
            this.lblammo.PixelShape = LCDLabel.PixelShape.Square;
            this.lblammo.PixelSize = LCDLabel.PixelSize.pix1x1;
            this.lblammo.PixelSpacing = 1;
            this.lblammo.PixelWidth = 1;
            this.lblammo.Size = new System.Drawing.Size(72, 21);
            this.lblammo.TabIndex = 22;
            this.lblammo.Text = "0";
            this.lblammo.TextLines = 1;
            // 
            // lcdLabel3
            // 
            this.lcdLabel3.BackGround = System.Drawing.Color.Transparent;
            this.lcdLabel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lcdLabel3.BackgroundImage")));
            this.lcdLabel3.BorderColor = System.Drawing.Color.Black;
            this.lcdLabel3.BorderSpace = 3;
            this.lcdLabel3.CharSpacing = 2;
            this.lcdLabel3.DotMatrix = LCDLabel.DotMatrix.mat5x7;
            this.lcdLabel3.LineSpacing = 2;
            this.lcdLabel3.Location = new System.Drawing.Point(10, 182);
            this.lcdLabel3.Name = "lcdLabel3";
            this.lcdLabel3.NumberOfCharacters = 13;
            this.lcdLabel3.PixelHeight = 1;
            this.lcdLabel3.PixelOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lcdLabel3.PixelOn = System.Drawing.Color.White;
            this.lcdLabel3.PixelShape = LCDLabel.PixelShape.Square;
            this.lcdLabel3.PixelSize = LCDLabel.PixelSize.pix1x1;
            this.lcdLabel3.PixelSpacing = 1;
            this.lcdLabel3.PixelWidth = 1;
            this.lcdLabel3.Size = new System.Drawing.Size(149, 36);
            this.lcdLabel3.TabIndex = 21;
            this.lcdLabel3.Text = "Escopeta";
            this.lcdLabel3.TextLines = 2;
            // 
            // lcdLabel2
            // 
            this.lcdLabel2.BackGround = System.Drawing.Color.Transparent;
            this.lcdLabel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lcdLabel2.BackgroundImage")));
            this.lcdLabel2.BorderColor = System.Drawing.Color.Black;
            this.lcdLabel2.BorderSpace = 3;
            this.lcdLabel2.CharSpacing = 2;
            this.lcdLabel2.DotMatrix = LCDLabel.DotMatrix.mat5x7;
            this.lcdLabel2.LineSpacing = 2;
            this.lcdLabel2.Location = new System.Drawing.Point(10, 117);
            this.lcdLabel2.Name = "lcdLabel2";
            this.lcdLabel2.NumberOfCharacters = 15;
            this.lcdLabel2.PixelHeight = 1;
            this.lcdLabel2.PixelOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lcdLabel2.PixelOn = System.Drawing.Color.White;
            this.lcdLabel2.PixelShape = LCDLabel.PixelShape.Square;
            this.lcdLabel2.PixelSize = LCDLabel.PixelSize.pix1x1;
            this.lcdLabel2.PixelSpacing = 1;
            this.lcdLabel2.PixelWidth = 1;
            this.lcdLabel2.Size = new System.Drawing.Size(171, 36);
            this.lcdLabel2.TabIndex = 20;
            this.lcdLabel2.Text = "45mm NATO";
            this.lcdLabel2.TextLines = 2;
            // 
            // lblmaxhp
            // 
            this.lblmaxhp.BackGround = System.Drawing.Color.Transparent;
            this.lblmaxhp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblmaxhp.BackgroundImage")));
            this.lblmaxhp.BorderColor = System.Drawing.Color.Black;
            this.lblmaxhp.BorderSpace = 3;
            this.lblmaxhp.CharSpacing = 2;
            this.lblmaxhp.DotMatrix = LCDLabel.DotMatrix.mat5x7;
            this.lblmaxhp.LineSpacing = 2;
            this.lblmaxhp.Location = new System.Drawing.Point(156, 49);
            this.lblmaxhp.Name = "lblmaxhp";
            this.lblmaxhp.NumberOfCharacters = 5;
            this.lblmaxhp.PixelHeight = 1;
            this.lblmaxhp.PixelOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblmaxhp.PixelOn = System.Drawing.Color.White;
            this.lblmaxhp.PixelShape = LCDLabel.PixelShape.Square;
            this.lblmaxhp.PixelSize = LCDLabel.PixelSize.pix1x1;
            this.lblmaxhp.PixelSpacing = 1;
            this.lblmaxhp.PixelWidth = 1;
            this.lblmaxhp.Size = new System.Drawing.Size(61, 21);
            this.lblmaxhp.TabIndex = 18;
            this.lblmaxhp.Text = "/10";
            this.lblmaxhp.TextLines = 1;
            // 
            // lblhp
            // 
            this.lblhp.BackGround = System.Drawing.Color.Transparent;
            this.lblhp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblhp.BackgroundImage")));
            this.lblhp.BorderColor = System.Drawing.Color.Black;
            this.lblhp.BorderSpace = 3;
            this.lblhp.CharSpacing = 2;
            this.lblhp.DotMatrix = LCDLabel.DotMatrix.mat5x7;
            this.lblhp.LineSpacing = 2;
            this.lblhp.Location = new System.Drawing.Point(115, 49);
            this.lblhp.Name = "lblhp";
            this.lblhp.NumberOfCharacters = 4;
            this.lblhp.PixelHeight = 1;
            this.lblhp.PixelOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblhp.PixelOn = System.Drawing.Color.White;
            this.lblhp.PixelShape = LCDLabel.PixelShape.Square;
            this.lblhp.PixelSize = LCDLabel.PixelSize.pix1x1;
            this.lblhp.PixelSpacing = 1;
            this.lblhp.PixelWidth = 1;
            this.lblhp.Size = new System.Drawing.Size(50, 21);
            this.lblhp.TabIndex = 19;
            this.lblhp.Text = "10";
            this.lblhp.TextLines = 1;
            // 
            // lblNhp
            // 
            this.lblNhp.BackGround = System.Drawing.Color.Transparent;
            this.lblNhp.BackgroundImage = global::LONGLIFE.Properties.Resources.greenback;
            this.lblNhp.BorderColor = System.Drawing.Color.Black;
            this.lblNhp.BorderSpace = 3;
            this.lblNhp.CharSpacing = 2;
            this.lblNhp.DotMatrix = LCDLabel.DotMatrix.mat5x7;
            this.lblNhp.LineSpacing = 2;
            this.lblNhp.Location = new System.Drawing.Point(10, 48);
            this.lblNhp.Name = "lblNhp";
            this.lblNhp.NumberOfCharacters = 3;
            this.lblNhp.PixelHeight = 1;
            this.lblNhp.PixelOff = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblNhp.PixelOn = System.Drawing.Color.White;
            this.lblNhp.PixelShape = LCDLabel.PixelShape.Square;
            this.lblNhp.PixelSize = LCDLabel.PixelSize.pix1x1;
            this.lblNhp.PixelSpacing = 1;
            this.lblNhp.PixelWidth = 1;
            this.lblNhp.Size = new System.Drawing.Size(39, 36);
            this.lblNhp.TabIndex = 17;
            this.lblNhp.Text = "HP";
            this.lblNhp.TextLines = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LONGLIFE.Properties.Resources._6LoI;
            this.pictureBox1.Location = new System.Drawing.Point(62, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 808);
            this.Controls.Add(this.lblubicacion);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.battlepanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmdpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnstatus);
            this.Controls.Add(this.dialogbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dialogbox.ResumeLayout(false);
            this.dialogbox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.cmdpanel.ResumeLayout(false);
            this.cmdpanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.battlepanel.ResumeLayout(false);
            this.battlepanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnuse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnatk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndagger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnescopeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnstatus)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel dialogbox;
        private Bunifu.Framework.UI.BunifuCustomLabel lbldialog;
        private Bunifu.Framework.UI.BunifuImageButton btnstatus;
        private Bunifu.Framework.UI.BunifuImageButton btnlog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnop3;
        private Bunifu.Framework.UI.BunifuFlatButton btnop2;
        private Bunifu.Framework.UI.BunifuFlatButton btnop1;
        private System.Windows.Forms.TableLayoutPanel cmdpanel;
        private Bunifu.Framework.UI.BunifuImageButton btnatk;
        private Bunifu.Framework.UI.BunifuImageButton btndef;
        private Bunifu.Framework.UI.BunifuImageButton btnuse;
        private System.Windows.Forms.Label lblenemyhp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblenemydef;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblenemyatk;
        private System.Windows.Forms.ComboBox cbitem;
        private System.Windows.Forms.Label lblnombreenemigo;
        private Bunifu.Framework.UI.BunifuImageButton btnescopeta;
        private Bunifu.Framework.UI.BunifuCustomLabel Comandos;
        private Bunifu.Framework.UI.BunifuImageButton btndagger;
        private System.Windows.Forms.Timer dialogtimer;
        private System.Windows.Forms.Panel battlepanel;
        private System.Windows.Forms.Label lblcomando;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox battlelogtxt;
        private Bunifu.Framework.UI.BunifuImageButton btnsalir;
        private LCDLabel.LcdLabel lblTiempo;
        private LCDLabel.LcdLabel lblubicacion;
        private LCDLabel.LcdLabel lblNhp;
        private LCDLabel.LcdLabel lblmaxhp;
        private LCDLabel.LcdLabel lblhp;
        private LCDLabel.LcdLabel lcdLabel3;
        private LCDLabel.LcdLabel lcdLabel2;
        private LCDLabel.LcdLabel lblammo;
        private LCDLabel.LcdLabel lblescopeta;
    }
}

