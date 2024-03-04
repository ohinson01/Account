/*
 Maintenance History:
    10/30/2019 - Wrote program
    11/1/2019 - Create method to get savings account information
 */

using System;

public class SavingsAccount : Account
{
    private decimal interestRate; 

    public SavingsAccount(decimal initialBalance, decimal interestRate)
        : base(initialBalance)
    {
        Rate = interestRate;
    } 

    public decimal Rate
    {
        get
        {
            return interestRate;
        }

        set
        {
            if (interestRate < 0.0M && interestRate > 5.0M)
            {
                throw new ArgumentOutOfRangeException("Rate", value,
                    $"Rate must be > 0% and < 5%");
            }

            interestRate = value;
        } 
    } 

    public void CalculateInterest()
    {
        AccountBalance = AccountBalance + (Rate * AccountBalance);
    }

    public void GetSavingsInfo()
    {
        Console.WriteLine("\nAccount information for customer:\n");
        Console.WriteLine("Initial balance for savings account: {0:C}",
        AccountBalance);

        Console.WriteLine("Interest rate for account: {0:F}", Rate);
        CalculateInterest();

        Console.WriteLine("New account balance: {0:C}", AccountBalance);
    }
} 


