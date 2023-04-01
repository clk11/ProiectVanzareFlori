using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_vanzare_flori
{
    public partial class FormaAdaugareFloare : Form
    {
        public int id { get; set; }
        public FormaAdaugareFloare(int i)
        {
            InitializeComponent();
            this.id = i;
        }
       

        private byte[] ConvertImageToByte(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);//Switch pentru formate , sau conditie stricta pentru png
                return ms.ToArray();
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK) this.pictureBox.ImageLocation = ofd.FileName;
            }
        }
        bool verificarePozitii()
        {
            using (dbEntities db = new dbEntities())
            {
                if (db.t_FloarePlantata.Any(x => x.pozX == this.numar_linie.Value
                && x.pozY == this.numar_coloana.Value
                && x.Valabila && x.NumarParcela == this.id)) return false;
                else return true;
            }
        }
        bool verificareInput()
        {
            if (this.nume_floare.Text.Trim().Length != 0 &&
                this.soi.Text.Trim().Length != 0 &&
                this.clasificare.Text.Trim().Length != 0 &&
                this.origine.Text.Trim().Length != 0 &&
                this.Hibridizator.Text.Trim().Length != 0 &&
                this.forma_floare.Text.Trim().Length != 0 &&
                this.descriere.Text.Trim().Length != 0 &&
                this.culori.Items.Count != 0 &&
                this.parfumuri.Items.Count != 0) return true;
            return false;
        }
        private void FormaAdaugareFloare_Load(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities())
            {
                var item = db.t_Parcela.FirstOrDefault(x => x.ID_Parcela == this.id);
                this.numar_linie.Maximum = item.NumarLinii;
                this.numar_coloana.Maximum = item.NumarColoane;
                this.luna.Maximum = 12;
                this.saptamana.Maximum = 5;
                //Curata liste
                curata_culori.Click += delegate { this.culori.Items.Clear(); };
                curatare_parfumuri.Click += delegate { this.parfumuri.Items.Clear(); };
                curata_perioada_inflorire.Click += delegate { this.perioade_inflorire.Items.Clear(); };
                //Adaugare in liste
                adauga_culoare.Click += delegate
                {
                    if (this.culoare.Text.Trim().Length != 0)
                    {
                        this.culori.Items.Add(this.culoare.Text.Trim());
                        this.culoare.Clear();
                    }
                    else MessageBox.Show("Culoarea nu trebuie sa fie nula !", "Atentie !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                };
                adauga_parfum.Click += delegate
                {
                    if (this.parfum.Text.Trim().Length != 0)
                    {
                        this.parfumuri.Items.Add(this.parfum.Text.Trim());
                        this.parfum.Clear();
                    }
                    else MessageBox.Show("Parfumul nu trebuie sa fie nul !", "Atentie !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                };
                adauga_perioada_inflorire.Click += delegate
                {
                    this.perioade_inflorire.Items.Add(this.luna.Value + "|" + this.saptamana.Value);
                    this.luna.Value = 1; this.saptamana.Value = 1;
                };
            }
        }

        private void adauga_floare_Click(object sender, EventArgs e)
        {
            if (verificareInput())
            {
                using (dbEntities db = new dbEntities())
                {
                    if (verificarePozitii())
                    {
                        if (!db.t_DetaliiFloare.Any(x => x.NumeFloare == this.nume_floare.Text.Trim() &&
                         x.Soi == this.soi.Text.Trim() && x.Clasificare == this.clasificare.Text.Trim() && x.Origine == this.origine.Text.Trim()))
                        {
                            db.t_DetaliiFloare.Add(new t_DetaliiFloare()
                            {
                                Soi = this.soi.Text.Trim(),
                                NumeFloare = this.nume_floare.Text.Trim(),
                                Clasificare = this.clasificare.Text.Trim(),
                                Origine = this.origine.Text.Trim()
                            });
                            db.SaveChanges();
                        }
                        var floareAdaugata = db.t_FloarePlantata.Add(new t_FloarePlantata()
                        {
                            DataPlantare = DateTime.Now,
                            Hibridizator = this.Hibridizator.Text.Trim(),
                            Inaltime = int.Parse(this.inaltime.Value.ToString()),
                            pozX = int.Parse(this.numar_linie.Value.ToString()),
                            pozY = int.Parse(this.numar_coloana.Value.ToString()),
                            PretAchizitie = double.Parse(this.pret_achizitie.Value.ToString()),
                            PretVanzare = double.Parse(this.pret_vanzare.Value.ToString()),
                            Descriere = this.descriere.Text.Trim(),
                            FormaFloare = this.forma_floare.Text.Trim(),
                            Imagine = this.ConvertImageToByte(this.pictureBox.Image),
                            Valabila = true,
                            Pierduta = false,
                            NumarParcela = this.id,
                            ID_DetaliiFloare = db.t_DetaliiFloare.FirstOrDefault(x => x.NumeFloare == this.nume_floare.Text.Trim() &&
                          x.Soi == this.soi.Text.Trim() && x.Clasificare == this.clasificare.Text.Trim() && x.Origine == this.origine.Text.Trim()).ID_DetaliiFloare
                        });
                        db.SaveChanges();
                        foreach (string item in culori.Items)
                        {
                            if (!db.t_Culoare.Any(x => x.Culoare == item))
                            {
                                db.t_Culoare.Add(new t_Culoare() { Culoare = item });
                                db.SaveChanges();
                            }
                            db.t_CuloareFloare.Add(new t_CuloareFloare()
                            {
                                ID_Culoare = db.t_Culoare.FirstOrDefault(x => x.Culoare == item).ID_Culoare,
                                ID_FloarePlantata = floareAdaugata.ID_FloarePlantata
                            });
                            db.SaveChanges();
                        }
                        foreach (string item in parfumuri.Items)
                        {
                            if (!db.t_Parfum.Any(x => x.Parfum == item))
                            {
                                db.t_Parfum.Add(new t_Parfum() { Parfum = item });
                                db.SaveChanges();
                            }
                            db.t_ParfumFloare.Add(new t_ParfumFloare()
                            {
                                ID_Parfum = db.t_Parfum.FirstOrDefault(x => x.Parfum == item).ID_Parfum,
                                ID_FloarePlantata = floareAdaugata.ID_FloarePlantata
                            });
                            db.SaveChanges();
                        }
                        foreach (string item in perioade_inflorire.Items)
                        {
                            string[] spl = item.Split('|');
                            int sp1 = int.Parse(spl[0]);
                            int sp2 = int.Parse(spl[1]);
                            if (!db.t_Perioada.Any(x => x.Luna == sp1 && x.Saptamana == sp2))
                            {
                                db.t_Perioada.Add(new t_Perioada() { Luna = sp1, Saptamana = sp2 });
                                db.SaveChanges();
                            }
                            db.t_PerioadaInflorire.Add(new t_PerioadaInflorire()
                            {
                                ID_Perioada = db.t_Perioada.FirstOrDefault(x => x.Luna == sp1 && x.Saptamana == sp2).ID_Perioada,
                                ID_FloarePlantata = floareAdaugata.ID_FloarePlantata
                            });
                            db.SaveChanges();

                        }
                        this.Close();
                    }
                    else MessageBox.Show("Exista deja o floare in locatia resepectiva !","Atentie !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } else MessageBox.Show("Trebuie sa completati totul", "Atentie !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
