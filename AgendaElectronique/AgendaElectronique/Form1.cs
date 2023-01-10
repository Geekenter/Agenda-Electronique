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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S_enregistrer se = new S_enregistrer();
            se.Owner = this;
            se.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            S_authentifier sa = new S_authentifier();
            sa.Owner = this;
            sa.Show();
            this.Hide();
        }

        private void creerEvenementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEvent Ad = new AddEvent();
            Ad.Owner = this;
            Ad.Show();
            this.Hide();
        }

        private void listeDesEvenementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventsList EL = new EventsList();
            EL.Owner = this;
            EL.Show();
            this.Hide();
        }

        private void modifierUnEvenementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierEvent ME = new ModifierEvent();
            ME.Owner = this;
            ME.Show();
            this.Hide();
        }

        private void supprimerEvenementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEvent de = new DeleteEvent();
            de.Owner = this;
            de.Show();
            this.Hide();
        }

        private void rechercherEvenementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercheEvent re = new RechercheEvent();
            re.Owner = this;
            re.Show();
            this.Hide();
        }

        private void exporterEvenementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportEvent ee = new ExportEvent();
            ee.Owner = this;
            ee.Show();
            this.Hide();
        }
    }
}
