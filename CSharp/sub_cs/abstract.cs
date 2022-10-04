public abstract class Expression{
    public abstract void SaySomething();
}
public class Constant : Expression{
    public override void SaySomething()
    {
        Console.WriteLine("hello!");
    }
}