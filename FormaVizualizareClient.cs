using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_vanzare_flori
{
    public partial class FormaVizualizareClient : Form
    {
        public int id { get; set; }
        public FormaVizualizareClient(int i)
        {
            this.id = i;
            InitializeComponent();
        }

        private void FormaVizualizareClient_Load(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities())
            {
                var client = db.t_Client.FirstOrDefault(x => x.ID_Client == this.id);
                this.numar_telefon.Text = client.NumarTelefon.ToString();
                this.nume_complet.Text = client.NumeComplet;
                this.email.Text = client.Email;
            }
        }
    }
}
