/*
 Maintenance History:
    10/30/2019 - Wrote program
 */

 //Account base class for inheritance
using System;

public class Account : Object
{
    private decimal initialBalance; 

    public Account(decimal initialBalance)
    {
        AccountBalance = initialBalance; 
    }

    public decimal AccountBalance
    {
        get
        {
            return initialBalance;
        } //end get

        set
        {
            if (initialBalance < 0.0M)
            {
                throw new ArgumentOutOfRangeException("AccountBalance", value,
                    $"Account balance must be >= 0");
            }

            initialBalance = value;
        } 
    } 
        
    public virtual void Credit(decimal depositAmount)
    { 
        if (depositAmount > 0)
        {
            AccountBalance = depositAmount + AccountBalance; 
        }
        else
        {
            Console.WriteLine("You did not make a deposit!\n");  
        } 
    } 
        
     public virtual void Debit(decimal withDraw)
     {
        if(withDraw < AccountBalance)
        {
            AccountBalance = AccountBalance - withDraw;
        }
        else
        {
            Console.WriteLine("You do not have enough funds to withdraw!");
        } 
     }
} 


