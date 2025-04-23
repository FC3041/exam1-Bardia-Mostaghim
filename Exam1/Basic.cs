public class Q1_Add
{
    public static int Add(int a , int b)
    {
        return a+b;
    }
}

public class Basics
{
    public static void Q2MultiplyAndReset(ref int a , ref int b)
    {
        a = a*b;
        b = 1;
    }

    public static void Q5TryCatchFinally(bool shouldThrow, List<string> lis, bool shouldCatch = false)
    {
        
        try
        {
            lis.Add("Try");
            if(!shouldThrow)
                lis.Add("AfterTry");
            throw new InvalidOperationException();
        }
        catch(InvalidOperationException)
        {
            if(shouldCatch)
                throw;
            if(shouldThrow)
                lis.Add("Catch");
            
        }
        finally
        {
            lis.Add("Finally");
        }
    }
}

public class Type1
{
    private int t = 0;
    private int count;
    public int Count
    {
        get { return count; }
        set {   
                if(t==0) 
                    count = value; 
                t += 1;
            }
    }
}

public class Type2
{
    
    
    public int Count { get; set; }
    
}

public class Q4Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Q4Person(string name , int age)
    {
        Name = name;
        Age = age;
    }

    public string Introduce()
    {
        return  $"Hello, my name is {Name} and I am {Age} years old.";
    }
}

public class Q6Temperature
{
    private double celsius;
    public double Celsius
    {
        get { return celsius; }
        set { celsius = value;fahrenheit = 32+(9.0/5.0)*value; }
    }
    
    private double fahrenheit;
    public double Fahrenheit
    {
        get { return fahrenheit; }
        set { fahrenheit = value;celsius = (5.0/9.0) *(value-32); }
    }
    
    
}

public interface IShape
{
    public double GetArea();
    public double GetPerimeter();

}

public class Q7Circle : IShape
{
    public double r { get; set; }
    public Q7Circle(double R)
    {
        r =R;
    }
    public double GetArea()
    {
        return Math.PI * r * r;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * r;
    }
}

public class Q7Rectangle : IShape
{
    public double x { get; set; }
    public double y { get; set; }
    
    public Q7Rectangle(double X, double Y)
    {
        x = X;
        y = Y;
    }

    public double GetArea()
    {
        return x * y;
    }

    public double GetPerimeter()
    {
        return 2*x + 2*y;
    }
}

public class ShapeUtils
{
    public static double Q7TotalArea(IShape[] shapes)
    {
        double sum = 0;
        foreach(var t in shapes)
            sum += t.GetArea();
        return sum;
    }
}