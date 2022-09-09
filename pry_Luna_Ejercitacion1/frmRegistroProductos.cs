using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_Luna_Ejercitacion1
{
    public partial class frmRegistroProductos : Form
    {
        public frmRegistroProductos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtProductos.Text + "xxxxx: " + lstTipos.Text);
            // O tambien se puede hacer:
            // MessageBox.Show(txtProductos.Text);
            // MessageBox.Show(lstTipos.Text);
        }
    }
}
