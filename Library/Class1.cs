using System;

namespace Functions
{
    public interface IFunction
    {
        double Evaluate(double x);

        IFunction Add(IFunction other);

        IFunction Subtract(IFunction other);

        IFunction Multiply(IFunction other);

        IFunction GetDerivation();
    }
}
