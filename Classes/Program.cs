var account = new Account
{
    Login = "MYLogin", // setter
    Password = "qwerty123" // setter
};
//
// // var account2 = new Account("MYLogin", "qwerty123");
//
// // account.Login = "MYLogin"; // setter
// // account.Password = "qwerty123"; // setter
//
//
// Console.WriteLine(account.Login); // getter
// Console.WriteLine(account.Password); // getter
//
//
// Tuples
// (int val1, float val2) tuple = (42, 13.45f);
// var (val1, val2) = ("Text", 42);
//
//
// 
// 
// Console.WriteLine(tuple.val1);
// Console.WriteLine(tuple.val2);

var (login, password) = account.Deconstruct();

Console.WriteLine(login);
Console.WriteLine(password);


Console.Read();
class Account
{
    private string _password; // backing field

    public Account() : this(string.Empty, string.Empty)
    {
        
    }

    public Account(string login, string password)
    {
        Login = login;
        _password = password;
    }

    public (string, string) Deconstruct()
    {
        return (Login, Password);
    }
    
    public string Login { get; set; } // Auto property

    public string Password // Full property
    {
        get
        {
            Console.WriteLine("get Password");
            return _password;
        }
        set
        {
            Console.WriteLine("set Password");

            if (value.Length < 7)
            {
                return;
            }

            _password = value;
        }
    }
}