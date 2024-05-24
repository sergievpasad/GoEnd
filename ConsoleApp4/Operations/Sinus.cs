namespace GoEnd
{
    public sealed class Sinus : Operation
    {
        public Sinus() : base("Синус")
        {

        }

        public override double Run(params double[] numbers)
        {
            return Math.Sin(numbers[0]);
        }
    }

}
