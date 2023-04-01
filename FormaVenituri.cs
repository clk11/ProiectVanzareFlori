using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace proiect_vanzare_flori
{
    public partial class FormaVenituri : Form
    {
        public int counter { get; set; }
        public FormaVenituri()
        {
            InitializeComponent();
        }

        private void ButonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void venituri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                using (dbEntities db = new dbEntities())
                {
                    int id = int.Parse(this.venituri.Rows[e.RowIndex].Cells[0].Value.ToString());
                    new FormaVizualizareFloare(db.t_DetaliiFactura.FirstOrDefault(x => x.ID_DetaliiFactura == id).ID_FloarePlantata).ShowDialog();
                }
            }
            if (e.ColumnIndex == 2)
            {
                using (dbEntities db = new dbEntities())
                {
                    int id = int.Parse(this.venituri.Rows[e.RowIndex].Cells[0].Value.ToString());
                    new FormaVizualizareClient(db.t_DetaliiFactura.FirstOrDefault(x=>x.ID_DetaliiFactura == id).t_Factura.ID_Client).ShowDialog();
                }
            }
        }

        private void FormaVenituri_Load(object sender, EventArgs e)
        {
            this.ButonInpoiLaMeniu.Click += delegate
            {
                this.Hide();
                new FormaMeniu().ShowDialog();
                this.Close();
            };
            using (dbEntities db = new dbEntities())
            {
                this.venituri.Rows.Clear();
                this.pierderi.Rows.Clear();
                var listaVenituri = db.t_DetaliiFactura.Where(x => x.t_FloarePlantata.Pierduta == false).Select(y => y);
                int currentRow = 0;
                foreach (var item in listaVenituri)
                {
                    this.venituri.Rows.Add();
                    venituri.Rows[currentRow].Cells[0].Value = item.ID_DetaliiFactura;
                    venituri.Rows[currentRow].Cells[3].Value = String.Format("{0:d}", item.t_Factura.DataFacturare);
                    venituri.Rows[currentRow++].Cells[4].Value = (item.t_FloarePlantata.PretVanzare - item.t_FloarePlantata.PretAchizitie) + " lei";
                }
                var listaPierderi = db.t_FloarePlantata.Where(x => x.Pierduta == true).Select(y => y);
                currentRow = 0;
                foreach (var item in listaPierderi)
                {
                    this.pierderi.Rows.Add();
                    pierderi.Rows[currentRow].Cells[1].Value = -1 * item.PretAchizitie + " lei ";
                    pierderi.Rows[currentRow++].Cells[2].Value = item.ID_FloarePlantata;
                }
            }
        }

        private void pierderi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                int id = int.Parse(this.pierderi.Rows[e.RowIndex].Cells[2].Value.ToString());
                new FormaVizualizareFloare(id).ShowDialog();
            }
        }      
        void animatie()
        {
            this.Sageata.Visible = true;
            this.rezultat.Visible = true;
            this.timer.Start();
        }
        private void Suma_investitii_Click(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities())
            {
                animatie();
                this.rezultat.Text = db.t_FloarePlantata.Select(x => x.PretAchizitie).ToList().Sum().ToString() + " lei";
            }
        }

        private void Venituri_incasate_Click(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities())
            {
                animatie();
                if (!this.verificareParam.Checked)
                    this.rezultat.Text = db.t_DetaliiFactura.Where(x => x.t_FloarePlantata.Valabila == false && x.t_FloarePlantata.Pierduta == false).Select(y => y.t_FloarePlantata.PretVanzare - y.t_FloarePlantata.PretAchizitie).Sum().ToString() + " lei";
                else
                    this.rezultat.Text = db.t_DetaliiFactura.Where(x => x.t_FloarePlantata.Valabila == false && x.t_FloarePlantata.Pierduta == false && x.t_Factura.DataFacturare >= this.primaData.Value && x.t_Factura.DataFacturare <= this.aDouaData.Value).Select(y => y.t_FloarePlantata.PretVanzare - y.t_FloarePlantata.PretAchizitie).ToList().Sum().ToString() + " lei";
            }
        }

        private void Pierderi_incasate_Click(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities())
            {
                animatie();
                if (!this.verificareParam.Checked)
                    this.rezultat.Text = db.t_FloarePlantata.Where(x => x.Pierduta == true).Select(x => x.PretAchizitie).ToList().Sum().ToString() + " lei";
                else
                    this.rezultat.Text = db.t_FloarePlantata.Where(x => x.Pierduta == true && x.DataPierdere >= this.primaData.Value && x.DataPierdere <= this.aDouaData.Value).Select(x => x.PretAchizitie).ToList().Sum().ToString() + " lei";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.counter > 1)
            {
                this.Sageata.ForeColor = Color.SkyBlue;
                this.counter = 0;
                this.timer.Stop();
                this.Sageata.Visible = false;
                return;
            }
            this.Sageata.ForeColor = Color.Red;
            this.counter++;
        }
        void Afiseaza(bool valoare)
        {
            this.dat1lbl.Visible = valoare;
            this.dat2lbl.Visible = valoare;
            this.primaData.Visible = valoare;
            this.aDouaData.Visible = valoare;
        }
        private void verificareParam_CheckedChanged(object sender, EventArgs e)
        {
            this.rezultat.Text = "";
            if (this.verificareParam.Checked) Afiseaza(true);
            else Afiseaza(false);
        }
    }
}
