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
    public partial class AggingiCorso : Form
    {
        public AggingiCorso()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeCorso.Text) || string.IsNullOrEmpty(txtEdizioneCorso.Text))
            {
                MessageBox.Show("Per essere inserito un nuovo corso bisogna avere sia il nome che l'edizione");
            }
            else
            {
                if (!int.TryParse(txtEdizioneCorso.Text, out int n))
                {
                    MessageBox.Show("L'edizione deve essere un numero");
                    return;
                }
                var corso = new Corso(txtNomeCorso.Text, n);
                lblConfermaAggiunta.Text = $"Il corso con nome {txtNomeCorso.Text} con edizione {n} è stato inserito";
            }
        }
    }
}