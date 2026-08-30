using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class QueuingForm : Form
    {
        CashierClass cashier = new CashierClass();
        public QueuingForm()
        {
            InitializeComponent();
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            string generatedNumber = cashier.CashierGeneratedNumber("P - ");

            lblQueue.Text = generatedNumber;

            CashierClass.CashierQueue.Enqueue(generatedNumber);
        }

        private void CashierView_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm cashierWindowQueueForm = new CashierWindowQueueForm();
            cashierWindowQueueForm.Show();
        }
    }
}
