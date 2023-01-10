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
    public partial class ModifierEvent : Form
    {
        public ModifierEvent()
        {
            InitializeComponent();
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
