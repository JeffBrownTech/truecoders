// Instantiate new person
using EncapsulationDemo;

var jeff = new Person();

// However, unable to set the wallet field because it is private
// jeff._wallet = 350.00

// Now with the AddMoney and CheckWallet methods, you can add money to the wallet and get back the current balance

Console.WriteLine($"Current Wallet Amount: {jeff.CheckWallet()}");
Console.WriteLine("Adding 100.00");
jeff.AddMoney(100.00);
Console.WriteLine($"New Wallet Amount: {jeff.CheckWallet()}");

Console.WriteLine("Adding 75.00");
jeff.AddMoney(75.00);
Console.WriteLine($"New Wallet Amount: {jeff.CheckWallet()}");