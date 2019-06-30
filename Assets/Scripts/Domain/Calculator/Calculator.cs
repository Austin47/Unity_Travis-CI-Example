

namespace Domain.CalculatorService
{
    public class Calculator
    {
        public static Calculator Instance { get; private set; }

        public Calculator()
        {
            Instance = this;
        }

        public float Calculate(float v1, float v2, Operation o)
        {
            switch (o)
            {
                case Operation.Add: return Add(v1, v2);
                case Operation.Subtract: return Subtract(v1, v2);
                case Operation.Multiply: return Multiply(v1, v2);
                case Operation.Divide: return Divide(v1, v2);
            }

            return 0;
        }

        private float Add(float v1, float v2)
        {
            return v1 + v2;
        }

        private float Subtract(float v1, float v2)
        {
            return v1 - v2;
        }

        private float Multiply(float v1, float v2)
        {
            return v1 * v2;
        }

        private float Divide(float v1, float v2)
        {
            if (v1 == 0 | v2 == 0) return 0;
            return v1 / v2;
        }
    }
}

