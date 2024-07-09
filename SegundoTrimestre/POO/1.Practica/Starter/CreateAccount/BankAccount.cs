class BankAccount { 
  private static long NextNumber;
    public void Populate(decimal balance)
    {
     accNo = NexNumber();
     accBal = balance;
     accType = AccountType.Checking;
    }
    private long accNo;
    private decimal accBal;
    private static long nextAccNo=123;
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
    public static long NexNumber()
    {
       return nextAccNo++;
    }
   private AccountType accType;
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        return accBal;
    }
}