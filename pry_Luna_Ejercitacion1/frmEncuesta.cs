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
    public partial class frmEncuesta : Form
    {
        public frmEncuesta()
        {
            InitializeComponent();
        }

        private void btnNoSatisfecho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas gracias por su aporte, esperamos en los proximos productos cumplir sus expectativas");

        }

        private void btnSatisfecho_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas gracias por su valoracion, esperamos que pruebe otros productos de la marca");

        }
    }
}
