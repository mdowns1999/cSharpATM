/***********************************************************
* ATM CLASS
* This is where the client will interact with the ATM.
* The user will enter his or her account info and
* the class will then validate it.
************************************************************/

class ATM
{
    //Variables
    private
    bool isAccountValid = false;
    int accountLocation = 0;
    //Set Up the Accounts List
    AccountList accountList = new AccountList();

    public
    /*************************************************
    * IS VALID ACCOUNT
    * Check if the input is a valid account
    **************************************************/
    bool isValidAccount(string accountNum, string accountPin)
    {
        List<Account> accounts = accountList.getAccountList();

        for (int i = 0; i < accounts.Count; i++)
        {
            if (accounts[i].accountNumber == accountNum && accounts[i].Pin == accountPin)
            {
                return true;
            }
        }

        Console.Write("Invalid Account Number or Password.  Please Try Again.");
        return false;
    }

    /*************************************************
    * GET USER INPUT
    * Get input from the user
    **************************************************/
    public void getUserInput()
    {
        Console.WriteLine("********REXBURG COMMUNITY BANK********");
        Console.WriteLine("Welcome to Rexburg Community Bank!  Please Login.");
        bool done = false;
        //Loop Through the ATM until the transaction is complete
        while (!done)
        {
            Console.WriteLine("Please Enter Your Account Number: ");
            string accountNum = Console.ReadLine();

            Console.WriteLine("Please Enter Your Pin: ");
            string accountPin = Console.ReadLine();

            //Is the Account Valid? If a account with the AccountNum and Pin is found, we will get true, if not false.
            isAccountValid = isValidAccount(accountNum, accountPin);

            if (isAccountValid)
            {
                //Access the Account
                accessAccount(accountNum);
                done = true;
            }

        }

        //Now the User will get sent to the Bank Class to choose their transaction.
        Bank bank = new Bank();
        bank.chooseTransaction(accountLocation, accountList);
    }

    /*************************************************
    * ACCESS ACCOUNT
    * Here we will grant acces to the user's account only. 
    * We will return the location of th eobject where 
    * their account is.
    **************************************************/
    void accessAccount(string accountNum)
    {
        accountLocation = accountList.getAccountLocation(accountNum);
    }
}