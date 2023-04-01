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
    public partial class FormaMeniu : Form
    {
        public FormaMeniu()
        {
            InitializeComponent();
        }

        private void ButonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ButonDespreAutor.Click += delegate { new FormaDespreAutor().ShowDialog();  };
            this.ButonPlantare.Click += delegate {
                this.Hide();
                new FormaParcele().ShowDialog();
                this.Close();
            };
            this.ButonVenituri.Click += delegate {
                this.Hide();
                new FormaVenituri().ShowDialog();
                this.Close();
            };
        }
               
    }
}
