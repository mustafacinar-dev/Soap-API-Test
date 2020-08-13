using System;
using System.Windows.Forms;
using TKentService.Services.Concrete;
using TKentService.Services.BulutService;
using System.Threading.Tasks;

namespace TKentService.Forms
{
    public partial class TKentServiceForm : Form
    {
        #region Fields
        private TransactionService transactionService;
        private ListResultOfTransaction listResultOfTransaction;
        #endregion
        #region Constructor
        public TKentServiceForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        #endregion
        #region Methods
        private void button1_Click(object sender, EventArgs e) => GetTransactionData();
        private async void GetTransactionData()
        {
            button1.Enabled = false;
            button1.Text = "Yükleniyor";
            transactionService = new TransactionService(@"Y5[ZLKdrtsK7@`7S", dateTimePicker1.Value.Date);
            listResultOfTransaction = await transactionService.GetListResultOfTransaction();
            foreach (Transaction item in listResultOfTransaction.List)
            {
                if (item.Type == null) item.Type = "BOŞ";
            }
            dataGridView1.DataSource = listResultOfTransaction.List;
            button1.Enabled = true;
            button1.Text = "Verileri Getir";
        } 
        #endregion
    }
}
