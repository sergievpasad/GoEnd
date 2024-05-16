namespace GoEnd
{
    public sealed class Sinus : Operation
    {
        public override string Name => "Синус";

        public override double Run(params double[] numbers)
        {
            return Math.Sin(numbers[0]);
        }
    }

}
