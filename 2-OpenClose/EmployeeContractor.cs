namespace OpenClose
{
        public class EmployeeContractor : IEmployee
    {
        public EmployeeContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  

        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 25000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}