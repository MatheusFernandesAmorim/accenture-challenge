using AccentureChallenge.Domain;

namespace AccentureChallenge.Services
{
    public class NTransactionService
    {
        private readonly List<NTransaction> Transactions = new List<NTransaction>();

        #region Task 3: Code Review
        public List<NTransaction> GetTransactionByIdList(List<string> idList)
        {
            /* Review 1
             * It wouldn't need to chain loops, it's difficult to understand and could increase response time
             * We can use a LINQ structure to help us in this case
             * Please, check the method 'NewGetTransactionByIdList' in this file as a solution proposal
             */
            foreach (var transaction in Transactions)
            {
                foreach (var id in idList)
                {
                    if (transaction.Id == id)
                    {
                        Transactions.Add(transaction);

                        return Transactions;
                    }
                }
            }
            return null;
        }

        public NTransaction GetTransactionById(string id)
        {
            /* Review 2
             * The main goals here could be to improve readability, reduce code lines and improve response
             * So we can also use LINQ to help us to achieve that
             * Please, check the method 'NewGetTransactionById' in this file as a solution proposal
             */
            foreach (var transaction in Transactions)
            {
                if (transaction.Id == id)
                {
                    return transaction;
                }
            }
            return null;
        }

        public void AddTransaction(NTransaction transaction)
        {
            /* Review 3
             * It would be better to add try/catch structure to avoid possible errors             
             * Please, check the method 'NewAddTransaction' in this file as a solution proposal
             */
            Transactions.Add(transaction);
        }

        public void RemoveTransaction(string id)
        {
            /* Review 4
             * It would be better to add try/catch structure to avoid possible errors             
             * Please, check the method 'NewRemoveTransaction' in this file as a solution proposal
             */
            var transaction = GetTransactionById(id);
            if (transaction != null)
            {
                Transactions.Remove(transaction);
            }
        }

        //-------------------------------------------------------------------------------

        public List<NTransaction> NewGetTransactionByIdList(List<string> idList)
        {
            List<NTransaction> listTransactions = Transactions.Where(t => idList.Contains(t.Id)).ToList();

            return listTransactions;
        }

        public NTransaction? NewGetTransactionById(string id)
        {
            NTransaction? transaction = Transactions.FirstOrDefault(t => t.Id == id);

            return transaction;
        }

        public void NewAddTransaction(NTransaction transaction)
        {
            try
            {
                if (transaction != null)
                {
                    Transactions.Add(transaction);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void NewRemoveTransaction(string id)
        {
            try
            {
                NTransaction? transaction = NewGetTransactionById(id);

                if (transaction != null)
                {
                    Transactions.Remove(transaction);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }
        #endregion
    }
}