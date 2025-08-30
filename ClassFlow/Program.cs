using ClassFlow.Entities;
using System.Security.AccessControl;

Account acc = new(1001, "Alex", 0.0);
BusinessAccount bacc = new(1002, "Sara", 0.0, 500.0);

//UPCASTING
//transforming a subclass (BusinessAccount) into its superclass (Account).
Account acc1 = bacc;

//another example
Account acc2 = new BusinessAccount(1003, "Bob esponja", 0.0, 200);

//savingsAccount is also a subclass of Account
Account acc3 = new SavingsAccount(1004, "Patrick", 0.0, 0.01);


//DOWNCASTING
BusinessAccount acc4 = (BusinessAccount)acc2;
acc4.Loan(100);

//"is" quest for compiler if "acc3" is an instance of "BusinessAccount".  If true, acc5 will safely receive acc3 cast as BusinessAccount.
//if false, nothings happens
if (acc3 is BusinessAccount)
{
	//BusinessAccount acc5 = (BusinessAccount)acc3;
	BusinessAccount? acc5 = acc3 as BusinessAccount;
	acc5.Loan(100.0);
	Console.WriteLine("Loan!");
}

if(acc3 is SavingsAccount)
{
	//SavingsAccount acc5 = (SavingsAccount)acc3;
	SavingsAccount? acc5 = acc3 as SavingsAccount;
	acc5.UpdateBalance();
	Console.WriteLine("Update!");
}