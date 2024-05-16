namespace GoEnd
{
    public sealed class Cosinus : Operation
    {
        public override string Name => "Косинус";

        public override double Run(params double[] numbers)
        {
            return Math.Cos(numbers[0]);
        }
    }

}
