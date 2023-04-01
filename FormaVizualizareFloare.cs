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
    public partial class FormaVizualizareFloare : Form
    {
        public int id { get; set; }
        public FormaVizualizareFloare(int i)
        {
            InitializeComponent();
            this.id = i;
        }

        public Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void FormaVizualizareFloare_Load(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities())
            {
                var floare = db.t_FloarePlantata.FirstOrDefault(x => x.ID_FloarePlantata == this.id);
                this.forma_floare.Text = floare.FormaFloare;
                this.clasificare.Text = floare.t_DetaliiFloare.Clasificare;
                this.origine.Text = floare.t_DetaliiFloare.Origine;
                this.hibridizator.Text = floare.Hibridizator;
                this.inaltime.Text = floare.Inaltime.ToString();
                this.nume_floare.Text = floare.t_DetaliiFloare.NumeFloare;
                this.locatie.Text = "Parcela " + floare.NumarParcela + ", linia " + floare.pozX + ", coloana " + floare.pozY;
                this.descriere_floare.Text = floare.Descriere;
                foreach (var item in floare.t_CuloareFloare)
                    this.culori.Items.Add(item.t_Culoare.Culoare);
                foreach (var item in floare.t_PerioadaInflorire)
                    this.perioade_inflorire.Items.Add("Luna : " + item.t_Perioada.Luna + " | " + " Saptamana : " + item.t_Perioada.Saptamana);
                foreach (var item in floare.t_ParfumFloare)
                    this.parfumuri.Items.Add(item.t_Parfum.Parfum);
                this.pret_achizitie.Text = floare.PretAchizitie.ToString() + " lei";
                this.pret_vanzare.Text = floare.PretVanzare.ToString() + " lei";
                this.data_plantare.Text = String.Format("{0:d}", floare.DataPlantare);
                this.imagine_floare.Image = ConvertBinaryToImage(floare.Imagine);
                var factura = db.t_DetaliiFactura.FirstOrDefault(x => x.ID_FloarePlantata == floare.ID_FloarePlantata);
                if (floare.Valabila) { this.stare_floare.Text = "Inca de vanzare"; this.data_vanzare.Text = "Data pierdere/vanzare : - "; }
                else
                {
                    if (floare.Valabila == false && floare.Pierduta == false)
                    {
                        this.stare_floare.Text = "Vanduta";
                        this.data_vanzare.Text = "Data vanzare : " + String.Format("{0:d}", factura.t_Factura.DataFacturare);
                    }
                    else
                    {
                        this.stare_floare.Text = "Pierduta";
                        this.data_vanzare.Text = "Data pierdere : " + String.Format("{0:d}", floare.DataPierdere);
                    }
                }
            }
        }      
    }
}
