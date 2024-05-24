namespace GoEnd
{
    public sealed class Cotangens : Operation
    {
        public Cotangens() : base("Котангенс")
        {

        }
        public override double Run(params double[] numbers)
        {
            return 1 / Math.Tan(numbers[0]);
        }
    }

}
