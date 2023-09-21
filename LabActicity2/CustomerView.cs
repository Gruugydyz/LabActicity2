using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace LabActicity2
{
    public partial class CustomerView : Form
    {
        private CashierClass cashier;
        public CustomerView()
        {
            InitializeComponent();
            cashier = new CashierClass();

            Timer timer = new Timer();
            timer.Interval = (1 * 1000); // 1 sec.
            timer.Tick += new EventHandler(CustomerView_Load);
            timer.Start();

        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);

        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            foreach (Object obj in CashierList)
            {
                if (obj != null)
                {
                    lblcustomerView.Text = CashierClass.CashierQueue.Peek();
                }
                
            }

        }
    }
}
