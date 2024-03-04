/*
 Maintenance History:
    10/30/2019 - Wrote program
    11/1/2019 - Create method to get checking account information 
 */

using System;

public class CheckingAccount : Account
{
    private decimal feePerTransaction;

    public CheckingAccount(decimal initialBalance, decimal feePerTransaction)
        : base(initialBalance)
    {
        Fee = feePerTransaction;
    } 

    public decimal Fee
    {
        get
        {
            return feePerTransaction;
        }

        set
        {
            if(feePerTransaction < 0.0M && feePerTransaction > 10.0M )
            {
                throw new ArgumentOutOfRangeException("Fee", value,
                    $"Fee must be > $0 and < $10");
            }

            feePerTransaction = value;
        } 
    } 

    public override void Credit(decimal depositAmount)
    {
        if (depositAmount > 0)
        {
            Console.WriteLine("Fee charged for deposit transaction: {0:C}", Fee);
            AccountBalance = AccountBalance - Fee;
        } 
    } 

    public override void Debit(decimal withDraw)
    {
        if (withDraw > 0)
        {
            Console.WriteLine("Fee charged for withdrawal transaction: {0:C}", Fee);
            AccountBalance = AccountBalance - Fee;
        } 
    } 
    
    public void GetCheckingInfo(decimal depositAmount, decimal withDraw)
    {
        Console.WriteLine("\n\nAccount information for customer:\n");
        Console.WriteLine("Initial balance for checking account: {0:C}",
            AccountBalance);

        Console.Write("Enter amount you want to deposit into your " +
        "account: ");
        depositAmount = Convert.ToDecimal(Console.ReadLine());
        Credit(depositAmount);

        Console.WriteLine("Add to account balance: {0:C}", depositAmount);
        base.Credit(depositAmount);
        
        Console.Write("\nEnter amount you want to withdraw from your " +
               "account: ");
        withDraw = Convert.ToDecimal(Console.ReadLine());
        Debit(withDraw);

        Console.WriteLine("Withdraw from account balance: {0:C}", withDraw);
        base.Debit(withDraw);

        Console.WriteLine("\nNew account balance: {0:C}", AccountBalance);
    } 
} 

