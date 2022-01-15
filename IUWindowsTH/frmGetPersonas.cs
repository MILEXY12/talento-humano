using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsTH
{
    public partial class frmGetPersonas : Form
    {
        public frmGetPersonas()
        {
            InitializeComponent();
        }

        public object Biblioteca_datos { get; private set; }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            this.dgpersonas.DataSource = Biblioteca_datos.personas();
        }
    }
}
