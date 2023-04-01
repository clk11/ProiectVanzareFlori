
namespace proiect_vanzare_flori
{
    partial class FormaVizualizareParcela
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
            this.flori = new System.Windows.Forms.DataGridView();
            this.Floare = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumarLinie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumarColoana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vinde = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Pierdere = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ButonAdaugareFloare = new System.Windows.Forms.Button();
            this.InpoiLaParcele = new System.Windows.Forms.Button();
            this.ParceleLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flori)).BeginInit();
            this.SuspendLayout();
            // 
            // ButonIesire
            // 
            this.ButonIesire.BackColor = System.Drawing.Color.Red;
            this.ButonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonIesire.Location = new System.Drawing.Point(969, -1);
            this.ButonIesire.Name = "ButonIesire";
            this.ButonIesire.Size = new System.Drawing.Size(39, 41);
            this.ButonIesire.TabIndex = 1;
            this.ButonIesire.Text = "X";
            this.ButonIesire.UseVisualStyleBackColor = false;
            this.ButonIesire.Click += new System.EventHandler(this.ButonIesire_Click);
            // 
            // flori
            // 
            this.flori.AllowUserToAddRows = false;
            this.flori.AllowUserToDeleteRows = false;
            this.flori.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Floare,
            this.ID,
            this.NumarLinie,
            this.NumarColoana,
            this.Vinde,
            this.Pierdere});
            this.flori.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flori.Location = new System.Drawing.Point(48, 99);
            this.flori.Name = "flori";
            this.flori.ReadOnly = true;
            this.flori.RowHeadersWidth = 51;
            this.flori.RowTemplate.Height = 24;
            this.flori.Size = new System.Drawing.Size(906, 467);
            this.flori.TabIndex = 3;
            this.flori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Flori_CellContentClick);
            // 
            // Floare
            // 
            this.Floare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Floare.HeaderText = "";
            this.Floare.MinimumWidth = 6;
            this.Floare.Name = "Floare";
            this.Floare.ReadOnly = true;
            this.Floare.Text = "Detalii floare";
            this.Floare.UseColumnTextForButtonValue = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // NumarLinie
            // 
            this.NumarLinie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumarLinie.HeaderText = "Linia";
            this.NumarLinie.MinimumWidth = 6;
            this.NumarLinie.Name = "NumarLinie";
            this.NumarLinie.ReadOnly = true;
            // 
            // NumarColoana
            // 
            this.NumarColoana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumarColoana.HeaderText = "Coloana";
            this.NumarColoana.MinimumWidth = 6;
            this.NumarColoana.Name = "NumarColoana";
            this.NumarColoana.ReadOnly = true;
            // 
            // Vinde
            // 
            this.Vinde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vinde.HeaderText = "";
            this.Vinde.MinimumWidth = 6;
            this.Vinde.Name = "Vinde";
            this.Vinde.ReadOnly = true;
            this.Vinde.Text = "Vinde floarea";
            this.Vinde.UseColumnTextForButtonValue = true;
            // 
            // Pierdere
            // 
            this.Pierdere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pierdere.HeaderText = "";
            this.Pierdere.MinimumWidth = 6;
            this.Pierdere.Name = "Pierdere";
            this.Pierdere.ReadOnly = true;
            this.Pierdere.Text = "ofilire/pierdere";
            this.Pierdere.UseColumnTextForButtonValue = true;
            // 
            // ButonAdaugareFloare
            // 
            this.ButonAdaugareFloare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonAdaugareFloare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonAdaugareFloare.Location = new System.Drawing.Point(363, 572);
            this.ButonAdaugareFloare.Name = "ButonAdaugareFloare";
            this.ButonAdaugareFloare.Size = new System.Drawing.Size(252, 64);
            this.ButonAdaugareFloare.TabIndex = 4;
            this.ButonAdaugareFloare.Text = "Adaugare floare";
            this.ButonAdaugareFloare.UseVisualStyleBackColor = true;
            this.ButonAdaugareFloare.Click += new System.EventHandler(this.ButonAdaugareFloare_Click);
            // 
            // InpoiLaParcele
            // 
            this.InpoiLaParcele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InpoiLaParcele.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InpoiLaParcele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.InpoiLaParcele.Location = new System.Drawing.Point(12, 12);
            this.InpoiLaParcele.Name = "InpoiLaParcele";
            this.InpoiLaParcele.Size = new System.Drawing.Size(285, 49);
            this.InpoiLaParcele.TabIndex = 5;
            this.InpoiLaParcele.Text = "Inpoi la parcele";
            this.InpoiLaParcele.UseVisualStyleBackColor = true;
            this.InpoiLaParcele.Click += new System.EventHandler(this.InpoiLaParcele_Click);
            // 
            // ParceleLBL
            // 
            this.ParceleLBL.AutoSize = true;
            this.ParceleLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParceleLBL.Location = new System.Drawing.Point(421, 30);
            this.ParceleLBL.Name = "ParceleLBL";
            this.ParceleLBL.Size = new System.Drawing.Size(116, 55);
            this.ParceleLBL.TabIndex = 6;
            this.ParceleLBL.Text = "Flori";
            // 
            // FormaVizualizareParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 669);
            this.Controls.Add(this.ParceleLBL);
            this.Controls.Add(this.InpoiLaParcele);
            this.Controls.Add(this.ButonAdaugareFloare);
            this.Controls.Add(this.flori);
            this.Controls.Add(this.ButonIesire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaVizualizareParcela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaVizualizareParcela";
            this.Load += new System.EventHandler(this.FormaVizualizareParcela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButonIesire;
        private System.Windows.Forms.DataGridView flori;
        private System.Windows.Forms.Button ButonAdaugareFloare;
        private System.Windows.Forms.Button InpoiLaParcele;
        private System.Windows.Forms.Label ParceleLBL;
        private System.Windows.Forms.DataGridViewButtonColumn Floare;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumarLinie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumarColoana;
        private System.Windows.Forms.DataGridViewButtonColumn Vinde;
        private System.Windows.Forms.DataGridViewButtonColumn Pierdere;
    }
}