namespace AsistentGUI
{
    partial class PregledTurnira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledTurnira));
            this.lblTurnir = new System.Windows.Forms.Label();
            this.lblNazivTurnira = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRunde = new System.Windows.Forms.ComboBox();
            this.lstParovi = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblPrvaEkipa = new System.Windows.Forms.Label();
            this.lblRezultatPrveEkipe = new System.Windows.Forms.Label();
            this.txtRezultatPrveEkipe = new System.Windows.Forms.TextBox();
            this.txtDrugeEkipe = new System.Windows.Forms.TextBox();
            this.lblRezultatDrugeEkipe = new System.Windows.Forms.Label();
            this.lblDrugaEkipa = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnSpremiRezultat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTurnir
            // 
            this.lblTurnir.AutoSize = true;
            this.lblTurnir.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTurnir.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTurnir.Location = new System.Drawing.Point(26, 22);
            this.lblTurnir.Name = "lblTurnir";
            this.lblTurnir.Size = new System.Drawing.Size(110, 45);
            this.lblTurnir.TabIndex = 0;
            this.lblTurnir.Text = "Turnir:";
            this.lblTurnir.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNazivTurnira
            // 
            this.lblNazivTurnira.AutoSize = true;
            this.lblNazivTurnira.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivTurnira.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblNazivTurnira.Location = new System.Drawing.Point(126, 22);
            this.lblNazivTurnira.Name = "lblNazivTurnira";
            this.lblNazivTurnira.Size = new System.Drawing.Size(135, 45);
            this.lblNazivTurnira.TabIndex = 1;
            this.lblNazivTurnira.Text = "<naziv>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Runda:";
            // 
            // cmbRunde
            // 
            this.cmbRunde.FormattingEnabled = true;
            this.cmbRunde.Location = new System.Drawing.Point(134, 93);
            this.cmbRunde.Name = "cmbRunde";
            this.cmbRunde.Size = new System.Drawing.Size(203, 33);
            this.cmbRunde.TabIndex = 3;
            // 
            // lstParovi
            // 
            this.lstParovi.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lstParovi.FormattingEnabled = true;
            this.lstParovi.ItemHeight = 25;
            this.lstParovi.Location = new System.Drawing.Point(36, 184);
            this.lstParovi.Name = "lstParovi";
            this.lstParovi.Size = new System.Drawing.Size(301, 254);
            this.lstParovi.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.checkBox1.Location = new System.Drawing.Point(67, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(267, 29);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Prikaži neodigrane utakmice";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblPrvaEkipa
            // 
            this.lblPrvaEkipa.AutoSize = true;
            this.lblPrvaEkipa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrvaEkipa.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblPrvaEkipa.Location = new System.Drawing.Point(366, 215);
            this.lblPrvaEkipa.Name = "lblPrvaEkipa";
            this.lblPrvaEkipa.Size = new System.Drawing.Size(130, 30);
            this.lblPrvaEkipa.TabIndex = 6;
            this.lblPrvaEkipa.Text = "<prvaEkipa>";
            // 
            // lblRezultatPrveEkipe
            // 
            this.lblRezultatPrveEkipe.AutoSize = true;
            this.lblRezultatPrveEkipe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRezultatPrveEkipe.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblRezultatPrveEkipe.Location = new System.Drawing.Point(366, 257);
            this.lblRezultatPrveEkipe.Name = "lblRezultatPrveEkipe";
            this.lblRezultatPrveEkipe.Size = new System.Drawing.Size(93, 30);
            this.lblRezultatPrveEkipe.TabIndex = 7;
            this.lblRezultatPrveEkipe.Text = "Rezultat:";
            // 
            // txtRezultatPrveEkipe
            // 
            this.txtRezultatPrveEkipe.Location = new System.Drawing.Point(465, 254);
            this.txtRezultatPrveEkipe.Name = "txtRezultatPrveEkipe";
            this.txtRezultatPrveEkipe.Size = new System.Drawing.Size(100, 33);
            this.txtRezultatPrveEkipe.TabIndex = 8;
            // 
            // txtDrugeEkipe
            // 
            this.txtDrugeEkipe.Location = new System.Drawing.Point(465, 383);
            this.txtDrugeEkipe.Name = "txtDrugeEkipe";
            this.txtDrugeEkipe.Size = new System.Drawing.Size(100, 33);
            this.txtDrugeEkipe.TabIndex = 11;
            // 
            // lblRezultatDrugeEkipe
            // 
            this.lblRezultatDrugeEkipe.AutoSize = true;
            this.lblRezultatDrugeEkipe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRezultatDrugeEkipe.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblRezultatDrugeEkipe.Location = new System.Drawing.Point(366, 386);
            this.lblRezultatDrugeEkipe.Name = "lblRezultatDrugeEkipe";
            this.lblRezultatDrugeEkipe.Size = new System.Drawing.Size(93, 30);
            this.lblRezultatDrugeEkipe.TabIndex = 10;
            this.lblRezultatDrugeEkipe.Text = "Rezultat:";
            // 
            // lblDrugaEkipa
            // 
            this.lblDrugaEkipa.AutoSize = true;
            this.lblDrugaEkipa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDrugaEkipa.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblDrugaEkipa.Location = new System.Drawing.Point(366, 344);
            this.lblDrugaEkipa.Name = "lblDrugaEkipa";
            this.lblDrugaEkipa.Size = new System.Drawing.Size(130, 30);
            this.lblDrugaEkipa.TabIndex = 9;
            this.lblDrugaEkipa.Text = "<prvaEkipa>";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVS.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblVS.Location = new System.Drawing.Point(438, 304);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(77, 37);
            this.lblVS.TabIndex = 12;
            this.lblVS.Text = "-VS -";
            // 
            // btnSpremiRezultat
            // 
            this.btnSpremiRezultat.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnSpremiRezultat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnSpremiRezultat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSpremiRezultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiRezultat.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSpremiRezultat.Location = new System.Drawing.Point(588, 296);
            this.btnSpremiRezultat.Name = "btnSpremiRezultat";
            this.btnSpremiRezultat.Size = new System.Drawing.Size(139, 60);
            this.btnSpremiRezultat.TabIndex = 13;
            this.btnSpremiRezultat.Text = "Spremi";
            this.btnSpremiRezultat.UseVisualStyleBackColor = true;
            // 
            // PregledTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 482);
            this.Controls.Add(this.btnSpremiRezultat);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.txtDrugeEkipe);
            this.Controls.Add(this.lblRezultatDrugeEkipe);
            this.Controls.Add(this.lblDrugaEkipa);
            this.Controls.Add(this.txtRezultatPrveEkipe);
            this.Controls.Add(this.lblRezultatPrveEkipe);
            this.Controls.Add(this.lblPrvaEkipa);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lstParovi);
            this.Controls.Add(this.cmbRunde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNazivTurnira);
            this.Controls.Add(this.lblTurnir);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PregledTurnira";
            this.Text = "Pregled Turnira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurnir;
        private System.Windows.Forms.Label lblNazivTurnira;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRunde;
        private System.Windows.Forms.ListBox lstParovi;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblPrvaEkipa;
        private System.Windows.Forms.Label lblRezultatPrveEkipe;
        private System.Windows.Forms.TextBox txtRezultatPrveEkipe;
        private System.Windows.Forms.TextBox txtDrugeEkipe;
        private System.Windows.Forms.Label lblRezultatDrugeEkipe;
        private System.Windows.Forms.Label lblDrugaEkipa;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Button btnSpremiRezultat;
    }
}

