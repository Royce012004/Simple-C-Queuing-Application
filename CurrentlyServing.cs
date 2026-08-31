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
    public partial class CurrentlyServing : Form
    {
        Timer timer = new Timer();
        public CurrentlyServing()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }
        private void timer1_tick(object sender, EventArgs e)
        {
            if (CashierWindowQueueForm.CurrentServingNumber != "")
            {
                lblServingNumber.Text =
                    CashierWindowQueueForm.CurrentServingNumber;
            }
            else
            {
                lblServingNumber.Text = "No customer";
            }
        }

        private void CurrentlyServing_Load(object sender, EventArgs e)
        {

        }
    }
}
