Customer c = new Customer();
c.PrintA();
c.PrintB();

string name = "Vishal";
string result = name.MeLihileliReverseMethod();
Console.WriteLine($"Input: {name} Output: {result}");
string email = "vivek@gmail.com";
string remail = email.MeLihileliReverseMethod();
Console.WriteLine($"Input: {email} Output: {remail}");

A a1 = new A();
a1.PrintTypeName();

B b1 = new B();
b1.PrintTypeName();

Customer1 c1 = new Customer1();
c1.PrintB();
c1.PrintA();

Console.ReadLine();

public  class Customer
{
    public void PrintA()
    {
        Console.WriteLine("A");
    }
}

class Customer1 : Customer
{
    public void PrintB()
    {
        Console.WriteLine("B");
    }
}

public class A : IA { }
public class B : IA { }

public interface IA { }

public static class CustomerHelper
{
    public static void PrintB(this Customer c)
    {
        Console.WriteLine("B");
    }

    public static string MeLihileliReverseMethod(this string name)
    {
        string result = "";
        for (int i = name.Length - 1; i >= 0; i--)
        {
            result += name[i];
        }

        return result;
    }

    //public static void PrintTypeName(this A a)
    //{
    //    Console.WriteLine($"Type name : {a.GetType().Name}");
    //}

    //public static void PrintTypeName(this B a)
    //{
    //    Console.WriteLine($"Type name : {a.GetType().Name}");
    //}

    public static void PrintTypeName(this IA a)
    {
        Console.WriteLine($"Type name : {a.GetType().Name}");
    }
}

