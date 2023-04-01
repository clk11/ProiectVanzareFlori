
namespace proiect_vanzare_flori
{
    partial class FormaVanzare
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
            this.label1 = new System.Windows.Forms.Label();
            this.nume_complet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numar_telefon = new System.Windows.Forms.TextBox();
            this.ButonGenerareFactura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume complet : ";
            // 
            // nume_complet
            // 
            this.nume_complet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume_complet.Location = new System.Drawing.Point(224, 79);
            this.nume_complet.Name = "nume_complet";
            this.nume_complet.Size = new System.Drawing.Size(313, 34);
            this.nume_complet.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email : ";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(224, 145);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(313, 34);
            this.email.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numar telefon : ";
            // 
            // numar_telefon
            // 
            this.numar_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numar_telefon.Location = new System.Drawing.Point(224, 213);
            this.numar_telefon.Name = "numar_telefon";
            this.numar_telefon.Size = new System.Drawing.Size(313, 34);
            this.numar_telefon.TabIndex = 2;
            // 
            // ButonGenerareFactura
            // 
            this.ButonGenerareFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonGenerareFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonGenerareFactura.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButonGenerareFactura.Location = new System.Drawing.Point(249, 317);
            this.ButonGenerareFactura.Name = "ButonGenerareFactura";
            this.ButonGenerareFactura.Size = new System.Drawing.Size(288, 89);
            this.ButonGenerareFactura.TabIndex = 3;
            this.ButonGenerareFactura.Text = "Genereaza factura";
            this.ButonGenerareFactura.UseVisualStyleBackColor = true;
            this.ButonGenerareFactura.Click += new System.EventHandler(this.ButonGenerareFactura_Click);
            // 
            // FormaVanzare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 418);
            this.Controls.Add(this.ButonGenerareFactura);
            this.Controls.Add(this.numar_telefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nume_complet);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaVanzare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nume_complet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numar_telefon;
        private System.Windows.Forms.Button ButonGenerareFactura;
    }
}