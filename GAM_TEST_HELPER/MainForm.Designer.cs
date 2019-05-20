namespace GAM_TEST_HELPER
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bCopier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomFichier = new System.Windows.Forms.TextBox();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomFonction = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNumeroFonction = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudNumeroCas = new System.Windows.Forms.NumericUpDown();
            this.tbTypeFichierBinaire = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDeclarationParametres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbParametres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbFonction = new System.Windows.Forms.GroupBox();
            this.pPanel = new System.Windows.Forms.Panel();
            this.dgvValidationSortie = new System.Windows.Forms.DataGridView();
            this.Expected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.bGenererAjouter = new System.Windows.Forms.Button();
            this.gbCode = new System.Windows.Forms.GroupBox();
            this.tbCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTemplate = new System.Windows.Forms.ComboBox();
            this.bMinimize = new System.Windows.Forms.Button();
            this.bGenerer = new System.Windows.Forms.Button();
            this.pButtons = new System.Windows.Forms.Panel();
            this.scContainer = new System.Windows.Forms.SplitContainer();
            this.cbTop = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerUnTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterCommeTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developpéParYassinLOKHATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFonction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCas)).BeginInit();
            this.gbFonction.SuspendLayout();
            this.pPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidationSortie)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCode)).BeginInit();
            this.pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).BeginInit();
            this.scContainer.Panel1.SuspendLayout();
            this.scContainer.Panel2.SuspendLayout();
            this.scContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCopier
            // 
            this.bCopier.Location = new System.Drawing.Point(0, 0);
            this.bCopier.Name = "bCopier";
            this.bCopier.Size = new System.Drawing.Size(109, 23);
            this.bCopier.TabIndex = 110;
            this.bCopier.Text = "Copier et Minimiser";
            this.bCopier.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fichier :";
            // 
            // tbNomFichier
            // 
            this.tbNomFichier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbNomFichier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNomFichier.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomFichier.Location = new System.Drawing.Point(56, 22);
            this.tbNomFichier.Name = "tbNomFichier";
            this.tbNomFichier.Size = new System.Drawing.Size(48, 20);
            this.tbNomFichier.TabIndex = 10;
            // 
            // tbVersion
            // 
            this.tbVersion.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVersion.Location = new System.Drawing.Point(172, 22);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(48, 20);
            this.tbVersion.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Version :";
            // 
            // tbNomFonction
            // 
            this.tbNomFonction.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomFonction.Location = new System.Drawing.Point(6, 49);
            this.tbNomFonction.Name = "tbNomFonction";
            this.tbNomFonction.Size = new System.Drawing.Size(211, 20);
            this.tbNomFonction.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom de la Fonction :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Num Fonc :";
            // 
            // nudNumeroFonction
            // 
            this.nudNumeroFonction.Location = new System.Drawing.Point(71, 5);
            this.nudNumeroFonction.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNumeroFonction.Name = "nudNumeroFonction";
            this.nudNumeroFonction.Size = new System.Drawing.Size(35, 20);
            this.nudNumeroFonction.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Num Cas :";
            // 
            // nudNumeroCas
            // 
            this.nudNumeroCas.Location = new System.Drawing.Point(181, 5);
            this.nudNumeroCas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNumeroCas.Name = "nudNumeroCas";
            this.nudNumeroCas.Size = new System.Drawing.Size(35, 20);
            this.nudNumeroCas.TabIndex = 50;
            // 
            // tbTypeFichierBinaire
            // 
            this.tbTypeFichierBinaire.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTypeFichierBinaire.Location = new System.Drawing.Point(9, 65);
            this.tbTypeFichierBinaire.Name = "tbTypeFichierBinaire";
            this.tbTypeFichierBinaire.Size = new System.Drawing.Size(211, 20);
            this.tbTypeFichierBinaire.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Type de Fichier Binaire :";
            // 
            // tbDeclarationParametres
            // 
            this.tbDeclarationParametres.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeclarationParametres.Location = new System.Drawing.Point(6, 92);
            this.tbDeclarationParametres.Multiline = true;
            this.tbDeclarationParametres.Name = "tbDeclarationParametres";
            this.tbDeclarationParametres.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDeclarationParametres.Size = new System.Drawing.Size(211, 93);
            this.tbDeclarationParametres.TabIndex = 70;
            this.tbDeclarationParametres.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(480, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Code de déclaration et Init des Param Locals (Ne pas déclarer les Comptes Rendus " +
    "et les Contexts) :";
            // 
            // tbParametres
            // 
            this.tbParametres.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbParametres.Location = new System.Drawing.Point(6, 15);
            this.tbParametres.Multiline = true;
            this.tbParametres.Name = "tbParametres";
            this.tbParametres.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbParametres.Size = new System.Drawing.Size(211, 90);
            this.tbParametres.TabIndex = 80;
            this.tbParametres.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Paramètres de la Fonction  à tester :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Validation de Sortie :";
            // 
            // gbFonction
            // 
            this.gbFonction.Controls.Add(this.pPanel);
            this.gbFonction.Controls.Add(this.panel1);
            this.gbFonction.Location = new System.Drawing.Point(10, 127);
            this.gbFonction.Name = "gbFonction";
            this.gbFonction.Size = new System.Drawing.Size(232, 430);
            this.gbFonction.TabIndex = 20;
            this.gbFonction.TabStop = false;
            this.gbFonction.Text = "Fonction";
            // 
            // pPanel
            // 
            this.pPanel.Controls.Add(this.dgvValidationSortie);
            this.pPanel.Controls.Add(this.label8);
            this.pPanel.Controls.Add(this.tbParametres);
            this.pPanel.Controls.Add(this.label9);
            this.pPanel.Location = new System.Drawing.Point(3, 207);
            this.pPanel.Name = "pPanel";
            this.pPanel.Size = new System.Drawing.Size(217, 220);
            this.pPanel.TabIndex = 122;
            // 
            // dgvValidationSortie
            // 
            this.dgvValidationSortie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvValidationSortie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvValidationSortie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvValidationSortie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvValidationSortie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValidationSortie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Expected,
            this.Actual});
            this.dgvValidationSortie.Location = new System.Drawing.Point(6, 124);
            this.dgvValidationSortie.Name = "dgvValidationSortie";
            this.dgvValidationSortie.ShowEditingIcon = false;
            this.dgvValidationSortie.Size = new System.Drawing.Size(211, 95);
            this.dgvValidationSortie.TabIndex = 121;
            // 
            // Expected
            // 
            this.Expected.HeaderText = "Expected";
            this.Expected.Name = "Expected";
            // 
            // Actual
            // 
            this.Actual.HeaderText = "Actual";
            this.Actual.Name = "Actual";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nudNumeroFonction);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbDeclarationParametres);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nudNumeroCas);
            this.panel1.Controls.Add(this.tbNomFonction);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 411);
            this.panel1.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNomFichier);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbVersion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbTypeFichierBinaire);
            this.groupBox1.Location = new System.Drawing.Point(10, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 91);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fichier";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "UNIT_TEST_HELPER";
            this.notifyIcon.Visible = true;
            // 
            // bGenererAjouter
            // 
            this.bGenererAjouter.Location = new System.Drawing.Point(115, 29);
            this.bGenererAjouter.Name = "bGenererAjouter";
            this.bGenererAjouter.Size = new System.Drawing.Size(112, 23);
            this.bGenererAjouter.TabIndex = 100;
            this.bGenererAjouter.Text = "Générer et Ajouter";
            this.bGenererAjouter.UseVisualStyleBackColor = true;
            // 
            // gbCode
            // 
            this.gbCode.Controls.Add(this.tbCode);
            this.gbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCode.Location = new System.Drawing.Point(0, 0);
            this.gbCode.Name = "gbCode";
            this.gbCode.Size = new System.Drawing.Size(454, 611);
            this.gbCode.TabIndex = 102;
            this.gbCode.TabStop = false;
            this.gbCode.Text = "Code";
            // 
            // tbCode
            // 
            this.tbCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.tbCode.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.tbCode.BackBrush = null;
            this.tbCode.CharHeight = 14;
            this.tbCode.CharWidth = 8;
            this.tbCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCode.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.tbCode.IsReplaceMode = false;
            this.tbCode.Location = new System.Drawing.Point(3, 16);
            this.tbCode.Name = "tbCode";
            this.tbCode.Paddings = new System.Windows.Forms.Padding(0);
            this.tbCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tbCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("tbCode.ServiceColors")));
            this.tbCode.Size = new System.Drawing.Size(448, 592);
            this.tbCode.TabIndex = 121;
            this.tbCode.Zoom = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Template :";
            // 
            // cbTemplate
            // 
            this.cbTemplate.FormattingEnabled = true;
            this.cbTemplate.Location = new System.Drawing.Point(159, 3);
            this.cbTemplate.Name = "cbTemplate";
            this.cbTemplate.Size = new System.Drawing.Size(81, 21);
            this.cbTemplate.TabIndex = 5;
            // 
            // bMinimize
            // 
            this.bMinimize.Location = new System.Drawing.Point(0, 29);
            this.bMinimize.Name = "bMinimize";
            this.bMinimize.Size = new System.Drawing.Size(109, 23);
            this.bMinimize.TabIndex = 120;
            this.bMinimize.Text = "Minimiser";
            this.bMinimize.UseVisualStyleBackColor = true;
            // 
            // bGenerer
            // 
            this.bGenerer.Location = new System.Drawing.Point(115, 0);
            this.bGenerer.Name = "bGenerer";
            this.bGenerer.Size = new System.Drawing.Size(112, 23);
            this.bGenerer.TabIndex = 121;
            this.bGenerer.Text = "Nettoyer et Générer";
            this.bGenerer.UseVisualStyleBackColor = true;
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.bCopier);
            this.pButtons.Controls.Add(this.bGenerer);
            this.pButtons.Controls.Add(this.bGenererAjouter);
            this.pButtons.Controls.Add(this.bMinimize);
            this.pButtons.Location = new System.Drawing.Point(10, 558);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(227, 52);
            this.pButtons.TabIndex = 122;
            // 
            // scContainer
            // 
            this.scContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContainer.Location = new System.Drawing.Point(0, 24);
            this.scContainer.Name = "scContainer";
            // 
            // scContainer.Panel1
            // 
            this.scContainer.Panel1.Controls.Add(this.cbTop);
            this.scContainer.Panel1.Controls.Add(this.label10);
            this.scContainer.Panel1.Controls.Add(this.pButtons);
            this.scContainer.Panel1.Controls.Add(this.groupBox1);
            this.scContainer.Panel1.Controls.Add(this.cbTemplate);
            this.scContainer.Panel1.Controls.Add(this.gbFonction);
            this.scContainer.Panel1MinSize = 323;
            // 
            // scContainer.Panel2
            // 
            this.scContainer.Panel2.Controls.Add(this.gbCode);
            this.scContainer.Panel2MinSize = 65;
            this.scContainer.Size = new System.Drawing.Size(784, 613);
            this.scContainer.SplitterDistance = 323;
            this.scContainer.SplitterWidth = 5;
            this.scContainer.TabIndex = 123;
            // 
            // cbTop
            // 
            this.cbTop.AutoSize = true;
            this.cbTop.Checked = true;
            this.cbTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTop.Location = new System.Drawing.Point(10, 5);
            this.cbTop.Name = "cbTop";
            this.cbTop.Size = new System.Drawing.Size(84, 17);
            this.cbTop.TabIndex = 3;
            this.cbTop.Text = "Premier plan";
            this.cbTop.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.developpéParYassinLOKHATToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 124;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem,
            this.importerUnTemplateToolStripMenuItem,
            this.exporterCommeTemplateToolStripMenuItem,
            this.minimiserToolStripMenuItem,
            this.fermerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.enregistrerSousToolStripMenuItem.Text = "Enregistrer sous";
            this.enregistrerSousToolStripMenuItem.Click += new System.EventHandler(this.enregistrerSousToolStripMenuItem_Click);
            // 
            // importerUnTemplateToolStripMenuItem
            // 
            this.importerUnTemplateToolStripMenuItem.Name = "importerUnTemplateToolStripMenuItem";
            this.importerUnTemplateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.importerUnTemplateToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.importerUnTemplateToolStripMenuItem.Text = "Importer un template";
            this.importerUnTemplateToolStripMenuItem.Click += new System.EventHandler(this.importerUnTemplateToolStripMenuItem_Click);
            // 
            // exporterCommeTemplateToolStripMenuItem
            // 
            this.exporterCommeTemplateToolStripMenuItem.Name = "exporterCommeTemplateToolStripMenuItem";
            this.exporterCommeTemplateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.exporterCommeTemplateToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.exporterCommeTemplateToolStripMenuItem.Text = "Exporter comme template";
            this.exporterCommeTemplateToolStripMenuItem.Click += new System.EventHandler(this.exporterCommeTemplateToolStripMenuItem_Click);
            // 
            // minimiserToolStripMenuItem
            // 
            this.minimiserToolStripMenuItem.Name = "minimiserToolStripMenuItem";
            this.minimiserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.minimiserToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.minimiserToolStripMenuItem.Text = "Minimiser";
            this.minimiserToolStripMenuItem.Click += new System.EventHandler(this.BMinimize_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.fermerToolStripMenuItem.Text = "Quitter";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // developpéParYassinLOKHATToolStripMenuItem
            // 
            this.developpéParYassinLOKHATToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.developpéParYassinLOKHATToolStripMenuItem.Name = "developpéParYassinLOKHATToolStripMenuItem";
            this.developpéParYassinLOKHATToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.developpéParYassinLOKHATToolStripMenuItem.Text = "Developpé par Yassin LOKHAT";
            this.developpéParYassinLOKHATToolStripMenuItem.Click += new System.EventHandler(this.developpéParYassinLOKHATToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 637);
            this.Controls.Add(this.scContainer);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(502, 601);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UNIT_TEST_HELPER";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroFonction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroCas)).EndInit();
            this.gbFonction.ResumeLayout(false);
            this.pPanel.ResumeLayout(false);
            this.pPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidationSortie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCode)).EndInit();
            this.pButtons.ResumeLayout(false);
            this.scContainer.Panel1.ResumeLayout(false);
            this.scContainer.Panel1.PerformLayout();
            this.scContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).EndInit();
            this.scContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCopier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomFichier;
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomFonction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNumeroFonction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudNumeroCas;
        private System.Windows.Forms.TextBox tbTypeFichierBinaire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDeclarationParametres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbParametres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbFonction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button bGenererAjouter;
        private System.Windows.Forms.GroupBox gbCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTemplate;
        private System.Windows.Forms.Button bMinimize;
        private System.Windows.Forms.Button bGenerer;
        private System.Windows.Forms.DataGridView dgvValidationSortie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actual;
        private FastColoredTextBoxNS.FastColoredTextBox tbCode;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Panel pPanel;
        private System.Windows.Forms.SplitContainer scContainer;
        private System.Windows.Forms.CheckBox cbTop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerUnTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterCommeTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developpéParYassinLOKHATToolStripMenuItem;
    }
}

