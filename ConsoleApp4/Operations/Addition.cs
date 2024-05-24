namespace GoEnd
{
    public sealed class Addition : Operation
    {
        public Addition() : base("Сложение")
        {

        }

        public override double Run(params double[] numbers)
        {
            return numbers.Sum();
        }
    }

}
