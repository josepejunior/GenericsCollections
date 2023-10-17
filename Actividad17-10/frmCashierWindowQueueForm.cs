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
    public partial class frmCashierWindowQueueForm : Form
    {
        int num = 0;
        string cont;
        public string[] conts;

        public frmCashierWindowQueueForm()
        {
            InitializeComponent();
        }

        private void frmCashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            num++;
            lblPositionQueue.Text = "P - 1" + num.ToString("D4");
            cont = lblPositionQueue.Text;
            cont = cont;
        }

        private void btnCashier_Click(object sender, EventArgs e)
        { 
            QueueCashier qCashier = new QueueCashier(conts);
            //frmQueuingForm fr = new frmQueuingForm(cont);
            //fr.ShowDialog();
        }
    }
}
