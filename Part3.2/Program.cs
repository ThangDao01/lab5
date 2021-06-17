using System;
using System.Data.Odbc;
using System.Xml.Schema;
namespace Part3._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var higtSchoolTeacher = new HighSchoolTeacher
            {
                IdentityNumber = "A001",
                Name = "Dao Duy Thang",
                BaseSalary = 100,
                Level = 1,
                Bonus = 100,
                IsSenior = false,
                HighSchoolCode = "HS001"
            };
            var universityTeacher = new UniversityTeacher
            {
                IdentityNumber = "T001",
                Name = "Dao Hong Luyen",
                BaseSalary = 60000,
                Level = 1,
                Bonus = 9000,
                IsSenior = true,
                UniversityCode = "UN001"
            };
            Console.WriteLine(universityTeacher.CalculateSalary());
            Console.WriteLine(higtSchoolTeacher.CalculateSalary());

        }
    }
}