using SistemadeVendasCsharp.FORMULARIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeVendasCsharp
{
    public partial class AdmPainel : Form
    {
        public AdmPainel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORMULARIOS.PainelDeUsuario user = new FORMULARIOS.PainelDeUsuario();
            user.Show();

        
        }
    }
}
