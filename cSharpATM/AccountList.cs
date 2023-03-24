/***********************************************************
* ACCOUNT LIST CLASS
* This is where we keep track of the accounts 
* for the bank
************************************************************/
class AccountList
{
    //Member Variables
    private
    List<Account> accountsList = new List<Account>();
    int location = 0;

    /*************************************************
    * CONSTRUCTOR
    **************************************************/
    public AccountList()

    {
        //Set up Fake Transaction Amounts
        List<double> transactionsOne = new List<double>() { 200.00, -25.00, 500.00, 1.00, -1000.00, 3000.0 };
        List<double> transactionsTwo = new List<double>() { 33.50, -10.00 };
        List<double> transactionsThree = new List<double>() { 100.00, 300.00, -5.00 };
        
        //For now, we will set up placeholders since we are not hooked up to any Database.
        //The order of a new account fields are: First Name, Last Name, Account Number, Account Pin,
        //Account Ammount, and transaction history
        accountsList.Add(new Account("Mike", "Downs", "83440", "1234", 1000.00, transactionsOne));
        accountsList.Add(new Account("Chris", "Downs", "82442", "5678", 5033.25, transactionsTwo));
        accountsList.Add(new Account("Dave", "Smith", "5", "5678", 534.25, transactionsThree));

    }

    /*************************************************
    * GET ACCOUNT LIST
    * Get the list of accounts
    **************************************************/
    public List<Account> getAccountList()
    {
        return accountsList;
    }

    /*************************************************
    * GET ACCOUNT LOCATION
    * Get the accountLocation
    **************************************************/
    public int getAccountLocation(string accountNum)
    {
        getAccountInfo(accountNum);
        return location;
    }

    /*************************************************
    * getAccountInfo
    * Here we will grant acces to the user's account only. 
    * We will return the location of th eobject where 
    * their account is.
    **************************************************/
    public void getAccountInfo(string accountNum)
    {
        for (var i = 0; i < accountsList.Count; i++)
        {
            if (accountsList[i].accountNumber == accountNum)
            {
                location = i;
            }
        }
    }
}
