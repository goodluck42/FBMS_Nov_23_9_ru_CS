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