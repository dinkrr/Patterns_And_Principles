namespace StructuralPatterns.Facade
{
    public class MortgageService
    {
        private readonly Bank bank;
        private readonly LoanService loanService;
        private readonly CreditService creditService;

        public MortgageService()
        {
            bank = new Bank();
            loanService = new LoanService();
            creditService = new CreditService();
        }

        public bool IsEligible(Customer customer, int amount)
        {
            return bank.HasSufficientSavings(customer, amount) &&
                   loanService.HasNoBadLoans(customer) &&
                   creditService.HasGoodCreditScore(customer);
        }
    }
}
