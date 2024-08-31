namespace ExceptionVsNoException;

public class Calculate
{
    public double DivWithExceptionAndIf(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException();
        return a / b;
    }
    
    public double DivWithException(double a, double b)
    {
        try
        {
            return a / b;
        }
        catch (Exception e)
        {
            throw new DivideByZeroException("Делить на ноль нкльзя!", e);
        }
    }
    
    public double DivWithoutException(double a, double b)
    {
        return a / b;
    }

    public Result DivWithResultWithIf(double a, double b)
    {
        if (b == 0) return new Result()
        {
            Type = ResultType.Failure,
            Value = null
        };
        
        var result = a / b;
        return new Result()
        {
            Type = ResultType.Success,
            Value = result
        };
    }
    public Result DivWithResultWithTry(double a, double b)
    {
        try
        {
            var result = a / b;
            return new Result()
            {
                Type = ResultType.Success,
                Value = result
            };
        }
        catch (Exception e)
        {
            return new Result()
            {
                Type = ResultType.Failure,
                Value = null
            };
        }
    }
}