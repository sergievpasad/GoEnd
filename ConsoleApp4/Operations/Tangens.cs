namespace GoEnd
{
    public sealed class Tangens : Operation
    {
        public Tangens() : base("Тангенс",1)
        {

        }
        public override double Run(params double[] numbers)
        {
            return Math.Tan(numbers[0] * double.Pi / 180);
        }
    }

}
