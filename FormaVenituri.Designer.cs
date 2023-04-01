
namespace proiect_vanzare_flori
{
    partial class FormaVenituri
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
            this.ButonIesire = new System.Windows.Forms.Button();
            this.venituri = new System.Windows.Forms.DataGridView();
            this.ID_DetaliiFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floare = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Client = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DataFacturare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.ButonInpoiLaMeniu = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pierderi = new System.Windows.Forms.DataGridView();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Floare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dat1lbl = new System.Windows.Forms.Label();
            this.primaData = new System.Windows.Forms.DateTimePicker();
            this.dat2lbl = new System.Windows.Forms.Label();
            this.aDouaData = new System.Windows.Forms.DateTimePicker();
            this.verificareParam = new System.Windows.Forms.CheckBox();
            this.Sageata = new System.Windows.Forms.Label();
            this.rezultat = new System.Windows.Forms.Label();
            this.Pierderi_incasate = new System.Windows.Forms.Button();
            this.Venituri_incasate = new System.Windows.Forms.Button();
            this.Suma_investitii = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.venituri)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pierderi)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButonIesire
            // 
            this.ButonIesire.BackColor = System.Drawing.Color.Red;
            this.ButonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonIesire.Location = new System.Drawing.Point(909, 0);
            this.ButonIesire.Name = "ButonIesire";
            this.ButonIesire.Size = new System.Drawing.Size(39, 41);
            this.ButonIesire.TabIndex = 1;
            this.ButonIesire.Text = "X";
            this.ButonIesire.UseVisualStyleBackColor = false;
            this.ButonIesire.Click += new System.EventHandler(this.ButonIesire_Click);
            // 
            // venituri
            // 
            this.venituri.AllowUserToAddRows = false;
            this.venituri.AllowUserToDeleteRows = false;
            this.venituri.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.venituri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.venituri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DetaliiFactura,
            this.Floare,
            this.Client,
            this.DataFacturare,
            this.Pret});
            this.venituri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.venituri.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.venituri.Location = new System.Drawing.Point(3, 131);
            this.venituri.Name = "venituri";
            this.venituri.ReadOnly = true;
            this.venituri.RowHeadersWidth = 51;
            this.venituri.RowTemplate.Height = 24;
            this.venituri.Size = new System.Drawing.Size(945, 448);
            this.venituri.TabIndex = 2;
            this.venituri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.venituri_CellContentClick);
            // 
            // ID_DetaliiFactura
            // 
            this.ID_DetaliiFactura.HeaderText = "DetaliiFacture";
            this.ID_DetaliiFactura.MinimumWidth = 6;
            this.ID_DetaliiFactura.Name = "ID_DetaliiFactura";
            this.ID_DetaliiFactura.ReadOnly = true;
            this.ID_DetaliiFactura.Visible = false;
            this.ID_DetaliiFactura.Width = 125;
            // 
            // Floare
            // 
            this.Floare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Floare.HeaderText = "";
            this.Floare.MinimumWidth = 6;
            this.Floare.Name = "Floare";
            this.Floare.ReadOnly = true;
            this.Floare.Text = "Floare";
            this.Floare.UseColumnTextForButtonValue = true;
            // 
            // Client
            // 
            this.Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Client.HeaderText = "";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Text = "Client";
            this.Client.UseColumnTextForButtonValue = true;
            // 
            // DataFacturare
            // 
            this.DataFacturare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataFacturare.HeaderText = "Data facturare";
            this.DataFacturare.MinimumWidth = 6;
            this.DataFacturare.Name = "DataFacturare";
            this.DataFacturare.ReadOnly = true;
            // 
            // Pret
            // 
            this.Pret.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pret.HeaderText = "Profit";
            this.Pret.MinimumWidth = 6;
            this.Pret.Name = "Pret";
            this.Pret.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "Venituri";
            // 
            // ButonInpoiLaMeniu
            // 
            this.ButonInpoiLaMeniu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonInpoiLaMeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonInpoiLaMeniu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButonInpoiLaMeniu.Location = new System.Drawing.Point(6, 6);
            this.ButonInpoiLaMeniu.Name = "ButonInpoiLaMeniu";
            this.ButonInpoiLaMeniu.Size = new System.Drawing.Size(130, 47);
            this.ButonInpoiLaMeniu.TabIndex = 8;
            this.ButonInpoiLaMeniu.Text = "Meniu";
            this.ButonInpoiLaMeniu.UseVisualStyleBackColor = true;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(959, 611);
            this.tabs.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButonInpoiLaMeniu);
            this.tabPage1.Controls.Add(this.ButonIesire);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.venituri);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(951, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Venituri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pierderi);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(951, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pierderi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pierderi";
            // 
            // pierderi
            // 
            this.pierderi.AllowUserToAddRows = false;
            this.pierderi.AllowUserToDeleteRows = false;
            this.pierderi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pierderi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pierderi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewButtonColumn1,
            this.dataGridViewTextBoxColumn3,
            this.ID_Floare});
            this.pierderi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pierderi.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pierderi.Location = new System.Drawing.Point(3, 108);
            this.pierderi.Name = "pierderi";
            this.pierderi.ReadOnly = true;
            this.pierderi.RowHeadersWidth = 51;
            this.pierderi.RowTemplate.Height = 24;
            this.pierderi.Size = new System.Drawing.Size(945, 471);
            this.pierderi.TabIndex = 3;
            this.pierderi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pierderi_CellContentClick);
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Text = "Detalii floare pierduta";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Pierdere";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ID_Floare
            // 
            this.ID_Floare.HeaderText = "ID_Floare";
            this.ID_Floare.MinimumWidth = 6;
            this.ID_Floare.Name = "ID_Floare";
            this.ID_Floare.ReadOnly = true;
            this.ID_Floare.Visible = false;
            this.ID_Floare.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dat1lbl);
            this.tabPage3.Controls.Add(this.primaData);
            this.tabPage3.Controls.Add(this.dat2lbl);
            this.tabPage3.Controls.Add(this.aDouaData);
            this.tabPage3.Controls.Add(this.verificareParam);
            this.tabPage3.Controls.Add(this.Sageata);
            this.tabPage3.Controls.Add(this.rezultat);
            this.tabPage3.Controls.Add(this.Pierderi_incasate);
            this.tabPage3.Controls.Add(this.Venituri_incasate);
            this.tabPage3.Controls.Add(this.Suma_investitii);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(951, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Afisare totaluri";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dat1lbl
            // 
            this.dat1lbl.AutoSize = true;
            this.dat1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dat1lbl.Location = new System.Drawing.Point(293, 176);
            this.dat1lbl.Name = "dat1lbl";
            this.dat1lbl.Size = new System.Drawing.Size(99, 29);
            this.dat1lbl.TabIndex = 4;
            this.dat1lbl.Text = "Data 1 : ";
            this.dat1lbl.Visible = false;
            // 
            // primaData
            // 
            this.primaData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primaData.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.primaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primaData.Location = new System.Drawing.Point(398, 176);
            this.primaData.Name = "primaData";
            this.primaData.Size = new System.Drawing.Size(351, 30);
            this.primaData.TabIndex = 3;
            this.primaData.Value = new System.DateTime(2021, 5, 15, 0, 0, 0, 0);
            this.primaData.Visible = false;
            // 
            // dat2lbl
            // 
            this.dat2lbl.AutoSize = true;
            this.dat2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dat2lbl.Location = new System.Drawing.Point(293, 263);
            this.dat2lbl.Name = "dat2lbl";
            this.dat2lbl.Size = new System.Drawing.Size(99, 29);
            this.dat2lbl.TabIndex = 4;
            this.dat2lbl.Text = "Data 2 : ";
            this.dat2lbl.Visible = false;
            // 
            // aDouaData
            // 
            this.aDouaData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDouaData.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.aDouaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDouaData.Location = new System.Drawing.Point(398, 263);
            this.aDouaData.Name = "aDouaData";
            this.aDouaData.Size = new System.Drawing.Size(351, 30);
            this.aDouaData.TabIndex = 3;
            this.aDouaData.Value = new System.DateTime(2021, 5, 15, 0, 0, 0, 0);
            this.aDouaData.Visible = false;
            // 
            // verificareParam
            // 
            this.verificareParam.AutoSize = true;
            this.verificareParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verificareParam.Location = new System.Drawing.Point(563, 34);
            this.verificareParam.Name = "verificareParam";
            this.verificareParam.Size = new System.Drawing.Size(316, 40);
            this.verificareParam.TabIndex = 2;
            this.verificareParam.Text = "Afisare parametrizata";
            this.verificareParam.UseVisualStyleBackColor = true;
            this.verificareParam.CheckedChanged += new System.EventHandler(this.verificareParam_CheckedChanged);
            // 
            // Sageata
            // 
            this.Sageata.AutoSize = true;
            this.Sageata.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sageata.Location = new System.Drawing.Point(441, 468);
            this.Sageata.Name = "Sageata";
            this.Sageata.Size = new System.Drawing.Size(167, 91);
            this.Sageata.TabIndex = 1;
            this.Sageata.Text = "--->";
            this.Sageata.Visible = false;
            // 
            // rezultat
            // 
            this.rezultat.AutoSize = true;
            this.rezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezultat.Location = new System.Drawing.Point(677, 483);
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(202, 55);
            this.rezultat.TabIndex = 1;
            this.rezultat.Text = "suma lei";
            this.rezultat.Visible = false;
            // 
            // Pierderi_incasate
            // 
            this.Pierderi_incasate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pierderi_incasate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pierderi_incasate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Pierderi_incasate.Location = new System.Drawing.Point(22, 352);
            this.Pierderi_incasate.Name = "Pierderi_incasate";
            this.Pierderi_incasate.Size = new System.Drawing.Size(185, 81);
            this.Pierderi_incasate.TabIndex = 0;
            this.Pierderi_incasate.Text = "Pierderi incasate";
            this.Pierderi_incasate.UseVisualStyleBackColor = true;
            this.Pierderi_incasate.Click += new System.EventHandler(this.Pierderi_incasate_Click);
            // 
            // Venituri_incasate
            // 
            this.Venituri_incasate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Venituri_incasate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Venituri_incasate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Venituri_incasate.Location = new System.Drawing.Point(22, 231);
            this.Venituri_incasate.Name = "Venituri_incasate";
            this.Venituri_incasate.Size = new System.Drawing.Size(185, 81);
            this.Venituri_incasate.TabIndex = 0;
            this.Venituri_incasate.Text = "Venituri incasate";
            this.Venituri_incasate.UseVisualStyleBackColor = true;
            this.Venituri_incasate.Click += new System.EventHandler(this.Venituri_incasate_Click);
            // 
            // Suma_investitii
            // 
            this.Suma_investitii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Suma_investitii.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma_investitii.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Suma_investitii.Location = new System.Drawing.Point(22, 122);
            this.Suma_investitii.Name = "Suma_investitii";
            this.Suma_investitii.Size = new System.Drawing.Size(185, 81);
            this.Suma_investitii.TabIndex = 0;
            this.Suma_investitii.Text = "Suma investitii";
            this.Suma_investitii.UseVisualStyleBackColor = true;
            this.Suma_investitii.Click += new System.EventHandler(this.Suma_investitii_Click);
            // 
            // timer
            // 
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormaVenituri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 611);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaVenituri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaVenituri";
            this.Load += new System.EventHandler(this.FormaVenituri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.venituri)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pierderi)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButonIesire;
        private System.Windows.Forms.DataGridView venituri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButonInpoiLaMeniu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DetaliiFactura;
        private System.Windows.Forms.DataGridViewButtonColumn Floare;
        private System.Windows.Forms.DataGridViewButtonColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFacturare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView pierderi;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Floare;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label Sageata;
        private System.Windows.Forms.Label rezultat;
        private System.Windows.Forms.Button Pierderi_incasate;
        private System.Windows.Forms.Button Venituri_incasate;
        private System.Windows.Forms.Button Suma_investitii;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox verificareParam;
        private System.Windows.Forms.Label dat1lbl;
        private System.Windows.Forms.DateTimePicker primaData;
        private System.Windows.Forms.Label dat2lbl;
        private System.Windows.Forms.DateTimePicker aDouaData;
    }
}