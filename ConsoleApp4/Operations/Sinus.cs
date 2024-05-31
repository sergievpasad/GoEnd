namespace GoEnd
{
    public sealed class Sinus : Operation
    {
        public Sinus() : base("Синус",1)
        {

        }

        public override double Run(params double[] numbers)
        {
            return Math.Sin(numbers[0]);
        }
    }

}
