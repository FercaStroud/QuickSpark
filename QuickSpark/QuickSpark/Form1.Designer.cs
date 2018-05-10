namespace QuickSpark
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lboponente = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FLECHA4 = new System.Windows.Forms.PictureBox();
            this.FLECHA3 = new System.Windows.Forms.PictureBox();
            this.FLECHA2 = new System.Windows.Forms.PictureBox();
            this.FLECHA1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Repartir = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerOponente = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.megaman3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.megaman4 = new System.Windows.Forms.PictureBox();
            this.WMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.WMP2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.F1 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FLECHA4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FLECHA3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FLECHA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FLECHA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.megaman3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.megaman4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP2)).BeginInit();
            this.SuspendLayout();
            // 
            // lboponente
            // 
            this.lboponente.AutoSize = true;
            this.lboponente.BackColor = System.Drawing.Color.Transparent;
            this.lboponente.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboponente.Location = new System.Drawing.Point(108, 66);
            this.lboponente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lboponente.Name = "lboponente";
            this.lboponente.Size = new System.Drawing.Size(74, 27);
            this.lboponente.TabIndex = 5;
            this.lboponente.Text = "Movido";
            this.lboponente.Visible = false;
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.BackColor = System.Drawing.Color.Transparent;
            this.lbuser.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.Location = new System.Drawing.Point(108, 393);
            this.lbuser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(74, 27);
            this.lbuser.TabIndex = 8;
            this.lbuser.Text = "Movido";
            this.lbuser.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.helpProvider1.SetHelpString(this.label1, "Cartas Restantes del Oponente");
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.helpProvider1.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Restan: 20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.helpProvider1.SetHelpString(this.label2, "Cartas Restantes del Jugador 1");
            this.label2.Location = new System.Drawing.Point(12, 470);
            this.label2.Name = "label2";
            this.helpProvider1.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Restan: 20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(587, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ultima Carta seleccionada:";
            // 
            // FLECHA4
            // 
            this.FLECHA4.BackColor = System.Drawing.Color.Transparent;
            this.FLECHA4.Image = ((System.Drawing.Image)(resources.GetObject("FLECHA4.Image")));
            this.FLECHA4.Location = new System.Drawing.Point(490, 285);
            this.FLECHA4.Name = "FLECHA4";
            this.FLECHA4.Size = new System.Drawing.Size(33, 31);
            this.FLECHA4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FLECHA4.TabIndex = 16;
            this.FLECHA4.TabStop = false;
            // 
            // FLECHA3
            // 
            this.FLECHA3.BackColor = System.Drawing.Color.Transparent;
            this.FLECHA3.Image = ((System.Drawing.Image)(resources.GetObject("FLECHA3.Image")));
            this.FLECHA3.Location = new System.Drawing.Point(403, 285);
            this.FLECHA3.Name = "FLECHA3";
            this.FLECHA3.Size = new System.Drawing.Size(33, 31);
            this.FLECHA3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FLECHA3.TabIndex = 15;
            this.FLECHA3.TabStop = false;
            // 
            // FLECHA2
            // 
            this.FLECHA2.BackColor = System.Drawing.Color.Transparent;
            this.FLECHA2.Image = ((System.Drawing.Image)(resources.GetObject("FLECHA2.Image")));
            this.FLECHA2.Location = new System.Drawing.Point(322, 285);
            this.FLECHA2.Name = "FLECHA2";
            this.FLECHA2.Size = new System.Drawing.Size(33, 31);
            this.FLECHA2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FLECHA2.TabIndex = 14;
            this.FLECHA2.TabStop = false;
            // 
            // FLECHA1
            // 
            this.FLECHA1.BackColor = System.Drawing.Color.Transparent;
            this.FLECHA1.Image = ((System.Drawing.Image)(resources.GetObject("FLECHA1.Image")));
            this.FLECHA1.Location = new System.Drawing.Point(236, 285);
            this.FLECHA1.Name = "FLECHA1";
            this.FLECHA1.Size = new System.Drawing.Size(33, 31);
            this.FLECHA1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FLECHA1.TabIndex = 13;
            this.FLECHA1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpProvider1.SetHelpString(this.pictureBox8, "Carta Actual Seleccionada");
            this.pictureBox8.Image = global::QuickSpark.Properties.Resources.Carta0;
            this.pictureBox8.Location = new System.Drawing.Point(700, 396);
            this.pictureBox8.Name = "pictureBox8";
            this.helpProvider1.SetShowHelp(this.pictureBox8, true);
            this.pictureBox8.Size = new System.Drawing.Size(80, 103);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.helpProvider1.SetHelpString(this.pictureBox7, "Mazo del Jugador1");
            this.pictureBox7.Image = global::QuickSpark.Properties.Resources.Carta;
            this.pictureBox7.Location = new System.Drawing.Point(13, 356);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.helpProvider1.SetShowHelp(this.pictureBox7, true);
            this.pictureBox7.Size = new System.Drawing.Size(87, 109);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.helpProvider1.SetHelpString(this.pictureBox6, "Carta Flip");
            this.pictureBox6.Image = global::QuickSpark.Properties.Resources.Flip;
            this.pictureBox6.Location = new System.Drawing.Point(13, 211);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.helpProvider1.SetShowHelp(this.pictureBox6, true);
            this.pictureBox6.Size = new System.Drawing.Size(82, 105);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(470, 24);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 103);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(382, 24);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 103);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(294, 24);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(206, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Repartir
            // 
            this.Repartir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Repartir.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpNavigator(this.Repartir, System.Windows.Forms.HelpNavigator.Index);
            this.Repartir.Location = new System.Drawing.Point(669, 36);
            this.Repartir.Name = "Repartir";
            this.helpProvider1.SetShowHelp(this.Repartir, true);
            this.Repartir.Size = new System.Drawing.Size(75, 27);
            this.Repartir.TabIndex = 17;
            this.Repartir.Text = "Repartir";
            this.Repartir.UseVisualStyleBackColor = true;
            this.Repartir.Click += new System.EventHandler(this.Repartir_Click);
            // 
            // salir
            // 
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.salir.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpNavigator(this.salir, System.Windows.Forms.HelpNavigator.Index);
            this.salir.Location = new System.Drawing.Point(669, 69);
            this.salir.Name = "salir";
            this.helpProvider1.SetShowHelp(this.salir, true);
            this.salir.Size = new System.Drawing.Size(75, 27);
            this.salir.TabIndex = 18;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 7000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerOponente
            // 
            this.timerOponente.Interval = 3000;
            this.timerOponente.Tick += new System.EventHandler(this.timerOponente_Tick);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "QuickSparkHELP.chm";
            // 
            // megaman3
            // 
            this.megaman3.BackColor = System.Drawing.Color.Transparent;
            this.helpProvider1.SetHelpString(this.megaman3, "Megaman");
            this.megaman3.Image = global::QuickSpark.Properties.Resources.logo_8bits;
            this.megaman3.Location = new System.Drawing.Point(540, 415);
            this.megaman3.Name = "megaman3";
            this.helpProvider1.SetShowHelp(this.megaman3, true);
            this.megaman3.Size = new System.Drawing.Size(98, 76);
            this.megaman3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.megaman3.TabIndex = 22;
            this.megaman3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.helpProvider1.SetHelpString(this.pictureBox1, "Mazo del Oponente");
            this.pictureBox1.Image = global::QuickSpark.Properties.Resources.Carta;
            this.pictureBox1.Location = new System.Drawing.Point(13, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.helpProvider1.SetShowHelp(this.pictureBox1, true);
            this.pictureBox1.Size = new System.Drawing.Size(87, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.helpProvider1.SetHelpString(this.pictureBox9, "Alien");
            this.pictureBox9.Image = global::QuickSpark.Properties.Resources.cosito;
            this.pictureBox9.Location = new System.Drawing.Point(692, 195);
            this.pictureBox9.Name = "pictureBox9";
            this.helpProvider1.SetShowHelp(this.pictureBox9, true);
            this.pictureBox9.Size = new System.Drawing.Size(114, 88);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 27;
            this.pictureBox9.TabStop = false;
            // 
            // megaman4
            // 
            this.megaman4.BackColor = System.Drawing.Color.Transparent;
            this.megaman4.Image = global::QuickSpark.Properties.Resources.megaman4;
            this.megaman4.Location = new System.Drawing.Point(644, 440);
            this.megaman4.Name = "megaman4";
            this.megaman4.Size = new System.Drawing.Size(34, 16);
            this.megaman4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.megaman4.TabIndex = 23;
            this.megaman4.TabStop = false;
            // 
            // WMP1
            // 
            this.WMP1.Enabled = true;
            this.WMP1.Location = new System.Drawing.Point(113, 470);
            this.WMP1.Name = "WMP1";
            this.WMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP1.OcxState")));
            this.WMP1.Size = new System.Drawing.Size(103, 44);
            this.WMP1.TabIndex = 25;
            this.WMP1.Visible = false;
            // 
            // WMP2
            // 
            this.WMP2.Enabled = true;
            this.WMP2.Location = new System.Drawing.Point(236, 470);
            this.WMP2.Name = "WMP2";
            this.WMP2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP2.OcxState")));
            this.WMP2.Size = new System.Drawing.Size(138, 44);
            this.WMP2.TabIndex = 26;
            this.WMP2.Visible = false;
            // 
            // F1
            // 
            this.F1.AutoSize = true;
            this.F1.BackColor = System.Drawing.Color.Transparent;
            this.F1.ForeColor = System.Drawing.Color.Black;
            this.F1.Location = new System.Drawing.Point(688, 160);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(117, 21);
            this.F1.TabIndex = 28;
            this.F1.Text = "F1 Para Ayuda";
            // 
            // timer3
            // 
            this.timer3.Interval = 300;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 950;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuickSpark.Properties.Resources.Fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 516);
            this.Controls.Add(this.F1);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.WMP2);
            this.Controls.Add(this.WMP1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.megaman4);
            this.Controls.Add(this.megaman3);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.Repartir);
            this.Controls.Add(this.FLECHA4);
            this.Controls.Add(this.FLECHA3);
            this.Controls.Add(this.FLECHA2);
            this.Controls.Add(this.FLECHA1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lboponente);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Index);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Bienvenido a QuickSpark";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FLECHA4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FLECHA3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FLECHA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FLECHA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.megaman3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.megaman4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lboponente;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox FLECHA1;
        private System.Windows.Forms.PictureBox FLECHA2;
        private System.Windows.Forms.PictureBox FLECHA3;
        private System.Windows.Forms.PictureBox FLECHA4;
        private System.Windows.Forms.Button Repartir;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerOponente;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox megaman3;
        private System.Windows.Forms.PictureBox megaman4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer WMP1;
        private AxWMPLib.AxWindowsMediaPlayer WMP2;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label F1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}

