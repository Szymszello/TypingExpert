namespace WindowsFormsApplication1
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zobaczWynikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelczas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.labelwynik = new System.Windows.Forms.Label();
            this.zapis = new System.Windows.Forms.Button();
            this.wyrazyBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWyrazy = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(195, 273);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(427, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Wpisz tekst..";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajToolStripMenuItem,
            this.zobaczWynikiToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.startToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.wczytajToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.wczytajToolStripMenuItem.Text = "Wczytaj ";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.wczytajToolStripMenuItem_Click);
            // 
            // zobaczWynikiToolStripMenuItem
            // 
            this.zobaczWynikiToolStripMenuItem.Name = "zobaczWynikiToolStripMenuItem";
            this.zobaczWynikiToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.zobaczWynikiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.zobaczWynikiToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.zobaczWynikiToolStripMenuItem.Text = "Zobacz wyniki";
            this.zobaczWynikiToolStripMenuItem.Click += new System.EventHandler(this.zobaczWynikiToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.helpToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.oAutorzeToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.helpToolStripMenuItem.Text = "Pomoc";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
            this.toolStripMenuItem2.Text = "Instrukcja";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // oAutorzeToolStripMenuItem
            // 
            this.oAutorzeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.oAutorzeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.oAutorzeToolStripMenuItem.Name = "oAutorzeToolStripMenuItem";
            this.oAutorzeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.oAutorzeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.oAutorzeToolStripMenuItem.Text = "O autorze";
            this.oAutorzeToolStripMenuItem.Click += new System.EventHandler(this.oAutorzeToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AutoUpgradeEnabled = false;
            this.openFileDialog1.FileName = "Tekst";
            this.openFileDialog1.Filter = "Pliki tekstowe|*txt";
            this.openFileDialog1.Title = "Wczytaj plik tekstowy";
            // 
            // labelczas
            // 
            this.labelczas.AutoSize = true;
            this.labelczas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelczas.ForeColor = System.Drawing.Color.Teal;
            this.labelczas.Location = new System.Drawing.Point(44, 62);
            this.labelczas.Name = "labelczas";
            this.labelczas.Size = new System.Drawing.Size(33, 32);
            this.labelczas.TabIndex = 4;
            this.labelczas.Text = "--";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(361, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ranking";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(32, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "CZAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelwynik);
            this.panel1.Controls.Add(this.labelczas);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 258);
            this.panel1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(14, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "ZMIEŃ CZAS:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(94, 113);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(25, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "WYNIK";
            // 
            // labelwynik
            // 
            this.labelwynik.AutoSize = true;
            this.labelwynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelwynik.ForeColor = System.Drawing.Color.Teal;
            this.labelwynik.Location = new System.Drawing.Point(44, 199);
            this.labelwynik.Name = "labelwynik";
            this.labelwynik.Size = new System.Drawing.Size(33, 32);
            this.labelwynik.TabIndex = 4;
            this.labelwynik.Text = "--";
            // 
            // zapis
            // 
            this.zapis.Location = new System.Drawing.Point(668, 290);
            this.zapis.Name = "zapis";
            this.zapis.Size = new System.Drawing.Size(164, 32);
            this.zapis.TabIndex = 9;
            this.zapis.Text = "Zapisz wynik";
            this.zapis.UseVisualStyleBackColor = true;
            this.zapis.Click += new System.EventHandler(this.zapis_Click);
            // 
            // wyrazyBox
            // 
            this.wyrazyBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.wyrazyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wyrazyBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.wyrazyBox.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyrazyBox.Location = new System.Drawing.Point(668, 65);
            this.wyrazyBox.Multiline = true;
            this.wyrazyBox.Name = "wyrazyBox";
            this.wyrazyBox.ReadOnly = true;
            this.wyrazyBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.wyrazyBox.Size = new System.Drawing.Size(164, 219);
            this.wyrazyBox.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(806, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelWyrazy
            // 
            this.labelWyrazy.BackColor = System.Drawing.Color.LimeGreen;
            this.labelWyrazy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelWyrazy.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWyrazy.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelWyrazy.Location = new System.Drawing.Point(190, 215);
            this.labelWyrazy.Name = "labelWyrazy";
            this.labelWyrazy.Size = new System.Drawing.Size(432, 32);
            this.labelWyrazy.TabIndex = 14;
            this.labelWyrazy.Text = "Wczytaj tekst (F2)";
            this.labelWyrazy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(11, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 326);
            this.panel2.TabIndex = 15;
            this.panel2.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkGreen;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(713, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 27);
            this.label7.TabIndex = 3;
            this.label7.Text = "Kontynuuj";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(148, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(466, 169);
            this.label6.TabIndex = 2;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(148, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(588, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Przedstawiam Ci aplikację, która nauczy Cię szybko pisać na klawiaturze. Życzę mi" +
    "łej zabawy. Pozdrawiam. Szymon Baran.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(391, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Witaj!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(385, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instrukcja:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ernest Hemingway \"Powrót żołnierza\" (fragment)",
            "Ernest Hemingway \"Powrót żołnierza\" (fragment)",
            "Ernest Hemingway \"Che ti dice la patria?\" (fragment)",
            "Ernest Hemingway \"W innej krainie\" (fragment)",
            "Alistair MacLean \"Przełęcz złamanego serca\" (fragment)",
            "Alistair MacLean \"Przełęcz złamanego serca\" (fragment)",
            "Alistair MacLean \"Przełęcz złamanego serca\" (fragment)",
            "M.K. Gandhi \"Autobiografia\" (fragment)",
            "Roman Polański \"Roman (autobiografia)\" (fragment)",
            "Roman Polański \"Roman (autobiografia)\" (fragment)",
            "Roman Polański \"Roman (autobiografia)\" (fragment)",
            "Roman Polański \"Roman (autobiografia)\" (fragment)",
            "Aldous Huxley \"Nowy wspaniały świat\" (fragment)",
            "Fragment opowiadania opartego na fabule gry Fallout, które kiedyś napisałem... ty" +
                "lko się nie śmiej ;)",
            "\"Secret Service Kompendium 1\" (fragment opowiadania)",
            "\"Secret Service Kompendium 1\" (fragment opowiadania)",
            "Tadeusz Dołęga Mostowicz \"Złota Maska\" (fragment)",
            "Juliusz Verne \"Tajemnicza Wyspa\" (fragment)",
            "Juliusz Verne \"Tajemnicza Wyspa\" (fragment)",
            "Juliusz Verne \"Tajemnicza Wyspa\" (fragment)",
            "Juliusz Verne \"Tajemnicza Wyspa\" (fragment)",
            "Juliusz Verne \"Tajemnicza Wyspa\" (fragment)",
            "Robert Punt \"Wolnoamerykanka\" (fragment)",
            "Robert Punt \"Wolnoamerykanka\" (fragment)",
            "Robert Punt \"Wolnoamerykanka\" (fragment)",
            "Nicholas Monsarrat \"Okrutne morze\" (fragment)",
            "Nicholas Monsarrat \"Okrutne morze\" (fragment)",
            "Nicholas Monsarrat \"Okrutne morze\" (fragment)",
            "Nicholas Monsarrat \"Okrutne morze\" (fragment)",
            "Nicholas Monsarrat \"Okrutne morze\" (fragment)"});
            this.comboBox1.Location = new System.Drawing.Point(195, 302);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(427, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Wybierz tekst";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(844, 372);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelWyrazy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wyrazyBox);
            this.Controls.Add(this.zapis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baran Szymon - Typing Expert";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelczas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem zobaczWynikiToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button zapis;
        private System.Windows.Forms.TextBox wyrazyBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelwynik;
        private System.Windows.Forms.Label labelWyrazy;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem oAutorzeToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;        
    }
}

