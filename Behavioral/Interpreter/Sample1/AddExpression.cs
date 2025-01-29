namespace Behavioral.Interpreter.Sample1;

public class AddExpression : IExpression
{
    private readonly IExpression _exp1;
    private readonly IExpression _exp2;

    public AddExpression(IExpression exp1, IExpression exp2)
    {
        _exp1 = exp1;
        _exp2 = exp2;
    }

    public int Interpret()
    {
        return _exp1.Interpret() + _exp2.Interpret();
    }
}






