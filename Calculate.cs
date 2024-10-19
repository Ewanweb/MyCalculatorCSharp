namespace MyCalculater
{
    public class Calculate : ICalculate
    {
        public int Plus(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Minus(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiple(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Divide(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}