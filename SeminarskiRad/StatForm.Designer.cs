namespace SeminarskiRad
{
    partial class StatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatForm));
            this.label1 = new System.Windows.Forms.Label();
            this.PnlDefault = new System.Windows.Forms.Panel();
            this.CbGodina = new System.Windows.Forms.ComboBox();
            this.LbYear = new System.Windows.Forms.Label();
            this.TbNaziv = new System.Windows.Forms.TextBox();
            this.LbName = new System.Windows.Forms.Label();
            this.PnlAdd = new System.Windows.Forms.Panel();
            this.LbMonth = new System.Windows.Forms.Label();
            this.TbOstalo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbOsiguranje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbTransport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TbInternet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbPrehrana = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbRezije = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbNajam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPrihodi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSljedeca = new System.Windows.Forms.Button();
            this.BtnPrethodna = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnNazad = new System.Windows.Forms.Button();
            this.PnlDefault.SuspendLayout();
            this.PnlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unos godišnjih troškova";
            // 
            // PnlDefault
            // 
            this.PnlDefault.Controls.Add(this.CbGodina);
            this.PnlDefault.Controls.Add(this.LbYear);
            this.PnlDefault.Controls.Add(this.TbNaziv);
            this.PnlDefault.Controls.Add(this.LbName);
            this.PnlDefault.Location = new System.Drawing.Point(105, 114);
            this.PnlDefault.Name = "PnlDefault";
            this.PnlDefault.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.PnlDefault.Size = new System.Drawing.Size(500, 424);
            this.PnlDefault.TabIndex = 1;
            // 
            // CbGodina
            // 
            this.CbGodina.DropDownHeight = 150;
            this.CbGodina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGodina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbGodina.FormattingEnabled = true;
            this.CbGodina.IntegralHeight = false;
            this.CbGodina.Location = new System.Drawing.Point(100, 262);
            this.CbGodina.MaxDropDownItems = 5;
            this.CbGodina.Name = "CbGodina";
            this.CbGodina.Size = new System.Drawing.Size(296, 29);
            this.CbGodina.TabIndex = 6;
            // 
            // LbYear
            // 
            this.LbYear.AutoSize = true;
            this.LbYear.BackColor = System.Drawing.Color.Transparent;
            this.LbYear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbYear.ForeColor = System.Drawing.Color.White;
            this.LbYear.Location = new System.Drawing.Point(96, 220);
            this.LbYear.Name = "LbYear";
            this.LbYear.Size = new System.Drawing.Size(191, 24);
            this.LbYear.TabIndex = 5;
            this.LbYear.Text = "Odaberite godinu";
            // 
            // TbNaziv
            // 
            this.TbNaziv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNaziv.Location = new System.Drawing.Point(100, 150);
            this.TbNaziv.Name = "TbNaziv";
            this.TbNaziv.Size = new System.Drawing.Size(300, 27);
            this.TbNaziv.TabIndex = 4;
            this.TbNaziv.TextChanged += new System.EventHandler(this.TbNaziv_TextChanged);
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.BackColor = System.Drawing.Color.Transparent;
            this.LbName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.ForeColor = System.Drawing.Color.White;
            this.LbName.Location = new System.Drawing.Point(96, 108);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(228, 24);
            this.LbName.TabIndex = 3;
            this.LbName.Text = "Unesite naziv statistike";
            // 
            // PnlAdd
            // 
            this.PnlAdd.Controls.Add(this.LbMonth);
            this.PnlAdd.Controls.Add(this.TbOstalo);
            this.PnlAdd.Controls.Add(this.label6);
            this.PnlAdd.Controls.Add(this.TbOsiguranje);
            this.PnlAdd.Controls.Add(this.label7);
            this.PnlAdd.Controls.Add(this.TbTransport);
            this.PnlAdd.Controls.Add(this.label8);
            this.PnlAdd.Controls.Add(this.TbInternet);
            this.PnlAdd.Controls.Add(this.label9);
            this.PnlAdd.Controls.Add(this.TbPrehrana);
            this.PnlAdd.Controls.Add(this.label5);
            this.PnlAdd.Controls.Add(this.TbRezije);
            this.PnlAdd.Controls.Add(this.label4);
            this.PnlAdd.Controls.Add(this.TbNajam);
            this.PnlAdd.Controls.Add(this.label2);
            this.PnlAdd.Controls.Add(this.TbPrihodi);
            this.PnlAdd.Controls.Add(this.label3);
            this.PnlAdd.Location = new System.Drawing.Point(105, 114);
            this.PnlAdd.Name = "PnlAdd";
            this.PnlAdd.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.PnlAdd.Size = new System.Drawing.Size(500, 424);
            this.PnlAdd.TabIndex = 2;
            // 
            // LbMonth
            // 
            this.LbMonth.AutoSize = true;
            this.LbMonth.BackColor = System.Drawing.Color.Transparent;
            this.LbMonth.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMonth.ForeColor = System.Drawing.Color.White;
            this.LbMonth.Location = new System.Drawing.Point(199, 20);
            this.LbMonth.Name = "LbMonth";
            this.LbMonth.Size = new System.Drawing.Size(0, 24);
            this.LbMonth.TabIndex = 19;
            // 
            // TbOstalo
            // 
            this.TbOstalo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbOstalo.Location = new System.Drawing.Point(272, 329);
            this.TbOstalo.Name = "TbOstalo";
            this.TbOstalo.Size = new System.Drawing.Size(192, 23);
            this.TbOstalo.TabIndex = 18;
            this.TbOstalo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(268, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Unesite ostale troškove:";
            // 
            // TbOsiguranje
            // 
            this.TbOsiguranje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbOsiguranje.Location = new System.Drawing.Point(272, 262);
            this.TbOsiguranje.Name = "TbOsiguranje";
            this.TbOsiguranje.Size = new System.Drawing.Size(192, 23);
            this.TbOsiguranje.TabIndex = 16;
            this.TbOsiguranje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(268, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Unesite trošak osiguranja:";
            // 
            // TbTransport
            // 
            this.TbTransport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTransport.Location = new System.Drawing.Point(272, 193);
            this.TbTransport.Name = "TbTransport";
            this.TbTransport.Size = new System.Drawing.Size(192, 23);
            this.TbTransport.TabIndex = 14;
            this.TbTransport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(268, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Unesite trošak transporta:";
            // 
            // TbInternet
            // 
            this.TbInternet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbInternet.Location = new System.Drawing.Point(272, 126);
            this.TbInternet.Name = "TbInternet";
            this.TbInternet.Size = new System.Drawing.Size(192, 23);
            this.TbInternet.TabIndex = 12;
            this.TbInternet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(268, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Unesite trošak interneta:";
            // 
            // TbPrehrana
            // 
            this.TbPrehrana.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPrehrana.Location = new System.Drawing.Point(42, 329);
            this.TbPrehrana.Name = "TbPrehrana";
            this.TbPrehrana.Size = new System.Drawing.Size(192, 23);
            this.TbPrehrana.TabIndex = 10;
            this.TbPrehrana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unesite troškove prehrane:";
            // 
            // TbRezije
            // 
            this.TbRezije.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbRezije.Location = new System.Drawing.Point(42, 262);
            this.TbRezije.Name = "TbRezije";
            this.TbRezije.Size = new System.Drawing.Size(192, 23);
            this.TbRezije.TabIndex = 8;
            this.TbRezije.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unesite trošak režija";
            // 
            // TbNajam
            // 
            this.TbNajam.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNajam.Location = new System.Drawing.Point(42, 193);
            this.TbNajam.Name = "TbNajam";
            this.TbNajam.Size = new System.Drawing.Size(192, 23);
            this.TbNajam.TabIndex = 6;
            this.TbNajam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unesite trošak najma:";
            // 
            // TbPrihodi
            // 
            this.TbPrihodi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPrihodi.Location = new System.Drawing.Point(42, 126);
            this.TbPrihodi.Name = "TbPrihodi";
            this.TbPrihodi.Size = new System.Drawing.Size(192, 23);
            this.TbPrihodi.TabIndex = 4;
            this.TbPrihodi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Unesite mjesečni prihod:";
            // 
            // BtnSljedeca
            // 
            this.BtnSljedeca.BackColor = System.Drawing.Color.Transparent;
            this.BtnSljedeca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnSljedeca.FlatAppearance.BorderSize = 2;
            this.BtnSljedeca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSljedeca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSljedeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSljedeca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSljedeca.ForeColor = System.Drawing.Color.White;
            this.BtnSljedeca.Location = new System.Drawing.Point(362, 570);
            this.BtnSljedeca.Name = "BtnSljedeca";
            this.BtnSljedeca.Size = new System.Drawing.Size(120, 40);
            this.BtnSljedeca.TabIndex = 3;
            this.BtnSljedeca.TabStop = false;
            this.BtnSljedeca.Text = "Sljedeća";
            this.BtnSljedeca.UseVisualStyleBackColor = false;
            this.BtnSljedeca.Visible = false;
            this.BtnSljedeca.Click += new System.EventHandler(this.BtnSljedeca_Click);
            // 
            // BtnPrethodna
            // 
            this.BtnPrethodna.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrethodna.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnPrethodna.FlatAppearance.BorderSize = 2;
            this.BtnPrethodna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnPrethodna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPrethodna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrethodna.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrethodna.ForeColor = System.Drawing.Color.White;
            this.BtnPrethodna.Location = new System.Drawing.Point(236, 570);
            this.BtnPrethodna.Name = "BtnPrethodna";
            this.BtnPrethodna.Size = new System.Drawing.Size(120, 40);
            this.BtnPrethodna.TabIndex = 4;
            this.BtnPrethodna.TabStop = false;
            this.BtnPrethodna.Text = "Prethodna";
            this.BtnPrethodna.UseVisualStyleBackColor = false;
            this.BtnPrethodna.Visible = false;
            this.BtnPrethodna.Click += new System.EventHandler(this.BtnPrethodna_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Red;
            this.BtnClose.Location = new System.Drawing.Point(674, 10);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(50, 50);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnNazad
            // 
            this.BtnNazad.BackColor = System.Drawing.Color.Transparent;
            this.BtnNazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNazad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.BtnNazad.FlatAppearance.BorderSize = 0;
            this.BtnNazad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnNazad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNazad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNazad.ForeColor = System.Drawing.Color.White;
            this.BtnNazad.Image = ((System.Drawing.Image)(resources.GetObject("BtnNazad.Image")));
            this.BtnNazad.Location = new System.Drawing.Point(555, 10);
            this.BtnNazad.Name = "BtnNazad";
            this.BtnNazad.Size = new System.Drawing.Size(50, 50);
            this.BtnNazad.TabIndex = 5;
            this.BtnNazad.UseVisualStyleBackColor = false;
            this.BtnNazad.Click += new System.EventHandler(this.BtnNazad_Click);
            // 
            // StatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.PnlAdd);
            this.Controls.Add(this.BtnNazad);
            this.Controls.Add(this.BtnPrethodna);
            this.Controls.Add(this.BtnSljedeca);
            this.Controls.Add(this.PnlDefault);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatForm";
            this.Text = "Unos statistike";
            this.Load += new System.EventHandler(this.StatForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StatForm_MouseDown);
            this.PnlDefault.ResumeLayout(false);
            this.PnlDefault.PerformLayout();
            this.PnlAdd.ResumeLayout(false);
            this.PnlAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlDefault;
        private System.Windows.Forms.ComboBox CbGodina;
        private System.Windows.Forms.Label LbYear;
        private System.Windows.Forms.TextBox TbNaziv;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Button BtnSljedeca;
        private System.Windows.Forms.Button BtnPrethodna;
        private System.Windows.Forms.Button BtnNazad;
        private System.Windows.Forms.Panel PnlAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbRezije;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbNajam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbPrihodi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbPrehrana;
        private System.Windows.Forms.TextBox TbOstalo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbOsiguranje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbTransport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbInternet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LbMonth;
        private System.Windows.Forms.Button BtnClose;
    }
}