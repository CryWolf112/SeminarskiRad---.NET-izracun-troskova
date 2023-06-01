namespace SeminarskiRad
{
    partial class DetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsForm));
            this.BtnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNazad = new System.Windows.Forms.Button();
            this.PnlStats = new System.Windows.Forms.Panel();
            this.LbPodaci = new System.Windows.Forms.Label();
            this.BtnIzvezi = new System.Windows.Forms.Button();
            this.BtnIzbrisi = new System.Windows.Forms.Button();
            this.PnlStats.SuspendLayout();
            this.SuspendLayout();
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
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Statistika troškova";
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
            this.BtnNazad.TabIndex = 8;
            this.BtnNazad.UseVisualStyleBackColor = false;
            this.BtnNazad.Click += new System.EventHandler(this.BtnNazad_Click);
            // 
            // PnlStats
            // 
            this.PnlStats.AutoScroll = true;
            this.PnlStats.Controls.Add(this.LbPodaci);
            this.PnlStats.Location = new System.Drawing.Point(117, 143);
            this.PnlStats.Name = "PnlStats";
            this.PnlStats.Padding = new System.Windows.Forms.Padding(20);
            this.PnlStats.Size = new System.Drawing.Size(500, 424);
            this.PnlStats.TabIndex = 10;
            // 
            // LbPodaci
            // 
            this.LbPodaci.AutoSize = true;
            this.LbPodaci.BackColor = System.Drawing.Color.Transparent;
            this.LbPodaci.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbPodaci.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPodaci.ForeColor = System.Drawing.Color.White;
            this.LbPodaci.Location = new System.Drawing.Point(20, 20);
            this.LbPodaci.Name = "LbPodaci";
            this.LbPodaci.Size = new System.Drawing.Size(0, 21);
            this.LbPodaci.TabIndex = 3;
            // 
            // BtnIzvezi
            // 
            this.BtnIzvezi.BackColor = System.Drawing.Color.Transparent;
            this.BtnIzvezi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnIzvezi.FlatAppearance.BorderSize = 2;
            this.BtnIzvezi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnIzvezi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnIzvezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIzvezi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzvezi.ForeColor = System.Drawing.Color.White;
            this.BtnIzvezi.Location = new System.Drawing.Point(497, 600);
            this.BtnIzvezi.Name = "BtnIzvezi";
            this.BtnIzvezi.Size = new System.Drawing.Size(120, 40);
            this.BtnIzvezi.TabIndex = 11;
            this.BtnIzvezi.TabStop = false;
            this.BtnIzvezi.Text = "Izvezi";
            this.BtnIzvezi.UseVisualStyleBackColor = false;
            this.BtnIzvezi.Click += new System.EventHandler(this.BtnIzvezi_Click);
            // 
            // BtnIzbrisi
            // 
            this.BtnIzbrisi.BackColor = System.Drawing.Color.Transparent;
            this.BtnIzbrisi.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnIzbrisi.FlatAppearance.BorderSize = 2;
            this.BtnIzbrisi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnIzbrisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIzbrisi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIzbrisi.ForeColor = System.Drawing.Color.White;
            this.BtnIzbrisi.Location = new System.Drawing.Point(358, 600);
            this.BtnIzbrisi.Name = "BtnIzbrisi";
            this.BtnIzbrisi.Size = new System.Drawing.Size(120, 40);
            this.BtnIzbrisi.TabIndex = 12;
            this.BtnIzbrisi.TabStop = false;
            this.BtnIzbrisi.Text = "Izbriši";
            this.BtnIzbrisi.UseVisualStyleBackColor = false;
            this.BtnIzbrisi.Click += new System.EventHandler(this.BtnIzbrisi_Click);
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(734, 711);
            this.Controls.Add(this.BtnIzbrisi);
            this.Controls.Add(this.BtnIzvezi);
            this.Controls.Add(this.PnlStats);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnNazad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DetailsForm_MouseDown);
            this.PnlStats.ResumeLayout(false);
            this.PnlStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnNazad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlStats;
        private System.Windows.Forms.Label LbPodaci;
        private System.Windows.Forms.Button BtnIzvezi;
        private System.Windows.Forms.Button BtnIzbrisi;
    }
}