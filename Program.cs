using eftest.Database;
using eftest.Enum;
using eftest.Models;

using (DBConnect db = new DBConnect())
{
    Account UserAccount = new Account();
    UserAccount.Username = "Hans";
    UserAccount.Password = "Wurst";
    UserAccount.Enabled = true;

    db.Add(UserAccount);
    db.SaveChanges();

    Log LogEntry = new Log();
    LogEntry.Type = ActionType.Register;
    LogEntry.Message = $"Account with id {UserAccount.Id} created for user {UserAccount.Username}";

    db.Add(LogEntry);
    db.SaveChanges();
}