using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad17_10
{
    public partial class frmQueuingForm : Form
    {
        string position;
        public frmQueuingForm(string cont)
        {
            position = cont;
            InitializeComponent();
        }

        private void frmQueuingForm_Load(object sender, EventArgs e)
        {
            txtQueue.Text += position.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
        }
    }
}
