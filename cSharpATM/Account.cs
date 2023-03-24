/***********************************************************
* ACCOUNT CLASS
* THis is where we set up Account objects.  Each object
* contains features that belong to a user's account such 
* as name,pin, account number, etc.
************************************************************/
class Account
{
    //Account Member Variables
    private string fname;
    private string lname;
    private string accountNum;
    private string accountPin;
    private double amount;
    private List<double> transactions;

    /*************************************************
    * CONSTRUCTOR
    **************************************************/
    public Account(string firstName, string lastName, string accountNumber, string pin, double accountAmount, List<double> transaction)
    {
        this.fname = firstName;
        this.lname = lastName;
        this.accountNum = accountNumber;
        this.accountPin = pin;
        this.amount = accountAmount;
        this.transactions = transaction;
    }

    //Get and Set the First Name
    public string fName
    {
        get { return fname; }
        set { fname = value; }
    }

    //Get and Set the Last Name
    public string lName
    {
        get { return lname; }
        set { lname = value; }
    }

    //Get and Set the Account number
    public string accountNumber
    {
        get { return accountNum; }
        set { accountNum = value; }
    }

    //Get and Set the User's Pin
    public string Pin
    {
        get { return accountPin; }
        set { accountPin = value; }
    }

    //Get and Set the User's Pin
    public double accountAmount
    {
        get { return amount; }
        set { amount = value; }
    }

    //Get and Set the User's Pin
    public List<double> Transactions
    {
        get { return transactions; }
        set { transactions = value; }
    }
}
