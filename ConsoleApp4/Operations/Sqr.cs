namespace GoEnd
{
    public sealed class Sqr : Operation
    {
        public Sqr() : base("Степень")
        {

        }

        public override double Run(params double[] numbers)
        {
            return Math.Pow(numbers[0], numbers[1]);
        }
    }

}
