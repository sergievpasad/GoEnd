namespace GoEnd
{
    public sealed class Cosinus : Operation
    {
        public Cosinus() : base("Косинус",1)
        {

        }

        public override double Run(params double[] numbers)
        {
            return Math.Cos(numbers[0]);
        }
    }

}
