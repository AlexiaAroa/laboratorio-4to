
class BankAccount { 
    public void Populate(long number, decimal balance)
    {
     accNo = number;
     accBal = balance;
     accType = AccountType.Checking;
    }
    private long accNo;
    private decimal accBal;
   
     
   public long Number()
    {
        return accNo;
    }
    public decimal Balance()
    {
        return accBal;
    }
    public string Type()
    {
        return accType.ToString();
    }
   private AccountType accType;
}
