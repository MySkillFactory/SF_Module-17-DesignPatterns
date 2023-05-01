
using FinalTask.Models;
using FinalTask.Profiles;

Account account1 = new(balance: 900);
account1.CalculateInterest(new RegularProjectCalculateProfile());

Account account2 = new(5000000);
account2.CalculateInterest(new RegularProjectCalculateProfile());

Account account3 = new(1000);
account3.CalculateInterest(new SalaryProjectCalculateProfile());

Console.ReadKey();