
namespace proiect_vanzare_flori
{
    partial class FormaMeniu
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
            this.ButonPlantare = new System.Windows.Forms.Button();
            this.ButonVenituri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButonDespreAutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButonIesire
            // 
            this.ButonIesire.BackColor = System.Drawing.Color.Red;
            this.ButonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonIesire.Location = new System.Drawing.Point(564, -2);
            this.ButonIesire.Name = "ButonIesire";
            this.ButonIesire.Size = new System.Drawing.Size(39, 41);
            this.ButonIesire.TabIndex = 0;
            this.ButonIesire.Text = "X";
            this.ButonIesire.UseVisualStyleBackColor = false;
            this.ButonIesire.Click += new System.EventHandler(this.ButonIesire_Click);
            // 
            // ButonPlantare
            // 
            this.ButonPlantare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonPlantare.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonPlantare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButonPlantare.Location = new System.Drawing.Point(63, 176);
            this.ButonPlantare.Name = "ButonPlantare";
            this.ButonPlantare.Size = new System.Drawing.Size(169, 61);
            this.ButonPlantare.TabIndex = 1;
            this.ButonPlantare.Text = "Plantare";
            this.ButonPlantare.UseVisualStyleBackColor = true;
            // 
            // ButonVenituri
            // 
            this.ButonVenituri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonVenituri.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonVenituri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ButonVenituri.Location = new System.Drawing.Point(286, 176);
            this.ButonVenituri.Name = "ButonVenituri";
            this.ButonVenituri.Size = new System.Drawing.Size(249, 61);
            this.ButonVenituri.TabIndex = 1;
            this.ButonVenituri.Text = "Contabilitate";
            this.ButonVenituri.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producere si Comercializare flori";
            // 
            // ButonDespreAutor
            // 
            this.ButonDespreAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonDespreAutor.Location = new System.Drawing.Point(0, 0);
            this.ButonDespreAutor.Name = "ButonDespreAutor";
            this.ButonDespreAutor.Size = new System.Drawing.Size(113, 33);
            this.ButonDespreAutor.TabIndex = 3;
            this.ButonDespreAutor.Text = "Despre autor";
            this.ButonDespreAutor.UseVisualStyleBackColor = true;
            // 
            // FormaMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(604, 261);
            this.Controls.Add(this.ButonDespreAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButonVenituri);
            this.Controls.Add(this.ButonPlantare);
            this.Controls.Add(this.ButonIesire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaMeniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButonIesire;
        private System.Windows.Forms.Button ButonPlantare;
        private System.Windows.Forms.Button ButonVenituri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButonDespreAutor;
    }
}

