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
    public partial class frmQueuing : Form
    {
        Cashier cashier = new Cashier();

        public frmQueuing()
        {
            InitializeComponent();
            frmCashierWindowQueue frmCashierWindowQueue = new frmCashierWindowQueue();
            frmCashierWindowQueue.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblPositionQueue.Text = cashier.CashierGeneratedNumber("P - ");
            Cashier.getNumberInQueue = lblPositionQueue.Text;
            Cashier.cashierQueue.Enqueue(Cashier.getNumberInQueue);
        }
    }
}
