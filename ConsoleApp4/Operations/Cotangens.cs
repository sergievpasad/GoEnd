namespace GoEnd
{
    public sealed class Cotangens : Operation
    {
        public override string Name => "Котангенс";
        public override double Run(params double[] numbers)
        {
            return 1 / Math.Tan(numbers[0]);
        }
    }

}
