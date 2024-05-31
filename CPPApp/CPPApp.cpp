#include <iostream>

class StringBuilder
{
public:
    int Value;

    void Change(int NewValue)
    {
        Value = NewValue;
    }
};

void Change(StringBuilder*& builder)
{
    builder = new StringBuilder;
    builder->Change(42);
    
    std::cout << "Change &builder = " << &builder << '\n';
    std::cout << "Change builder = " << builder << '\n';
}

int main(int argc, char* argv[])
{
    auto builder = new StringBuilder;

    builder->Value = 13;

    std::cout << &builder << '\n';
    
    Change(builder);

    std::cout << "main &builder = " << &builder << '\n';
    std::cout << "main builder = " << builder << '\n';
    std::cout << &builder->Value << '\n';

    delete builder;

    
    return 0;
}
