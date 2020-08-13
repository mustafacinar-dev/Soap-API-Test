using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKentService.Services.BulutService;
using TKentService.Services.Interfaces;

namespace TKentService.Services.Concrete
{
    public class TransactionService : ITransactionService
    {
        #region Fields
        public string Key { get; set; }
        public DateTime Date { get; set; }
        private readonly OutsourceIntegration7SoapClient soapClient;
        #endregion
        #region Constructor
        public TransactionService(string Key, DateTime Date)
        {
            this.Date = Date;
            this.Key = Key;
            soapClient = new OutsourceIntegration7SoapClient();
        }
        #endregion
        #region Methods
        public async Task<ListResultOfTransaction> GetListResultOfTransaction()
        {
            return await soapClient.GetTransactionsAsync(Key, Date);
        } 
        #endregion
    }
}
