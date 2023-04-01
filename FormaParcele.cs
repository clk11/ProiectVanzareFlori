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
    public partial class FormaParcele : Form
    {
        public FormaParcele()
        {
            InitializeComponent();
        }

        private void ButonAdaugareParcela_Click(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities())
            {
                int mP = db.t_Parcela.ToList().Count == 0?1 : db.t_Parcela.ToList().Max(x => x.NumarParcela)+1;
                db.t_Parcela.Add(new t_Parcela()
                {
                    NumarParcela = mP,
                    NumarLinii = int.Parse(this.NumarLiniiN.Value.ToString()),
                    NumarColoane = int.Parse(this.NumarColoaneN.Value.ToString())
                });
                db.SaveChanges();
                LoadData();
            }
        }

        private void ButonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void LoadData()
        {
            using (dbEntities db = new dbEntities())
            {
                int currentRow = 0;
                foreach (var item in db.t_Parcela.ToList())
                {
                    if (currentRow >= parcele.Rows.Count) parcele.Rows.Add();
                    parcele.Rows[currentRow].Cells[0].Value = item.NumarParcela;
                    parcele.Rows[currentRow].Cells[1].Value = item.NumarLinii;
                    parcele.Rows[currentRow].Cells[2].Value = item.NumarColoane;
                    currentRow++;
                }
            }
        }
        private void FormaPlantare_Load(object sender, EventArgs e)
        {
            this.ButonInpoiLaMeniu.Click += delegate
            {
                this.Hide();
                new FormaMeniu().ShowDialog();
                this.Close();
            };
            this.LoadData();
        }
            
        private void parcele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                using (dbEntities db = new dbEntities())
                {
                    int i = int.Parse(this.parcele.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int id = db.t_Parcela.FirstOrDefault(x => x.NumarParcela == i).ID_Parcela;
                    this.Hide();
                    new FormaVizualizareParcela(id).ShowDialog();
                    this.Close();
                }
            }else if(e.ColumnIndex == 4)
            {
                if ((MessageBox.Show("Sunteti sigur(a) ca doriti sa faceti asta ?","Atentie !",MessageBoxButtons.YesNo,MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    using (dbEntities db = new dbEntities())
                    {
                        int i = int.Parse(this.parcele.Rows[e.RowIndex].Cells[0].Value.ToString());
                        if (!db.t_FloarePlantata.Any(x=>x.Valabila == true))
                        {
                            t_Parcela item = db.t_Parcela.FirstOrDefault(x => x.NumarParcela == i);
                            db.t_Parcela.Attach(item);
                            db.t_Parcela.Remove(item);
                            db.SaveChanges();
                            this.parcele.Rows.Remove(this.parcele.Rows[e.RowIndex]);
                        }
                        else MessageBox.Show("Aveti deja flori plantate pe pamantul respectiv .","Atentie !",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
