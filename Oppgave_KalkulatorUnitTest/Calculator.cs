namespace Oppgave_KalkulatorUnitTest.Main
{
    public class Calculator
    {
        public int? LeggSammen(int? a, int? b)
        {
            return a + b;
        }

        public int? TrekkFra(int? a, int? b)
        {
            return a - b;
        }

        public int? Multipliser(int? a, int? b)
        {
            return a * b;
        }

        public double? Divider(double? a, double? b)
        {
            if (a == 0 || b == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}
