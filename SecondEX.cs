namespace Library
{
    public class BMIResult
    {
        public double BMI { get; set; }
        public string Description { get; set; }

        public static BMIResult CalculateBMI(double heightInMeters, double weightInKilograms)
        {
            if (heightInMeters <= 0 || weightInKilograms <= 0)
            {
                throw new ArgumentException("Значения роста и веса должны быть положительными.");
            }

            double bmi = weightInKilograms / (heightInMeters * heightInMeters);

            string description;
            if (bmi < 18.5)
            {
                description = "Недостаточный вес";
            }
            else if (bmi < 25)
            {
                description = "Нормальный вес";
            }
            else if (bmi < 30)
            {
                description = "Избыточный вес";
            }
            else
            {
                description = "Ожирение";
            }

            return new BMIResult
            {
                BMI = bmi,
                Description = description
            };
        }
    }

    public class Programm
    {
        static void Main(string[] args)
        {
            BMIResult.CalculateBMI(170, 55);
        }
    }
}
