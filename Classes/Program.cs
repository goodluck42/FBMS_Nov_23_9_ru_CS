class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Top-level statements

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

        // var (login, password) = account.Deconstruct();
        //
        // Console.WriteLine(login);
        // Console.WriteLine(password);

        // Ref test
        // var person = new Person // Person = 0x1c ---> 0x42
        // {
        //     Age = 42,
        //     Name = "Vasya"
        // };
        //
        // RefTest(ref person);
        //
        // Console.WriteLine(person.Name);
        // Console.WriteLine(person.Age);
        
        
        // Out test
        
        OutTest(out Person person);
        
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
        
        string input = Console.ReadLine()!;
        
        if (int.TryParse(input, out int res))
        {
            Console.WriteLine(res * 2);
        }
        
        Console.Read();
    }

    static void RefTest(ref Person person) // Person = 0x1c ---> 0x42
    {
        // person->Age *= 2;
        // person.Age *= 2;

        person = new Person // Person = 0x1c ---> 0xff4c 
        {
            Age = 4,
            Name = "Vasya_Malish"
        };
    }
    
    static void OutTest(out Person person)
    {
        person = new Person
        {
            Age = 25,
            Name = "Fuad"
        };
    }

    static void PrintSquare(int length, char symbol)
    {
        // ...
    }
}