using System.Text;
using Structs;

// value type - stack (not always)
int value = 13;
// reference type - heap (always)
StringBuilder builder = new StringBuilder();

Helper.Change(ref builder);

Console.WriteLine(builder.ToString());

Account account = new Account
{
    Id = 1,
    Login = "TestLogin",
    CreationDate = DateTime.Now
};

var vector = new Vector2D
{
    X = 11,
    Y = 42
};


int b = 42;
object boxed = b; // boxing
int unboxed = (int)boxed; // unboxing


Console.WriteLine(vector.ToString());