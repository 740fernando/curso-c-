

namespace Heranca.Entitites
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BusinessAccount()
        {
            double x = Balance;
        }
        public BusinessAccount(double loanLimit)
        {
            LoanLimit = loanLimit;
        }
        public BusinessAccount(int number, string holder, double balance,double loanLimit)
            :base(number,holder,balance)//:base - permite a chamada de algum construtor da super classe)
        {
            //Number = number;
           // Holder = holder;
           // Balance = balance;
            LoanLimit = loanLimit;
        }
        public void Loan(double amount)
        {
            if(amount<= LoanLimit) 
            { 
            Balance += amount;
            }
        }
    }
}

