namespace GoEnd
{
    public sealed class Tangens : Operation
    {
        public Tangens() : base("Тангенс")
        {

        }
        public override double Run(params double[] numbers)
        {
            return Math.Tan(numbers[0]);
        }
    }

}
