using System.Net.Http.Headers;

namespace LabActicity2
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            CashierWindowQueue cwq = new CashierWindowQueue();
            CustomerView cv = new CustomerView();   
            cwq.Show();
            cv.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);



        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
