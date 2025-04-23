
public interface Strategy
{
    public double val { get; set; }
}

 public class PercentageDiscountStrategy :  Strategy
{
    public double val { get; set; }
    public PercentageDiscountStrategy(double x)
    {
        val = x;
    }
}
public class  NoDiscountStrategy : Strategy
{
    public double val {get; set;}
    public NoDiscountStrategy()
    {
        val = 0.0;
    }
}

public class PricingEngine : Strategy
{
    public double val { get; set; }

    public PricingEngine(NoDiscountStrategy x)
    {
        SetStrategy(x);
    }

    public void SetStrategy<T>(T x)
    where T: Strategy
    {
        val = x.val;
    }


    public double CalculatePrice(double x)
    {
        return x * (1.0-val);
    }
}