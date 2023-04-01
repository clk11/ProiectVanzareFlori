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
    public partial class FormaVanzare : Form
    {
        public int id { get; set; }
        public FormaVanzare(int i)
        {
            this.id = i;
            InitializeComponent();
        }
        private void ButonGenerareFactura_Click(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities())
            {
                bool nrtelvalid = false;
                var floare = db.t_FloarePlantata.FirstOrDefault(x => x.ID_FloarePlantata == this.id);
                if(this.nume_complet.Text.Trim().Length!=0 && this.email.Text.Trim().Length != 0)
                {
                    int nrtel = 0;
                    try
                    {
                        nrtelvalid = true;
                        int value = int.Parse(this.numar_telefon.Text.Trim());
                        if (this.numar_telefon.Text.Trim().Length == 10) nrtel = value;
                        else {MessageBox.Show("Numarul de telefon nu este valid !", "Atentie !", MessageBoxButtons.OK, MessageBoxIcon.Error);nrtelvalid = false; }
                    }
                    catch (Exception)
                    {
                        nrtelvalid = false;
                        MessageBox.Show("Numarul de telefon nu este valid !", "Atentie !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (nrtelvalid)
                    {
                        if (!db.t_Client.Any(x => x.NumeComplet == this.nume_complet.Text.Trim() && x.NumarTelefon == nrtel && x.Email == this.email.Text.Trim()))
                        {
                            db.t_Client.Add(new t_Client()
                            {
                                NumeComplet = this.nume_complet.Text.Trim(),
                                NumarTelefon = nrtel,
                                Email = this.email.Text.Trim()
                            });
                            db.SaveChanges();
                        }
                        var factura = db.t_Factura.Add(new t_Factura()
                        {
                            ID_Client = db.t_Client.FirstOrDefault(x => x.NumeComplet == this.nume_complet.Text.Trim() && x.NumarTelefon == nrtel && x.Email == this.email.Text.Trim()).ID_Client,
                            DataFacturare = DateTime.Now
                        });
                        db.SaveChanges();
                        db.t_DetaliiFactura.Add(new t_DetaliiFactura()
                        {
                            ID_Factura = factura.ID_Factura,
                            ID_FloarePlantata = floare.ID_FloarePlantata
                        });
                        db.SaveChanges();
                        db.t_FloarePlantata.Attach(floare);
                        floare.Pierduta = false; floare.Valabila = false;
                        db.Entry(floare).State = EntityState.Modified;
                        db.SaveChanges();
                        this.Close();
                    }
                }
                else MessageBox.Show("Trebuie sa completati totul !","Atentie !",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }       
    }
}
