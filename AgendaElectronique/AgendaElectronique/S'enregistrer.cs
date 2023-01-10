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
    public partial class S_enregistrer : Form
    {
        public S_enregistrer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S_authentifier sa = new S_authentifier();
            sa.Owner = this;
            sa.Show();
        }
    }
}
