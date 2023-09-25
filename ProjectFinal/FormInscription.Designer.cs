namespace ProjectFinal
{
    partial class FormInscription
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLister = new System.Windows.Forms.Button();
            this.dgProgramme = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domaine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtHeures = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDomaine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEAffiche = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgEtudiant = new System.Windows.Forms.DataGridView();
            this.CodeE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeProgr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnERechercher = new System.Windows.Forms.Button();
            this.txtECodeChercher = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboProgCode = new System.Windows.Forms.ComboBox();
            this.btnEAjouter = new System.Windows.Forms.Button();
            this.btnEAnnuler = new System.Windows.Forms.Button();
            this.btnESupprimer = new System.Windows.Forms.Button();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCourriel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEPrenom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtENom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtECode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.programmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProgramme)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEtudiant)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(823, 453);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(815, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Programmes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.btnLister);
            this.panel1.Controls.Add(this.dgProgramme);
            this.panel1.Location = new System.Drawing.Point(366, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 378);
            this.panel1.TabIndex = 3;
            // 
            // btnLister
            // 
            this.btnLister.BackColor = System.Drawing.Color.Red;
            this.btnLister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLister.Location = new System.Drawing.Point(310, 304);
            this.btnLister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLister.Name = "btnLister";
            this.btnLister.Size = new System.Drawing.Size(123, 29);
            this.btnLister.TabIndex = 10;
            this.btnLister.Text = "&Lister";
            this.btnLister.UseVisualStyleBackColor = false;
            this.btnLister.Click += new System.EventHandler(this.BtnLister_Click);
            // 
            // dgProgramme
            // 
            this.dgProgramme.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgProgramme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProgramme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Domaine,
            this.Nom,
            this.Heures});
            this.dgProgramme.Location = new System.Drawing.Point(3, 3);
            this.dgProgramme.Name = "dgProgramme";
            this.dgProgramme.RowHeadersWidth = 51;
            this.dgProgramme.Size = new System.Drawing.Size(446, 238);
            this.dgProgramme.TabIndex = 1;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 125;
            // 
            // Domaine
            // 
            this.Domaine.HeaderText = "Domaine";
            this.Domaine.MinimumWidth = 6;
            this.Domaine.Name = "Domaine";
            this.Domaine.Width = 125;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // Heures
            // 
            this.Heures.HeaderText = "Nombres d\'heures";
            this.Heures.MinimumWidth = 6;
            this.Heures.Name = "Heures";
            this.Heures.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRechercher);
            this.groupBox2.Controls.Add(this.txtSearchId);
            this.groupBox2.Controls.Add(this.lblSearch);
            this.groupBox2.Location = new System.Drawing.Point(5, 283);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(336, 98);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supprimer";
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.Red;
            this.btnRechercher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRechercher.Location = new System.Drawing.Point(226, 63);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(106, 31);
            this.btnRechercher.TabIndex = 9;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(146, 22);
            this.txtSearchId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(181, 24);
            this.txtSearchId.TabIndex = 8;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(23, 28);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(119, 18);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Chercher (par id)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.txtHeures);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDomaine);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSupprimer.Location = new System.Drawing.Point(14, 201);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(93, 30);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Red;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnnuler.Location = new System.Drawing.Point(120, 201);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(99, 32);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "&Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Red;
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouter.Location = new System.Drawing.Point(225, 201);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(101, 32);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // txtHeures
            // 
            this.txtHeures.Location = new System.Drawing.Point(158, 163);
            this.txtHeures.Name = "txtHeures";
            this.txtHeures.Size = new System.Drawing.Size(173, 24);
            this.txtHeures.TabIndex = 4;
            this.txtHeures.Validating += new System.ComponentModel.CancelEventHandler(this.txtHeures_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombres d\'heures";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(158, 121);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(173, 24);
            this.txtNom.TabIndex = 3;
            this.txtNom.Validating += new System.ComponentModel.CancelEventHandler(this.txtNom_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nom du programme";
            // 
            // txtDomaine
            // 
            this.txtDomaine.Location = new System.Drawing.Point(158, 82);
            this.txtDomaine.Name = "txtDomaine";
            this.txtDomaine.Size = new System.Drawing.Size(173, 24);
            this.txtDomaine.TabIndex = 2;
            this.txtDomaine.Validating += new System.ComponentModel.CancelEventHandler(this.txtDomaine_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Domaine";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(158, 37);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(173, 24);
            this.txtCode.TabIndex = 1;
            this.txtCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtCode_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code du Programme";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(815, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Etudiant";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEAffiche);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dgEtudiant);
            this.panel2.Location = new System.Drawing.Point(387, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 383);
            this.panel2.TabIndex = 4;
            // 
            // btnEAffiche
            // 
            this.btnEAffiche.Location = new System.Drawing.Point(18, 329);
            this.btnEAffiche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEAffiche.Name = "btnEAffiche";
            this.btnEAffiche.Size = new System.Drawing.Size(63, 33);
            this.btnEAffiche.TabIndex = 2;
            this.btnEAffiche.Text = "&Lister";
            this.btnEAffiche.UseVisualStyleBackColor = true;
            this.btnEAffiche.Click += new System.EventHandler(this.btnEAffiche_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(95, 317);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 54);
            this.panel3.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(245, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 30);
            this.button4.TabIndex = 0;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = ">>";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgEtudiant
            // 
            this.dgEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEtudiant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeE,
            this.NomE,
            this.PrenomE,
            this.Naissance,
            this.CodeProgr});
            this.dgEtudiant.Location = new System.Drawing.Point(8, 14);
            this.dgEtudiant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgEtudiant.Name = "dgEtudiant";
            this.dgEtudiant.RowHeadersWidth = 51;
            this.dgEtudiant.RowTemplate.Height = 24;
            this.dgEtudiant.Size = new System.Drawing.Size(392, 299);
            this.dgEtudiant.TabIndex = 0;
            // 
            // CodeE
            // 
            this.CodeE.HeaderText = "Code";
            this.CodeE.MinimumWidth = 6;
            this.CodeE.Name = "CodeE";
            this.CodeE.Width = 125;
            // 
            // NomE
            // 
            this.NomE.HeaderText = "Nom";
            this.NomE.MinimumWidth = 6;
            this.NomE.Name = "NomE";
            this.NomE.Width = 125;
            // 
            // PrenomE
            // 
            this.PrenomE.HeaderText = "Prenom";
            this.PrenomE.MinimumWidth = 6;
            this.PrenomE.Name = "PrenomE";
            this.PrenomE.Width = 125;
            // 
            // Naissance
            // 
            this.Naissance.HeaderText = "Date Naissance";
            this.Naissance.MinimumWidth = 6;
            this.Naissance.Name = "Naissance";
            this.Naissance.Width = 125;
            // 
            // CodeProgr
            // 
            this.CodeProgr.HeaderText = "Code programme transcrit";
            this.CodeProgr.MinimumWidth = 6;
            this.CodeProgr.Name = "CodeProgr";
            this.CodeProgr.Width = 125;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnERechercher);
            this.groupBox4.Controls.Add(this.txtECodeChercher);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(5, 303);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(367, 98);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Supprimer";
            // 
            // btnERechercher
            // 
            this.btnERechercher.Location = new System.Drawing.Point(199, 58);
            this.btnERechercher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnERechercher.Name = "btnERechercher";
            this.btnERechercher.Size = new System.Drawing.Size(96, 28);
            this.btnERechercher.TabIndex = 11;
            this.btnERechercher.Text = "&Rechercher";
            this.btnERechercher.UseVisualStyleBackColor = true;
            // 
            // txtECodeChercher
            // 
            this.txtECodeChercher.Location = new System.Drawing.Point(166, 21);
            this.txtECodeChercher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtECodeChercher.Name = "txtECodeChercher";
            this.txtECodeChercher.Size = new System.Drawing.Size(181, 24);
            this.txtECodeChercher.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 28);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Chercher (par id)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboProgCode);
            this.groupBox3.Controls.Add(this.btnEAjouter);
            this.groupBox3.Controls.Add(this.btnEAnnuler);
            this.groupBox3.Controls.Add(this.btnESupprimer);
            this.groupBox3.Controls.Add(this.dtpNaissance);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtCourriel);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtEPrenom);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtENom);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtECode);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(10, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(362, 288);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Record";
            this.groupBox3.UseCompatibleTextRendering = true;
            // 
            // cboProgCode
            // 
            this.cboProgCode.FormattingEnabled = true;
            this.cboProgCode.Location = new System.Drawing.Point(194, 198);
            this.cboProgCode.Name = "cboProgCode";
            this.cboProgCode.Size = new System.Drawing.Size(148, 26);
            this.cboProgCode.TabIndex = 6;
            this.cboProgCode.SelectedIndexChanged += new System.EventHandler(this.cboProgCode_SelectedIndexChanged);
            // 
            // btnEAjouter
            // 
            this.btnEAjouter.Location = new System.Drawing.Point(261, 238);
            this.btnEAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEAjouter.Name = "btnEAjouter";
            this.btnEAjouter.Size = new System.Drawing.Size(81, 30);
            this.btnEAjouter.TabIndex = 7;
            this.btnEAjouter.Text = "&Ajouter";
            this.btnEAjouter.UseVisualStyleBackColor = true;
            this.btnEAjouter.Click += new System.EventHandler(this.btnEAjouter_Click);
            // 
            // btnEAnnuler
            // 
            this.btnEAnnuler.Location = new System.Drawing.Point(153, 238);
            this.btnEAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEAnnuler.Name = "btnEAnnuler";
            this.btnEAnnuler.Size = new System.Drawing.Size(81, 30);
            this.btnEAnnuler.TabIndex = 9;
            this.btnEAnnuler.Text = "&Annuler";
            this.btnEAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnESupprimer
            // 
            this.btnESupprimer.Location = new System.Drawing.Point(21, 238);
            this.btnESupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnESupprimer.Name = "btnESupprimer";
            this.btnESupprimer.Size = new System.Drawing.Size(96, 30);
            this.btnESupprimer.TabIndex = 8;
            this.btnESupprimer.Text = "&Supprimer";
            this.btnESupprimer.UseVisualStyleBackColor = true;
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Location = new System.Drawing.Point(194, 132);
            this.dtpNaissance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(148, 24);
            this.dtpNaissance.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(29, 186);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 50);
            this.label10.TabIndex = 0;
            this.label10.Text = "Code du programme transcrit";
            // 
            // txtCourriel
            // 
            this.txtCourriel.Location = new System.Drawing.Point(194, 160);
            this.txtCourriel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourriel.Name = "txtCourriel";
            this.txtCourriel.Size = new System.Drawing.Size(148, 24);
            this.txtCourriel.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 137);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Date Naissance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Courriel";
            // 
            // txtEPrenom
            // 
            this.txtEPrenom.Location = new System.Drawing.Point(194, 104);
            this.txtEPrenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEPrenom.Name = "txtEPrenom";
            this.txtEPrenom.Size = new System.Drawing.Size(148, 24);
            this.txtEPrenom.TabIndex = 3;
            this.txtEPrenom.TextChanged += new System.EventHandler(this.txtEPrenom_TextChanged);
            this.txtEPrenom.Validated += new System.EventHandler(this.txtEPrenom_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Prénom de l\'étudiant";
            // 
            // txtENom
            // 
            this.txtENom.Location = new System.Drawing.Point(194, 76);
            this.txtENom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtENom.Name = "txtENom";
            this.txtENom.Size = new System.Drawing.Size(148, 24);
            this.txtENom.TabIndex = 2;
            this.txtENom.TextChanged += new System.EventHandler(this.TxtENom_TextChanged);
            this.txtENom.Validating += new System.ComponentModel.CancelEventHandler(this.txtENom_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 76);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nom de l\'étudiant";
            // 
            // txtECode
            // 
            this.txtECode.Location = new System.Drawing.Point(194, 38);
            this.txtECode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtECode.Name = "txtECode";
            this.txtECode.Size = new System.Drawing.Size(148, 24);
            this.txtECode.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Code de l\'étudiant";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(213, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inscriptions Collège";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectFinal.Properties.Resources.logo_rosemont;
            this.pictureBox1.Location = new System.Drawing.Point(651, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(54, 303);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 11;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // FormInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(840, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormInscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscriptions Collége ";
            this.Load += new System.EventHandler(this.FormInscription_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProgramme)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEtudiant)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHeures;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDomaine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgProgramme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domaine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Heures;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnLister;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCourriel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEPrenom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtENom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtECode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEAjouter;
        private System.Windows.Forms.Button btnEAnnuler;
        private System.Windows.Forms.Button btnESupprimer;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnERechercher;
        private System.Windows.Forms.TextBox txtECodeChercher;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProgr;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboProgCode;
        private System.Windows.Forms.BindingSource programmeBindingSource;
        private System.Windows.Forms.Button btnEAffiche;
        private System.Windows.Forms.Button BtnRefresh;
    }
}

