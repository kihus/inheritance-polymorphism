using ClassFlow.Entities;
using System.Security.AccessControl;


Account acc1 = new(1001, "Alex", 500.0);
Account acc2 = new SavingsAccount(1002, "Bob esponja", 500.0, 0.01);

acc1.WithDraw(10.0);
acc2.WithDraw(10.0);

Console.WriteLine(acc1.Balance);
Console.WriteLine(acc2.Balance);




