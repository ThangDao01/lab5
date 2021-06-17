namespace Part3._2
{
    public class UniversityTeacher : AbstractTeacher
    {
        public string UniversityCode { get; set; }

        public override double CalculateSalary()
        {
            if (Bonus > 10000)
            {
                throw new AmoutException("Bonus is more than 10,000",Name);
            }

            var salary = BaseSalary * Level * Bonus;
            if (IsSenior && salary < 60000)
            {
                throw new AmoutException("Senior Lecture gets less than 60,000 salary",Name);
            }
            return salary;        }
    }
}