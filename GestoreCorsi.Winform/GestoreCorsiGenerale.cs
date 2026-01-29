using GestioneCorsi.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GertoreCorsi.WindFOrm
{
    public partial class GestoreCorsiGenerale : Form
    {
        public GestoreCorsiGenerale()
        {
            InitializeComponent();
        }
        private void btnAggiungiCorso_Click(object sender, EventArgs e)
        {
            AggingiCorso f2AggingiCorso = new AggingiCorso();
            f2AggingiCorso.Show();
        }

        private void btnEsciProgramma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
