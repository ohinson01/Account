/*
 Maintenance History:
    10/30/2019 - Wrote program
    11/1/2019 - modify code with method call
 */

using System;

public class AccountTest
{
    private static int Account;

    public static void Main()
    {
        decimal depositAmount = 0;
        decimal withDraw = 0;

        CheckingAccount checking = new CheckingAccount(10000.00M, 8.00M);
        SavingsAccount savings = new SavingsAccount(5000.00M, 0.1M);

        Console.Write("Do you want to enter your checking or savings account?\n" +
            "(0 for checking account, 1 for savings account, -1 to exit)?: ");
        Account = Convert.ToInt32(Console.ReadLine());

        while (Account != -1)
        {
            if (Account == 0)
            {
                checking.GetCheckingInfo(depositAmount, withDraw);
            } 
            else if (Account == 1)
            {
                savings.GetSavingsInfo();
        
            } 

            Console.Write("\nDo you want to enter your checking or savings account?\n" +
            "(0 for checking account, 1 for savings account, -1 to exit)?: ");
            Account = Convert.ToInt32(Console.ReadLine());
        } 

        Console.WriteLine("\nThank you for your business. Have a good day!");

        Console.ReadLine();
    } 
} 

