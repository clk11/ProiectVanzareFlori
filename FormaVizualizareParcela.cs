using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_vanzare_flori
{
    public partial class FormaVizualizareParcela : Form
    {
        public int id { get; set; }
        public FormaVizualizareParcela(int i)
        {
            id = i;
            InitializeComponent();
        }

        private void ButonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButonAdaugareFloare_Click(object sender, EventArgs e)
        {
            new FormaAdaugareFloare(this.id).ShowDialog();
            this.LoadData();
        }

        private void Flori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                using (dbEntities db = new dbEntities())
                {
                    int idFloare = int.Parse(this.flori.Rows[e.RowIndex].Cells[1].Value.ToString());
                    new FormaVizualizareFloare(db.t_FloarePlantata.FirstOrDefault(x=>x.ID_FloarePlantata == idFloare).ID_FloarePlantata).ShowDialog();
                }
            }
            if (e.ColumnIndex == 4)
            {
                using (dbEntities db = new dbEntities())
                {

                    int idFloare = int.Parse(this.flori.Rows[e.RowIndex].Cells[1].Value.ToString());
                    new FormaVanzare(idFloare).ShowDialog();
                    this.LoadData();
                }
            }
            else if(e.ColumnIndex == 5) {
                using (dbEntities db = new dbEntities())
                {
                    if (MessageBox.Show("Sunteti sigur(a) ?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idFloare = int.Parse(this.flori.Rows[e.RowIndex].Cells[1].Value.ToString());
                        var floare = db.t_FloarePlantata.FirstOrDefault(x => x.ID_FloarePlantata == idFloare);
                        db.t_FloarePlantata.Attach(floare);
                        floare.Pierduta = true;
                        floare.Valabila = false;
                        floare.DataPierdere = DateTime.Now;
                        db.Entry(floare).State = EntityState.Modified;
                        db.SaveChanges();
                        this.LoadData();
                    }
                }
            }
        }

        private void InpoiLaParcele_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormaParcele().ShowDialog();
            this.Close();
        }
        void LoadData()
        {
            using (dbEntities db = new dbEntities())
            {
                this.flori.Rows.Clear();
                int currentRow = 0;
                var elements = db.t_FloarePlantata.Where(x => x.NumarParcela == this.id && x.Valabila == true).Select(y => y).ToList();
                foreach (t_FloarePlantata item in elements)
                {
                    this.flori.Rows.Add();
                    this.flori.Rows[currentRow].Cells[1].Value = item.ID_FloarePlantata;
                    this.flori.Rows[currentRow].Cells[2].Value = item.pozX;
                    this.flori.Rows[currentRow++].Cells[3].Value = item.pozY;
                }
            }
        }
        private void FormaVizualizareParcela_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}
