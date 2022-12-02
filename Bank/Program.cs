using BankExercise;
using BankExercise.Classes;

BankDbContext dbContext = new BankDbContext();

try
{
    //await dbContext.Banks.AddAsync(new Bank
    //{
    //    Name = "TooBigToFail",
    //    Location = "Amersfortshi"
    //});

    var bank = dbContext.Banks.FirstOrDefault(x => x.BankId == 1);

    var customer = dbContext.Customers.FirstOrDefault(x => x.Name == "Anano");
    //await dbContext.AddAsync(new Customer
    //{
    //    Name = "Anano",
    //    Address = "Ananoshi",
    //    PhoneNo = 12345,
    //    AcctNo = 54321,
    //    Bank = bank
    //});

    //await dbContext.AddAsync(new Checking
    //{
    //    Customer = customer
    //});

    await dbContext.AddAsync(new Teller
    {
        Bank = bank,
        Name = "ATM",
        Customers = new List<Customer>() { customer }
    });

    await dbContext.SaveChangesAsync();
}

catch (Exception e)
{
    Console.WriteLine(e.Message);

    throw;
}