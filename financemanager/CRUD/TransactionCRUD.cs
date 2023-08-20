using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using financemanager.Modell;


namespace financemanager.CRUD
{
    public class VRTransactionCRUD
    {

        private BilanceContext bilanceContext;

        public VRTransactionCRUD() {

            bilanceContext = new BilanceContext();
        }

        public void Create(VRTransaction vrtransaction) {
            bilanceContext.VRTransactions.Add(vrtransaction);
            bilanceContext.SaveChanges();
        }
    }
}
