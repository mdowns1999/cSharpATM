/***********************************************************
* BANK CLASS
* The Bank Class will manage the accounts and help
* direct the actions that will happen to each account 
* or transaction.
************************************************************/
class Bank
{
    private
    //Member Variables
    List<Account> accounts;

    Transactions transaction = new Transactions();

    /*************************************************
    * CHOOSE TRANSACTION
    * Let the user choose what will happen to the account
    **************************************************/
    public void chooseTransaction(int accountLocation, AccountList accountList)
    {
        accounts = accountList.getAccountList();

        bool done = false;
        while (!done)
        {
            //Display the User's Options
            Console.WriteLine();
            Console.WriteLine("Welcome, " + accounts[accountLocation].fName + " " + accounts[accountLocation].lName + ".");
            Console.WriteLine("Please Choose what Transaction you would like to do: Enter a number between 1 to 5..  Press 6 to Exit");
            Console.WriteLine("1) Show Account Amount");
            Console.WriteLine("2) Deposit Cash");
            Console.WriteLine("3) Withdraw Cash");
            Console.WriteLine("4) Show Recent Transactions");
            Console.WriteLine("5) Produce Bank Report");
            Console.WriteLine("6) Exit");

            //Read the User's Input into a variable.
            string transactionSelection = Console.ReadLine();

            //Send the User to Where they need to go.
            switch (transactionSelection)
            {
                case "1":
                    transaction.displayAccountAmount(accounts, accountLocation);
                    break;

                case "2":
                    transaction.depositAmount(accounts, accountLocation);
                    break;

                case "3":
                    transaction.withdrawlAmount(accounts, accountLocation);
                    break;

                case "4":
                    transaction.getRecentTrasactions(accounts, accountLocation);
                    break;

                case "5":
                    transaction.getReport(accounts, accountLocation);
                    break;

                case "6":
                    done = true;
                    break;
            }
        }
    }
}

