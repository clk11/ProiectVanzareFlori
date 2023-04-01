
namespace proiect_vanzare_flori
{
    partial class FormaParcele
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
            this.ButonIesire = new System.Windows.Forms.Button();
            this.parcele = new System.Windows.Forms.DataGridView();
            this.NumarParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumarLinii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumarColoane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vizualizare = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Stergere = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ButonAdaugareParcela = new System.Windows.Forms.Button();
            this.ParceleLBL = new System.Windows.Forms.Label();
            this.NumarLiniiN = new System.Windows.Forms.NumericUpDown();
            this.NumarColoaneN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButonInpoiLaMeniu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parcele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumarLiniiN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumarColoaneN)).BeginInit();
            this.SuspendLayout();
            // 
            // ButonIesire
            // 
            this.ButonIesire.BackColor = System.Drawing.Color.Red;
            this.ButonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonIesire.Location = new System.Drawing.Point(843, 0);
            this.ButonIesire.Name = "ButonIesire";
            this.ButonIesire.Size = new System.Drawing.Size(39, 41);
            this.ButonIesire.TabIndex = 1;
            this.ButonIesire.Text = "X";
            this.ButonIesire.UseVisualStyleBackColor = false;
            this.ButonIesire.Click += new System.EventHandler(this.ButonIesire_Click);
            // 
            // parcele
            // 
            this.parcele.AllowUserToAddRows = false;
            this.parcele.AllowUserToDeleteRows = false;
            this.parcele.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.parcele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parcele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumarParcela,
            this.NumarLinii,
            this.NumarColoane,
            this.Vizualizare,
            this.Stergere});
            this.parcele.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.parcele.Location = new System.Drawing.Point(34, 111);
            this.parcele.Name = "parcele";
            this.parcele.ReadOnly = true;
            this.parcele.RowHeadersWidth = 51;
            this.parcele.RowTemplate.Height = 24;
            this.parcele.Size = new System.Drawing.Size(825, 486);
            this.parcele.TabIndex = 2;
            this.parcele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parcele_CellContentClick);
            // 
            // NumarParcela
            // 
            this.NumarParcela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumarParcela.HeaderText = "Numar";
            this.NumarParcela.MinimumWidth = 6;
            this.NumarParcela.Name = "NumarParcela";
            this.NumarParcela.ReadOnly = true;
            // 
            // NumarLinii
            // 
            this.NumarLinii.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumarLinii.HeaderText = "Linii";
            this.NumarLinii.MinimumWidth = 6;
            this.NumarLinii.Name = "NumarLinii";
            this.NumarLinii.ReadOnly = true;
            // 
            // NumarColoane
            // 
            this.NumarColoane.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumarColoane.HeaderText = "Coloane";
            this.NumarColoane.MinimumWidth = 6;
            this.NumarColoane.Name = "NumarColoane";
            this.NumarColoane.ReadOnly = true;
            // 
            // Vizualizare
            // 
            this.Vizualizare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vizualizare.HeaderText = "";
            this.Vizualizare.MinimumWidth = 6;
            this.Vizualizare.Name = "Vizualizare";
            this.Vizualizare.ReadOnly = true;
            this.Vizualizare.Text = "Vizualizare";
            this.Vizualizare.UseColumnTextForButtonValue = true;
            // 
            // Stergere
            // 
            this.Stergere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stergere.HeaderText = "";
            this.Stergere.MinimumWidth = 6;
            this.Stergere.Name = "Stergere";
            this.Stergere.ReadOnly = true;
            this.Stergere.Text = "Stergere";
            this.Stergere.UseColumnTextForButtonValue = true;
            // 
            // ButonAdaugareParcela
            // 
            this.ButonAdaugareParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonAdaugareParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonAdaugareParcela.Location = new System.Drawing.Point(43, 626);
            this.ButonAdaugareParcela.Name = "ButonAdaugareParcela";
            this.ButonAdaugareParcela.Size = new System.Drawing.Size(252, 47);
            this.ButonAdaugareParcela.TabIndex = 3;
            this.ButonAdaugareParcela.Text = "Adaugare parcela";
            this.ButonAdaugareParcela.UseVisualStyleBackColor = true;
            this.ButonAdaugareParcela.Click += new System.EventHandler(this.ButonAdaugareParcela_Click);
            // 
            // ParceleLBL
            // 
            this.ParceleLBL.AutoSize = true;
            this.ParceleLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParceleLBL.Location = new System.Drawing.Point(366, 49);
            this.ParceleLBL.Name = "ParceleLBL";
            this.ParceleLBL.Size = new System.Drawing.Size(156, 46);
            this.ParceleLBL.TabIndex = 4;
            this.ParceleLBL.Text = "Parcele";
            // 
            // NumarLiniiN
            // 
            this.NumarLiniiN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumarLiniiN.Location = new System.Drawing.Point(324, 617);
            this.NumarLiniiN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumarLiniiN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumarLiniiN.Name = "NumarLiniiN";
            this.NumarLiniiN.Size = new System.Drawing.Size(76, 30);
            this.NumarLiniiN.TabIndex = 5;
            this.NumarLiniiN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumarColoaneN
            // 
            this.NumarColoaneN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumarColoaneN.Location = new System.Drawing.Point(324, 661);
            this.NumarColoaneN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumarColoaneN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumarColoaneN.Name = "NumarColoaneN";
            this.NumarColoaneN.Size = new System.Drawing.Size(76, 30);
            this.NumarColoaneN.TabIndex = 5;
            this.NumarColoaneN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "<-Numar linii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 659);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "<-Numar coloane";
            // 
            // ButonInpoiLaMeniu
            // 
            this.ButonInpoiLaMeniu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonInpoiLaMeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonInpoiLaMeniu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButonInpoiLaMeniu.Location = new System.Drawing.Point(12, 12);
            this.ButonInpoiLaMeniu.Name = "ButonInpoiLaMeniu";
            this.ButonInpoiLaMeniu.Size = new System.Drawing.Size(130, 47);
            this.ButonInpoiLaMeniu.TabIndex = 7;
            this.ButonInpoiLaMeniu.Text = "Meniu";
            this.ButonInpoiLaMeniu.UseVisualStyleBackColor = true;
            // 
            // FormaParcele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 709);
            this.Controls.Add(this.ButonInpoiLaMeniu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumarColoaneN);
            this.Controls.Add(this.NumarLiniiN);
            this.Controls.Add(this.ParceleLBL);
            this.Controls.Add(this.ButonAdaugareParcela);
            this.Controls.Add(this.parcele);
            this.Controls.Add(this.ButonIesire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaParcele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaPlantare";
            this.Load += new System.EventHandler(this.FormaPlantare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parcele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumarLiniiN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumarColoaneN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButonIesire;
        private System.Windows.Forms.DataGridView parcele;
        private System.Windows.Forms.Button ButonAdaugareParcela;
        private System.Windows.Forms.Label ParceleLBL;
        private System.Windows.Forms.NumericUpDown NumarLiniiN;
        private System.Windows.Forms.NumericUpDown NumarColoaneN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumarParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumarLinii;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumarColoane;
        private System.Windows.Forms.DataGridViewButtonColumn Vizualizare;
        private System.Windows.Forms.DataGridViewButtonColumn Stergere;
        private System.Windows.Forms.Button ButonInpoiLaMeniu;
    }
}