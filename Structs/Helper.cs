using System.Text;

namespace Structs;

public static class Helper
{
    public static void Change(int value)
    {
        value = 42;
    }

    public static void Change(ref StringBuilder builder)
    {
        builder = new StringBuilder();
        builder.Append(" C++ ");
    }
}