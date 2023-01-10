using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaElectronique
{
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Owner = this;
            F1.Show();
            this.Hide();
        }


        private void txtCode1_Enter(object sender, EventArgs e)
        {
            if (txtCode1.Text == "Code")
            {
                txtCode1.Text = "";
                txtCode1.ForeColor = Color.Black;
            }
        }

        private void txtCode1_Leave(object sender, EventArgs e)
        {
            if (txtCode1.Text == "")
            {
                txtCode1.Text = "Code";
                txtCode1.ForeColor = Color.Silver;
            }
        }

        private void txtTitre1_Enter(object sender, EventArgs e)
        {
            if (txtTitre1.Text == "Titre")
            {
                txtTitre1.Text = "";
                txtTitre1.ForeColor = Color.Black;
            }
        }

        private void txtTitre1_Leave(object sender, EventArgs e)
        {
            if (txtTitre1.Text == "")
            {
                txtTitre1.Text = "Titre";
                txtTitre1.ForeColor = Color.Silver;
            }
        }

        private void txtLieu1_Enter(object sender, EventArgs e)
        {
            if (txtLieu1.Text == "Lieu")
              {
                txtLieu1.Text = "";
                txtLieu1.ForeColor = Color.Black;
              }
        }

        private void txtLieu1_Leave(object sender, EventArgs e)
        {
           if (txtLieu1.Text == "")
            {
                txtLieu1.Text = "Lieu";
                txtLieu1.ForeColor = Color.Silver;
            }
        }

        private void txtDescrib_Enter(object sender, EventArgs e)
        {
            if (txtDescrib.Text == "Description")
            {
                txtDescrib.Text = "";
                txtDescrib.ForeColor = Color.Black;
            }
        }

        private void txtDescrib_Leave(object sender, EventArgs e)
        {
            if (txtDescrib.Text == "")
            {
                txtDescrib.Text = "Description";
                txtDescrib.ForeColor = Color.Silver;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Owner = this;
            F1.Show();
            this.Hide();
        }
    }
}
