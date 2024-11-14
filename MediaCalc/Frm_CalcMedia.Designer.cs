namespace MediaCalc
{
    partial class Frm_CalcMedia
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_M1 = new System.Windows.Forms.Label();
            this.lbl_med = new System.Windows.Forms.Label();
            this.lbl_Media = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_discip = new System.Windows.Forms.Label();
            this.txt_discip = new System.Windows.Forms.TextBox();
            this.lbl_serie = new System.Windows.Forms.Label();
            this.cmb_serie = new System.Windows.Forms.ComboBox();
            this.lbl_professor = new System.Windows.Forms.Label();
            this.txt_professor = new System.Windows.Forms.TextBox();
            this.lbl_1B = new System.Windows.Forms.Label();
            this.lbl_nt1 = new System.Windows.Forms.Label();
            this.lbl_pt1 = new System.Windows.Forms.Label();
            this.txt_pt1 = new System.Windows.Forms.TextBox();
            this.txt_nt1 = new System.Windows.Forms.TextBox();
            this.lbl_pp1 = new System.Windows.Forms.Label();
            this.lbl_np1 = new System.Windows.Forms.Label();
            this.txt_pp1 = new System.Windows.Forms.TextBox();
            this.txt_np1 = new System.Windows.Forms.TextBox();
            this.txt_pp2 = new System.Windows.Forms.TextBox();
            this.txt_np2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pt2 = new System.Windows.Forms.TextBox();
            this.txt_nt2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_M2 = new System.Windows.Forms.Label();
            this.txt_pp3 = new System.Windows.Forms.TextBox();
            this.txt_np3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pt3 = new System.Windows.Forms.TextBox();
            this.txt_nt3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_M3 = new System.Windows.Forms.Label();
            this.txt_pp4 = new System.Windows.Forms.TextBox();
            this.txt_np4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pt4 = new System.Windows.Forms.TextBox();
            this.txt_nt4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_M4 = new System.Windows.Forms.Label();
            this.lbl_alt_media = new System.Windows.Forms.Label();
            this.chk_alterar_media = new System.Windows.Forms.CheckBox();
            this.txt_NomeArq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_M1
            // 
            this.lbl_M1.AutoSize = true;
            this.lbl_M1.Location = new System.Drawing.Point(455, 173);
            this.lbl_M1.Name = "lbl_M1";
            this.lbl_M1.Size = new System.Drawing.Size(109, 13);
            this.lbl_M1.TabIndex = 5;
            this.lbl_M1.Text = "Média do 1º bimestre:";
            // 
            // lbl_med
            // 
            this.lbl_med.AutoSize = true;
            this.lbl_med.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_med.Location = new System.Drawing.Point(241, 508);
            this.lbl_med.Name = "lbl_med";
            this.lbl_med.Size = new System.Drawing.Size(129, 24);
            this.lbl_med.TabIndex = 9;
            this.lbl_med.Text = "Média anual:";
            // 
            // lbl_Media
            // 
            this.lbl_Media.AutoSize = true;
            this.lbl_Media.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Media.Location = new System.Drawing.Point(398, 508);
            this.lbl_Media.Name = "lbl_Media";
            this.lbl_Media.Size = new System.Drawing.Size(40, 24);
            this.lbl_Media.TabIndex = 10;
            this.lbl_Media.Text = "X,x";
            this.lbl_Media.Visible = false;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(342, 548);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(96, 23);
            this.btn_calcular.TabIndex = 11;
            this.btn_calcular.Text = "Calcular Média";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(342, 577);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(96, 23);
            this.btn_gravar.TabIndex = 12;
            this.btn_gravar.Text = "Cadastrar aluno";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // sfdSave
            // 
            this.sfdSave.DefaultExt = "txt";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_nome.Location = new System.Drawing.Point(33, 33);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(82, 13);
            this.lbl_nome.TabIndex = 13;
            this.lbl_nome.Text = "Nome do aluno:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(192, 30);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 14;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // lbl_discip
            // 
            this.lbl_discip.AutoSize = true;
            this.lbl_discip.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_discip.Location = new System.Drawing.Point(32, 57);
            this.lbl_discip.Name = "lbl_discip";
            this.lbl_discip.Size = new System.Drawing.Size(55, 13);
            this.lbl_discip.TabIndex = 15;
            this.lbl_discip.Text = "Disciplina:";
            // 
            // txt_discip
            // 
            this.txt_discip.Location = new System.Drawing.Point(192, 54);
            this.txt_discip.Name = "txt_discip";
            this.txt_discip.Size = new System.Drawing.Size(100, 20);
            this.txt_discip.TabIndex = 16;
            this.txt_discip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discip_KeyPress);
            // 
            // lbl_serie
            // 
            this.lbl_serie.AutoSize = true;
            this.lbl_serie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_serie.Location = new System.Drawing.Point(338, 33);
            this.lbl_serie.Name = "lbl_serie";
            this.lbl_serie.Size = new System.Drawing.Size(81, 13);
            this.lbl_serie.TabIndex = 17;
            this.lbl_serie.Text = "Série cursando:";
            // 
            // cmb_serie
            // 
            this.cmb_serie.FormattingEnabled = true;
            this.cmb_serie.Items.AddRange(new object[] {
            "1º Ano",
            "2º Ano",
            "3º Ano",
            "4º Ano"});
            this.cmb_serie.Location = new System.Drawing.Point(498, 30);
            this.cmb_serie.Name = "cmb_serie";
            this.cmb_serie.Size = new System.Drawing.Size(100, 21);
            this.cmb_serie.TabIndex = 18;
            this.cmb_serie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_serie_KeyPress);
            // 
            // lbl_professor
            // 
            this.lbl_professor.AutoSize = true;
            this.lbl_professor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_professor.Location = new System.Drawing.Point(339, 59);
            this.lbl_professor.Name = "lbl_professor";
            this.lbl_professor.Size = new System.Drawing.Size(54, 13);
            this.lbl_professor.TabIndex = 19;
            this.lbl_professor.Text = "Professor:";
            // 
            // txt_professor
            // 
            this.txt_professor.Location = new System.Drawing.Point(498, 56);
            this.txt_professor.Name = "txt_professor";
            this.txt_professor.Size = new System.Drawing.Size(100, 20);
            this.txt_professor.TabIndex = 20;
            this.txt_professor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_professor_KeyPress);
            // 
            // lbl_1B
            // 
            this.lbl_1B.AutoSize = true;
            this.lbl_1B.Location = new System.Drawing.Point(33, 173);
            this.lbl_1B.Name = "lbl_1B";
            this.lbl_1B.Size = new System.Drawing.Size(60, 13);
            this.lbl_1B.TabIndex = 21;
            this.lbl_1B.Text = "1º Bimestre";
            this.lbl_1B.Click += new System.EventHandler(this.lbl_1B_Click);
            // 
            // lbl_nt1
            // 
            this.lbl_nt1.AutoSize = true;
            this.lbl_nt1.Location = new System.Drawing.Point(121, 172);
            this.lbl_nt1.Name = "lbl_nt1";
            this.lbl_nt1.Size = new System.Drawing.Size(99, 13);
            this.lbl_nt1.TabIndex = 25;
            this.lbl_nt1.Text = "Nota dos trabalhos:";
            // 
            // lbl_pt1
            // 
            this.lbl_pt1.AutoSize = true;
            this.lbl_pt1.Location = new System.Drawing.Point(120, 196);
            this.lbl_pt1.Name = "lbl_pt1";
            this.lbl_pt1.Size = new System.Drawing.Size(100, 13);
            this.lbl_pt1.TabIndex = 29;
            this.lbl_pt1.Text = "Peso dos trabalhos:";
            // 
            // txt_pt1
            // 
            this.txt_pt1.Location = new System.Drawing.Point(226, 190);
            this.txt_pt1.Name = "txt_pt1";
            this.txt_pt1.Size = new System.Drawing.Size(32, 20);
            this.txt_pt1.TabIndex = 31;
            // 
            // txt_nt1
            // 
            this.txt_nt1.Location = new System.Drawing.Point(226, 166);
            this.txt_nt1.Name = "txt_nt1";
            this.txt_nt1.Size = new System.Drawing.Size(32, 20);
            this.txt_nt1.TabIndex = 30;
            this.txt_nt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nt1_KeyPress);
            // 
            // lbl_pp1
            // 
            this.lbl_pp1.AutoSize = true;
            this.lbl_pp1.Location = new System.Drawing.Point(281, 196);
            this.lbl_pp1.Name = "lbl_pp1";
            this.lbl_pp1.Size = new System.Drawing.Size(86, 13);
            this.lbl_pp1.TabIndex = 33;
            this.lbl_pp1.Text = "Peso das provas";
            // 
            // lbl_np1
            // 
            this.lbl_np1.AutoSize = true;
            this.lbl_np1.Location = new System.Drawing.Point(282, 172);
            this.lbl_np1.Name = "lbl_np1";
            this.lbl_np1.Size = new System.Drawing.Size(88, 13);
            this.lbl_np1.TabIndex = 32;
            this.lbl_np1.Text = "Nota das provas:";
            // 
            // txt_pp1
            // 
            this.txt_pp1.Location = new System.Drawing.Point(388, 193);
            this.txt_pp1.Name = "txt_pp1";
            this.txt_pp1.Size = new System.Drawing.Size(32, 20);
            this.txt_pp1.TabIndex = 35;
            // 
            // txt_np1
            // 
            this.txt_np1.Location = new System.Drawing.Point(388, 169);
            this.txt_np1.Name = "txt_np1";
            this.txt_np1.Size = new System.Drawing.Size(32, 20);
            this.txt_np1.TabIndex = 34;
            // 
            // txt_pp2
            // 
            this.txt_pp2.Location = new System.Drawing.Point(388, 277);
            this.txt_pp2.Name = "txt_pp2";
            this.txt_pp2.Size = new System.Drawing.Size(32, 20);
            this.txt_pp2.TabIndex = 45;
            // 
            // txt_np2
            // 
            this.txt_np2.Location = new System.Drawing.Point(388, 253);
            this.txt_np2.Name = "txt_np2";
            this.txt_np2.Size = new System.Drawing.Size(32, 20);
            this.txt_np2.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Peso das provas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Nota das provas:";
            // 
            // txt_pt2
            // 
            this.txt_pt2.Location = new System.Drawing.Point(226, 274);
            this.txt_pt2.Name = "txt_pt2";
            this.txt_pt2.Size = new System.Drawing.Size(32, 20);
            this.txt_pt2.TabIndex = 41;
            // 
            // txt_nt2
            // 
            this.txt_nt2.Location = new System.Drawing.Point(226, 250);
            this.txt_nt2.Name = "txt_nt2";
            this.txt_nt2.Size = new System.Drawing.Size(32, 20);
            this.txt_nt2.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Peso dos trabalhos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Nota dos trabalhos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "2º Bimestre";
            // 
            // lbl_M2
            // 
            this.lbl_M2.AutoSize = true;
            this.lbl_M2.Location = new System.Drawing.Point(455, 257);
            this.lbl_M2.Name = "lbl_M2";
            this.lbl_M2.Size = new System.Drawing.Size(109, 13);
            this.lbl_M2.TabIndex = 36;
            this.lbl_M2.Text = "Média do 2º bimestre:";
            // 
            // txt_pp3
            // 
            this.txt_pp3.Location = new System.Drawing.Point(388, 363);
            this.txt_pp3.Name = "txt_pp3";
            this.txt_pp3.Size = new System.Drawing.Size(32, 20);
            this.txt_pp3.TabIndex = 55;
            // 
            // txt_np3
            // 
            this.txt_np3.Location = new System.Drawing.Point(388, 339);
            this.txt_np3.Name = "txt_np3";
            this.txt_np3.Size = new System.Drawing.Size(32, 20);
            this.txt_np3.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Peso das provas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Nota das provas:";
            // 
            // txt_pt3
            // 
            this.txt_pt3.Location = new System.Drawing.Point(226, 360);
            this.txt_pt3.Name = "txt_pt3";
            this.txt_pt3.Size = new System.Drawing.Size(32, 20);
            this.txt_pt3.TabIndex = 51;
            // 
            // txt_nt3
            // 
            this.txt_nt3.Location = new System.Drawing.Point(226, 336);
            this.txt_nt3.Name = "txt_nt3";
            this.txt_nt3.Size = new System.Drawing.Size(32, 20);
            this.txt_nt3.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Peso dos trabalhos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(121, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Nota dos trabalhos:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "3º Bimestre";
            // 
            // lbl_M3
            // 
            this.lbl_M3.AutoSize = true;
            this.lbl_M3.Location = new System.Drawing.Point(455, 343);
            this.lbl_M3.Name = "lbl_M3";
            this.lbl_M3.Size = new System.Drawing.Size(109, 13);
            this.lbl_M3.TabIndex = 46;
            this.lbl_M3.Text = "Média do 3º bimestre:";
            // 
            // txt_pp4
            // 
            this.txt_pp4.Location = new System.Drawing.Point(388, 454);
            this.txt_pp4.Name = "txt_pp4";
            this.txt_pp4.Size = new System.Drawing.Size(32, 20);
            this.txt_pp4.TabIndex = 65;
            // 
            // txt_np4
            // 
            this.txt_np4.Location = new System.Drawing.Point(388, 430);
            this.txt_np4.Name = "txt_np4";
            this.txt_np4.Size = new System.Drawing.Size(32, 20);
            this.txt_np4.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Peso das provas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Nota das provas:";
            // 
            // txt_pt4
            // 
            this.txt_pt4.Location = new System.Drawing.Point(226, 451);
            this.txt_pt4.Name = "txt_pt4";
            this.txt_pt4.Size = new System.Drawing.Size(32, 20);
            this.txt_pt4.TabIndex = 61;
            // 
            // txt_nt4
            // 
            this.txt_nt4.Location = new System.Drawing.Point(226, 427);
            this.txt_nt4.Name = "txt_nt4";
            this.txt_nt4.Size = new System.Drawing.Size(32, 20);
            this.txt_nt4.TabIndex = 60;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(120, 457);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 59;
            this.label14.Text = "Peso dos trabalhos:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(121, 433);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 58;
            this.label15.Text = "Nota dos trabalhos:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 434);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 57;
            this.label16.Text = "2º Bimestre";
            // 
            // lbl_M4
            // 
            this.lbl_M4.AutoSize = true;
            this.lbl_M4.Location = new System.Drawing.Point(455, 434);
            this.lbl_M4.Name = "lbl_M4";
            this.lbl_M4.Size = new System.Drawing.Size(109, 13);
            this.lbl_M4.TabIndex = 56;
            this.lbl_M4.Text = "Média do 4º bimestre:";
            // 
            // lbl_alt_media
            // 
            this.lbl_alt_media.AutoSize = true;
            this.lbl_alt_media.Location = new System.Drawing.Point(214, 101);
            this.lbl_alt_media.Name = "lbl_alt_media";
            this.lbl_alt_media.Size = new System.Drawing.Size(205, 13);
            this.lbl_alt_media.TabIndex = 66;
            this.lbl_alt_media.Text = "Digite o nome do arquivo sem a extensão:";
            this.lbl_alt_media.Visible = false;
            // 
            // chk_alterar_media
            // 
            this.chk_alterar_media.AutoSize = true;
            this.chk_alterar_media.Location = new System.Drawing.Point(35, 100);
            this.chk_alterar_media.Name = "chk_alterar_media";
            this.chk_alterar_media.Size = new System.Drawing.Size(154, 17);
            this.chk_alterar_media.TabIndex = 67;
            this.chk_alterar_media.Text = "Alterar média já cadastrada";
            this.chk_alterar_media.UseVisualStyleBackColor = true;
            this.chk_alterar_media.CheckedChanged += new System.EventHandler(this.chk_alterar_media_CheckedChanged);
            // 
            // txt_NomeArq
            // 
            this.txt_NomeArq.Location = new System.Drawing.Point(431, 94);
            this.txt_NomeArq.Name = "txt_NomeArq";
            this.txt_NomeArq.Size = new System.Drawing.Size(100, 20);
            this.txt_NomeArq.TabIndex = 68;
            this.txt_NomeArq.Visible = false;
            // 
            // Frm_CalcMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 681);
            this.Controls.Add(this.txt_NomeArq);
            this.Controls.Add(this.chk_alterar_media);
            this.Controls.Add(this.lbl_alt_media);
            this.Controls.Add(this.txt_pp4);
            this.Controls.Add(this.txt_np4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_pt4);
            this.Controls.Add(this.txt_nt4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbl_M4);
            this.Controls.Add(this.txt_pp3);
            this.Controls.Add(this.txt_np3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pt3);
            this.Controls.Add(this.txt_nt3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_M3);
            this.Controls.Add(this.txt_pp2);
            this.Controls.Add(this.txt_np2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_pt2);
            this.Controls.Add(this.txt_nt2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_M2);
            this.Controls.Add(this.txt_pp1);
            this.Controls.Add(this.txt_np1);
            this.Controls.Add(this.lbl_pp1);
            this.Controls.Add(this.lbl_np1);
            this.Controls.Add(this.txt_pt1);
            this.Controls.Add(this.txt_nt1);
            this.Controls.Add(this.lbl_pt1);
            this.Controls.Add(this.lbl_nt1);
            this.Controls.Add(this.lbl_1B);
            this.Controls.Add(this.txt_professor);
            this.Controls.Add(this.lbl_professor);
            this.Controls.Add(this.cmb_serie);
            this.Controls.Add(this.lbl_serie);
            this.Controls.Add(this.txt_discip);
            this.Controls.Add(this.lbl_discip);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_Media);
            this.Controls.Add(this.lbl_med);
            this.Controls.Add(this.lbl_M1);
            this.Controls.Add(this.button1);
            this.Name = "Frm_CalcMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalcMedia";
            this.Load += new System.EventHandler(this.Frm_CalcMedia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_M1;
        private System.Windows.Forms.Label lbl_med;
        private System.Windows.Forms.Label lbl_Media;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_discip;
        private System.Windows.Forms.TextBox txt_discip;
        private System.Windows.Forms.Label lbl_serie;
        private System.Windows.Forms.ComboBox cmb_serie;
        private System.Windows.Forms.Label lbl_professor;
        private System.Windows.Forms.TextBox txt_professor;
        private System.Windows.Forms.Label lbl_1B;
        private System.Windows.Forms.Label lbl_nt1;
        private System.Windows.Forms.Label lbl_pt1;
        private System.Windows.Forms.TextBox txt_pt1;
        private System.Windows.Forms.TextBox txt_nt1;
        private System.Windows.Forms.Label lbl_pp1;
        private System.Windows.Forms.Label lbl_np1;
        private System.Windows.Forms.TextBox txt_pp1;
        private System.Windows.Forms.TextBox txt_np1;
        private System.Windows.Forms.TextBox txt_pp2;
        private System.Windows.Forms.TextBox txt_np2;
        private System.Windows.Forms.TextBox txt_pt2;
        private System.Windows.Forms.TextBox txt_nt2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_M2;
        private System.Windows.Forms.TextBox txt_pp3;
        private System.Windows.Forms.TextBox txt_np3;
        private System.Windows.Forms.TextBox txt_pt3;
        private System.Windows.Forms.TextBox txt_nt3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_M3;
        private System.Windows.Forms.TextBox txt_pp4;
        private System.Windows.Forms.TextBox txt_np4;
        private System.Windows.Forms.TextBox txt_pt4;
        private System.Windows.Forms.TextBox txt_nt4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_M4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_alt_media;
        private System.Windows.Forms.CheckBox chk_alterar_media;
        private System.Windows.Forms.TextBox txt_NomeArq;
    }
}

